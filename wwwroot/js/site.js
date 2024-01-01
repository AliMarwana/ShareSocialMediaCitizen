// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function shareOnFacebook() {
       $.ajax({
        type: "GET",
        url: '/Home/BtnFacebook',
        method: "GET",

        success: function (url) {

            var a = document.createElement("a");
            a.href = "https://www.facebook.com/sharer/sharer.php?u="+encodeURIComponent(url);
            a.target="_blank";
            a.rel = "noopener noreferrer";
            a.click();
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log("Custom error : " + jqXHR.responseText + " Status: " + textStatus + " Http error:" + errorThrown);
        }
    });


}