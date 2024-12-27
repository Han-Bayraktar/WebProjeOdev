using System.Text.Json.Serialization;

public class ApiResponse
{
    [JsonPropertyName("request_id")]
    public string RequestId { get; set; }

    [JsonPropertyName("log_id")]
    public string LogId { get; set; }

    [JsonPropertyName("error_code")]
    public int ErrorCode { get; set; }

    [JsonPropertyName("error_code_str")]
    public string ErrorCodeStr { get; set; }

    [JsonPropertyName("error_msg")]
    public string ErrorMsg { get; set; }

    [JsonPropertyName("error_detail")]
    public ErrorDetail ErrorDetail { get; set; }

    [JsonPropertyName("data")]
    public Data Data { get; set; }
}

public class ErrorDetail
{
    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("code_message")]
    public string CodeMessage { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}

public class Data
{
    [JsonPropertyName("image")]
    public string Image { get; set; }
}
