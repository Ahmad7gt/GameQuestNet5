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

$('#searchBtn').click(function () {

    var searchTerm = $('#searchInput').val();

    var route = "/Search/" + searchTerm

    window.location.replace(route);

});




$('#searchInput').keypress(function (e) {

    var key = e.which;

    if (key == 13)  // the enter key code
    {
        $('#searchBtn').click();
        return false;
    }

});   