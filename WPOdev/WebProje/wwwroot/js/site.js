// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
let scrollMargin = 0;

if (window.innerWidth > 1600) {
    scrollMargin = 10;
} else if (window.innerWidth <= 900) {
    scrollMargin = 50;
} else {
    scrollMargin = 0;
}

window.onresize = function (event) {
    if (window.innerWidth > 1600) {
        scrollMargin = 10;
    } else if (window.innerWidth <= 900) {
        scrollMargin = 50;
    } else {
        scrollMargin = 0;
    }
};

$("#Home-Nav").click(function () {
    $("html, body").animate(
        {
            scrollTop: $("#Home").offset().top,
        },
        1000
    );
    return false;
});



$("#Contact-Nav").click(function () {
    $("html,body ").animate(
        {
            scrollTop: $("#Contact").offset().top - scrollMargin,
        },
        1000
    );
    return false;
});
// Write your JavaScript code.
