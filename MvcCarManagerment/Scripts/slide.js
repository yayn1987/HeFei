//menu
$(document).ready(function(){
  
    $('#yc_wed').mousemove(function () {
        $(this).find('ul').slideDown();//you can give it a speed
    });
    $('#yc_wed').mouseleave(function () {
        $(this).find('ul').slideUp("fast");
    });
  
});