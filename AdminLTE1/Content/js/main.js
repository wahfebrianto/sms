
$(document).ready(function () {
    $(".master").click(function () {
        $(".master > .collapse").toggleClass("in");
        $(this).toggleClass("active");
    });
});