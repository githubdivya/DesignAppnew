/*---------------------------------------------------------------------*/
;(function($){

/*================= Global Variable Start =================*/		   
var isMobile = /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent);
var IEbellow9 = !$.support.leadingWhitespace;
var iPhoneAndiPad = /iPhone|iPod/i.test(navigator.userAgent);
var isIE = navigator.userAgent.indexOf('MSIE') !== -1 || navigator.appVersion.indexOf('Trident/') > 0;
function isIEver () {
  var myNav = navigator.userAgent.toLowerCase();
  return (myNav.indexOf('msie') != -1) ? parseInt(myNav.split('msie')[1]) : false;
}
//if (isIEver () == 8) {}
		   
var jsFolder = "js/";
var cssFolder = "css/";	
var ww = document.body.clientWidth, wh = document.body.clientHeight;
var mobilePort = 960, ipadView = 1024, wideScreen = 1600;

/*================= Global Variable End =================*/	

//css3 style calling 
document.write('<link rel="stylesheet" type="text/css" href="' + cssFolder +'animate.css">');	

/*================= On Document Load Start =================*/	
$(document).ready( function(){
	$('body').removeClass('noJS').addClass("hasJS");
	$(this).scrollTop(0);
	getWidth();
	
	//Set Element to vertical center using padding
	 $.fn.verticalAlign = function () {return this.css("padding-top", ($(this).parent().height() - $(this).height()) / 2 + 'px');};
	 
	setTimeout(function(){
		$('.vCenter').each(function () {$(this).verticalAlign();});
	}, 800);
	
	// Index Banner Slider	
		if($(".counterSlider ").length){		
	var swiper = new Swiper(".counterSlider .swiper-container", {
      	pagination: '.swiper-pagination',
        paginationClickable: true,
        nextButton: '.swiper-button-next1',
        prevButton: '.swiper-button-prev1',
		autoplay:5000,
		loop: true,	
		spaceBetween: 20,
		slidesPerView:3,
		speed: 800,
		breakpoints: {		
		959: {
                slidesPerView: 5,
                spaceBetween: 20,			
            },
		639: {
                slidesPerView: 3,
                spaceBetween: 20,			
        }
		}
	});
	$('.start-autoplay').on('click', function () {
   swiper.startAutoplay();
   $('.stop-autoplay').show();
});
$('.stop-autoplay').on('click', function () {
   swiper.stopAutoplay();
    $('.start-autoplay').show();
	 $('.stop-autoplay').hide();
});
$('.sliderBanner .swiper-slide').each(function(){
			var banimgSrc = $(this).find('img').attr('src');		
			$(this).css('background-image', 'url(' + banimgSrc +')');
		});
		}
		
		//counter
		if( $(".count").length){
		$('.count').counterUp({
						delay: 10,
						time: 2000
					});
		}
				if( $(".hasMenu").length){
		$(".hasMenu").on("click",function(event){
				event.preventDefault();						  
		if($(this).next().is(":visible")){
		$(this).removeClass("active");
		$(this).next().slideUp();		
		}else{
		$(".hasMenu").removeClass("active");	
		$(".subMenuList").slideUp();
		$(this).addClass("active");
		$(this).next().slideDown();
		}								 
		});
		$(document).bind('mousedown touchstart', function(e) {												  
			//if (ww < 767) {
				if ($(e.target).closest('.servicesSectorsWrap ').length === 0) {
									
						$(".hasMenu").removeClass("active");	
						$(".subMenuList").slideUp();
					
				}
			//}
		});	
		}
		//searchIcon
		if($(".searchIcon").length){
			$(".searchIcon").on("click",function(){
			$(this).next().slideToggle();
			$(this).toggleClass("active");
			})
			$(document).bind('mousedown touchstart', function(e) {												  
			//if (ww < 767) {
				if ($(e.target).closest('.topPart li:last-child ').length === 0) {
					$(".searchIcon").removeClass("active");
					$(".searchBox").hide();
					
				}
			//}
		});	
			}
	//footer Logo Slider
		if($(".footerLogoSlider").length){
		$(".footerLogoSlider").each(function(){
	var swiper = new Swiper(this, {
      	pagination: false,
        paginationClickable: false,        
		autoplay:false,
		speed: 800,
		loop:true,
		simulateTouch: false,
		spaceBetween: 30,
		slidesPerView:5,
		noSwiping:true,
		breakpoints: {		
		959: {
                slidesPerView: 4,
                spaceBetween: 30,			
				nextButton: '.swiper-button-next',
        		prevButton: '.swiper-button-prev',	
				simulateTouch: true
            },
      800: {
                slidesPerView: 3,
                spaceBetween: 10,
				nextButton: '.swiper-button-next',
        		prevButton: '.swiper-button-prev',	
				simulateTouch: true
            },
		639: {
                slidesPerView: 2,
                spaceBetween: 10,
				nextButton: '.swiper-button-next',
        		prevButton: '.swiper-button-prev',	
				simulateTouch: true
            },
			
		479: {
                slidesPerView: 1,
                spaceBetween: 10,
					simulateTouch: true
            }			
        }
    });
	});
		}
	/*// Inner Banner Slider	
	if( $(".slider").length) {
		var owl2 = $(".slider");
		var autoplay;
		if (owl2.children().length == 1) {autoplay = false	}
		else {autoplay = true}
		
		owl2.owlCarousel({
			loop:autoplay
			,autoplay:autoplay
			,mouseDrag:autoplay
			,autoplayTimeout:3000
			,autoplaySpeed:800
			,smartSpeed:1200
			,nav:autoplay
			,dots:autoplay
			,items : 1
			,autoplayHoverPause: true
			//dots : false		
			,onInitialized: function(event) {
				if (owl2.children().length > 1) { 
				}
			}
		});
	};
	
	
	if( $(".carouselBlock").length) {
		$('.carouselBlock').owlCarousel({
			 loop:true
			,autoplay:true
			,autoplayTimeout:3000
			,smartSpeed:1200
			,margin:10
			,nav:true
			,responsive:{
				0:{
					items:1
				},
				600:{
					items:3
				},
				1000:{
					items:5
				}
			}
		})
	};*/
	
	if( $(".marqueeScrolling li").length > 1){
		var $mq = $('.marquee').marquee({
			 speed: 25000
			,gap: 0
			,duplicated: true
			,pauseOnHover: true
			});
		$(".btnMPause").toggle(function(){
			$(this).addClass('play');
			$(this).text('Play');
			$mq.marquee('pause');
		},function(){
			$(this).removeClass('play');
			$(this).text('Pause');
			$mq.marquee('resume');
			return false;
		});
	};
	
	// Multiple Ticker	
	if( $(".ticker").length){
		$('.ticker').each(function(i){
			$(this).addClass('tickerDiv'+i).attr('id', 'ticker'+i);
			$('#ticker'+i).find('.tickerDivBlock').first().addClass('newsTikker'+i).attr('id', 'newsTikker'+i);
			$('#ticker'+i).find('a.playPause').attr('id', 'stopNews'+i)
			$('#newsTikker'+i).vTicker({ speed: 1E3, pause: 4E3, animation: "fade", mousePause: false, showItems: 3, height: 150, direction: 'up' })
			$("#stopNews"+i).click(function () {
				if($(this).hasClass('stop')){
					$(this).removeClass("stop").addClass("play").text("Play").attr('title', 'Play');
				}else{
					$(this).removeClass("play").addClass("stop").text("Pause").attr('title', 'pause');
				}
				return false;
			});
		});
	};
	
	
	
	// Responsive Tabing Script
	if( $(".resTab").length) {
		$('.resTab').responsiveTabs({
			 rotate: false
			,startCollapsed: 'tab' //accordion
			,collapsible: 'accordion' //accordion
			,scrollToAccordion: true
			,scrollToAccordionOnLoad:false
		});
	};
				
	if( $(".accordion").length){
	   $('.accordion .accordDetail').hide();
	   $(".accordion .accordDetail:first").show(); 
	   $(".accordion .accTrigger:first").addClass("active");	
	   $('.accordion .accTrigger').click(function(){
		  if ($(this).hasClass('active')) {
			   $(this).removeClass('active');
			   $(this).next().slideUp();
		  } else {
			  if ($('body').hasClass('desktop')) {
			   $('.accordion .accTrigger').removeClass('active');
			   $('.accordion .accordDetail').slideUp();
			  }
			   $(this).addClass('active');			   
			   $(this).next().slideDown();
		  }
		  return false;
	   });
	};
	
	if( $(".tableData").length > 0){
		$('.tableData').each(function(){
			$(this).wrap('<div class="tableOut"></div>');
			$(this).find('tr').each(function(){
			$(this).find('td:first').addClass('firstTd');
			$(this).find('th:first').addClass('firstTh');
			$(this).find('th:last').addClass('lastTh');
			});
			$(this).find('tr:last').addClass('lastTr');
			$(this).find('tr:even').addClass('evenRow');
			$(this).find('tr:nth-child(2)').find('th:first').removeClass('firstTh');
		});	
	};
	
	// Responsive Table
	if( $(".responsiveTable").length){
		$(".responsiveTable").each(function(){		
		$(this).find('td').removeAttr('width');
		//$(this).find('td').removeAttr('align');
		var head_col_count =  $(this).find('tr th').size();
		// loop which replaces td
		for ( i=0; i <= head_col_count; i++ )  {
			// head column label extraction
			var head_col_label = $(this).find('tr th:nth-child('+ i +')').text();
			// replaces td with <div class="column" data-label="label">
			$(this).find('tr td:nth-child('+ i +')').attr("data-label", head_col_label);
		}
		});
	};
	
	// Responsive Table
	if( $(".tableScroll").length){
		$(".tableScroll").each(function(){
			$(this).wrap('<div class="tableOut"></div>');
		});
	};
	// customSelect Table
	if($(".customSelect").length){
	 	$(".customSelect").customSelect();
	}
	// Back to Top function
	if( $("#backtotop").length){
		$(window).scroll(function(){
			if ($(window).scrollTop()>120){
			$('#backtotop').fadeIn('250').css('display','block');}
			else {
			$('#backtotop').fadeOut('250');}
		});
		$('#backtotop').click(function(){
			$('html, body').animate({scrollTop:0}, '200');
			return false;
		});
	};
	
	// Get Focus Inputbox
	if( $(".getFocus").length){
			$(".getFocus").each(function(){
			$(this).on("focus", function(){
			if ($(this).val() == $(this)[0].defaultValue) { $(this).val("");};
		  }).on("blur", function(){
			  if ($(this).val() == "") {$(this).val($(this)[0].defaultValue);};
		  });								  
		});
	};
	
	// For device checking
	if (isMobile == false) {
	
	};
	
	
	// Google Map gmap3 
	if( $("#gmap").length){	
	
		var lang = 23.021666;
		var lati = 72.55464;
		var contentString = '<div id="content">'+
	    '<strong>' + 'Silver Touch Technologies Limited' + '</strong>'+
	    '<div id="bodyContent">'+ '2nd Floor, Saffron Towers,' + '<br/>' +
		'Near Panchwati Circle,' + '<br/>' +
		'Ahmedabad, Gujarat 380006'
	    '</div></div>';
		
		var map = new google.maps.Map(document.getElementById('gmap'), {
		zoom: 15
		,center: new google.maps.LatLng(lang , lati)
		,mapTypeId: google.maps.MapTypeId.ROADMAP
		});	
		
	    var infowindow = new google.maps.InfoWindow({
	        content: contentString
	    });
		google.maps.event.addListener(map, 'click', function() {
		  infowindow.close();
		});
		var marker = new google.maps.Marker({
		  map: map,
		  position: new google.maps.LatLng(lang , lati)
		});
		google.maps.event.addListener(marker, 'click', function() {
	        infowindow.open(map,marker);
	    });
		infowindow.open(map,marker);
	};
	
	if( $(".litebox").length){	
		$('.litebox').liteBox();
	};	
	
	$('.equalHeights > div').equalHeight();
	
	setTimeout (function(){
		if( $(".fixedErrorMsg").length){					 
			$(".fixedErrorMsg").slideDown("slow");				 
			setTimeout( function(){$('.fixedErrorMsg').slideUp();},5000 );
		}
		if( $(".fixedSuccessMsg").length){					 
			$(".fixedSuccessMsg").slideDown("slow");				 
			setTimeout( function(){$('.fixedSuccessMsg').slideUp();},5000 );
		}
	},500);
	
	/*================= On Document Load and Resize Start =================*/
	$(window).on('resize', function () {
									 
		ww = document.body.clientWidth; 
		wh = document.body.clientHeight;		
		
		$('.vCenter').each(function () {$(this).verticalAlign();});	
		
		if($("body").hasClass("mobilePort")){
			$("body").removeClass("wob");
		}
		
		//$('.container').resize(function(){});
		
    }).trigger('resize');
	/*================= On Document Load and Resize End =================*/
	
	/*Navigation */
	if( $("#nav").length) {
		if($(".toggleMenu").length == 0){
			$("#mainNav").prepend('<a href="#" class="toggleMenu"><span class="menuTitle">Menu</span><span class="iconBar"></span></a>');	
		}
		$(".toggleMenu").click(function() {
			$(this).toggleClass("active");
			$("#nav").slideToggle();
			return false;
		});
		$("#nav li a").each(function() {
			if ($(this).next().length) {
				$(this).parent().addClass("parent");
			};
		})
		$("#nav li.parent").each(function () {
			if ($(this).has(".menuIcon").length <= 0) $(this).append('<i class="menuIcon">&nbsp;</i>')
		});
		dropdown('nav', 'hover', 1);
		adjustMenu();	
	};
	
if($('.datepicker').length){
	$.datepicker.setDefaults({
	  showOn: "both"
	  ,dateFormat:"dd/mm/yy"
	  ,changeMonth: true
	  ,changeYear: true
	  //,buttonImage: "images/calendar.png"
	 //,buttonImageOnly: true
	  ,shortYearCutoff: 50
	  ,buttonText: "<span class='sprite calIcon'></span>"
	  ,beforeShow: function (textbox, instance) {
		instance.dpDiv.css({
			marginTop: /*(textbox.offsetHeight)*/ 0 + 'px'
			,marginLeft: 0 + 'px'
		});
		}
	});
	
	$( ".datepicker" ).datepicker({
		   dateFormat:"dd/mm/yy"
		   ,showOn: "both"
		   ,buttonText: "<span class='sprite calIcon'></span>"
		   ,shortYearCutoff: 50
		 //,buttonImage: "images/calendar.png"
		 //,buttonImageOnly: true
		   ,beforeShow: function (textbox, instance) {
			instance.dpDiv.css({
					marginTop: /*(textbox.offsetHeight)*/ 0 + 'px'
					,marginLeft: 0 + 'px'
					});
			}
	  });	
}

if( $(".datetimepicker").length){
	$( ".datetimepicker" ).datetimepicker({
           dateFormat:"dd-mm-yy", 
           showOn: "both",
		   buttonText: "<span class='sprite calIcon'></span>",
           //buttonImage: "images/calendar.png"
           //buttonImageOnly: true,
		   beforeShow: function (textbox, instance) {
            instance.dpDiv.css({
                    marginTop: /*(textbox.offsetHeight)*/ 15 + 'px',
                    marginLeft: -13 + 'px'
            		});
    		}
      });
}

	
	// Message on Cookie Disabled
	$.cookie('cookieWorked', 'yes', { path: '/' });
	if ($.cookie('cookieWorked') == 'yes') {
		}
	else{
		if( $("div.jsRequired").length == 0){
			$("body").prepend(
				'<div class="jsRequired">Cookies are not enabled on your browser. Need to adjust this in your browser security preferences. Please enable cookies for better user experience.</div>'
			);	
		}
	}
	
});
/*================= On Document Load End =================*/

/*================= On Window Resize Start =================*/	
$(window).bind('resize orientationchange', function() {
	getWidth();												
	adjustMenu();
	$('.vCenter').each(function () {$(this).verticalAlign();});
});

/*================= On Window Resize End =================*/	

/*================= On Window Load Start =================*/
$(window).load(function() {
						
});
/*================= On Document Load End =================*/


function getWidth() {
	ww = document.body.clientWidth;
	if(ww>wideScreen){$('body').removeClass('device').addClass('desktop widerDesktop');}
	if(ww>mobilePort && ww<=wideScreen){	$('body').removeClass('device widerDesktop').addClass('desktop');}
	if(ww<=mobilePort) {$('body').removeClass('desktop widerDesktop').addClass('device');}
	if(ww > 767 && ww < 1025){$('body').addClass('ipad');}
	else {$('body').removeClass('ipad');}	
}

})(jQuery);


function validate() {
    return false;
};
