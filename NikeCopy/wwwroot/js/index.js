$(document).ready(function () {
    console.log("Hello Pluralsight");

    //var theForm = document.getElementById("theForm");
    //theForm.hidden = true;
    var theForm = $("#theForm");
    theForm.hide();

    //var af1Button = document.getElementById("buyAF1");
    //af1Button.addEventListener("click", function () {
    //    console.log("buying item");
    //});

    var af1Button = $("#buyAF1");
    af1Button.on("click", function () {
        console.log("buying item");
    });

    //var productInfo = document.getElementsByClassName("product-info");
    //var listItems = productInfo.item(0).children;
    //console.log(listItems);

    var productInfo = $(".product-info li");
    productInfo.on("click", function () {
        console.log($(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");
    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);
    });
});
