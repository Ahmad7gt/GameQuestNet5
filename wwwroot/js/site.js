// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('#categoryTrigger').hover(function () {

    $('#categoryNav').addClass('categoryOpen')
    $('#categoryNav').removeClass('categoryClosed')

})

$('#mainContainer').hover(function () {

    $('#categoryNav').addClass('categoryClosed')
    $('#categoryNav').removeClass('categoryOpen')

})


$('.carousel').carousel()