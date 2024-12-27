﻿using WebProje.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Text.Json;

namespace WebProje.Controllers
{
    public class HairStyleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile imageFile, string hairType)
        {
            if (imageFile == null || string.IsNullOrEmpty(hairType))
            {
                ViewBag.Error = "Lütfen bir görsel dosyası seçin ve saç tipi belirtin.";
                return View();
            }

            try
            {
                // Convert the image file to a byte array
                byte[] fileData;
                using (var memoryStream = new MemoryStream())
                {
                    await imageFile.CopyToAsync(memoryStream);
                    fileData = memoryStream.ToArray();
                }

                // Create the API request
                var options = new RestClientOptions("https://www.ailabapi.com")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/portrait/effects/hairstyle-editor", Method.Post);
                request.AddHeader("ailabapi-api-key", "DMWlZNdh8Y7w9pDqvZ5M15aWozCLGYuwIir4SlA3ybsgEsxXqTVR3JUbhumkGgQT");
                request.AlwaysMultipartFormData = true;
                request.AddFile("image_target", fileData, imageFile.FileName, imageFile.ContentType);
                request.AddParameter("hair_type", hairType);

                // Execute the API request and get the response
                var response = await client.ExecuteAsync(request);

                // Log the full response content
                Console.WriteLine($"API Response: {response.Content}");

                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    Console.WriteLine("API çağrısı başarılı");

                    // Deserialize the response content to ApiResponse model
                    var apiResponse = JsonSerializer.Deserialize<ApiResponse>(response.Content);
                    ViewBag.ApiResponse = apiResponse;

                    // Log the deserialized object
                    Console.WriteLine($"Deserialized ApiResponse: {JsonSerializer.Serialize(apiResponse)}");

                    // Add the image data to ViewBag if available
                    if (!string.IsNullOrEmpty(apiResponse.Data?.Image))
                    {
                        ViewBag.ImageData = $"data:image/png;base64,{apiResponse.Data.Image}";
                        // Log the image data
                        Console.WriteLine($"Image Data: {ViewBag.ImageData}");
                    }
                }
                else
                {
                    Console.WriteLine($"Hata: {response.StatusCode} - {response.Content}");
                    ViewBag.Error = "API çağrısı başarısız oldu. Lütfen tekrar deneyin.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Bir hata oluştu: {ex.Message}";
            }

            return View();
        }
    }
}
