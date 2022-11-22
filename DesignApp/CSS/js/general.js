jQuery(function($) {'use strict',
$(document).ready( function(){


	$(".sett").hide();
	$( ".setting" ).click(function() {

	  $( ".sett" ).slideToggle( "fast", function() {
	  });
	});

	$('.selectpicker').selectpicker();
	
	$(document).ready(function() {
	  var navpos = $('#navbar-wrap').offset();
	  console.log(navpos.top);
	    $(window).bind('scroll', function() {
	      if ($(window).scrollTop() > navpos.top) {
	        $('#navbar-wrap').addClass('navbar-wrap-fix');
	       }
	       else {
	         $('#navbar-wrap').removeClass('navbar-wrap-fix');
	       }
	    });
	});


});
});