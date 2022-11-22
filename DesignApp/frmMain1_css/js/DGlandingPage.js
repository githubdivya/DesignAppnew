$(document).ready(function () {

  $("#logoSlider").owlCarousel({
    items: 3,
    autoplay: true,
    loop: true,
    nav: true,
    dots: false,
  });

  $(".main-header .main-navbar li").click(function(){
    if($(this).hasClass("active")){
      $(this).removeClass("active");
    }else{
      $(".main-header .main-navbar li").removeClass("active");
      $(this).addClass("active");
    }
  });

  
});
