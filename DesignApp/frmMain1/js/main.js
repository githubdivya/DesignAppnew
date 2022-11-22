//two-column-carousel
if ($('.two-column-carousel-2').length) {
    $('.two-column-carousel-2').owlCarousel({
        loop: true,
        margin: 30,
        nav: false,
        smartSpeed: 3000,
        draggable: false,
        mouseDrag: false,
        touchDrag: true,
        autoplay: 4000,
        navText: ['<span class="fas fa-arrow-left"></span>', '<span class="fas fa-arrow-right"></span>'],
        responsive: {
            0: {
                items: 1
            },
            576: {
                items: 1
            },
            768: {
                items: 2
            },
            992: {
                items: 3
            },
            1200: {
                items: 4
            }
        }
    });
}



$(function () {
    var tickerLength = $('.carousel-inner-data ul li').length;
    var tickerHeight = $('.carousel-inner-data ul li').outerHeight();
    $('.carousel-inner-data ul li:last-child').prependTo('.carousel-inner-data ul');
    $('.carousel-inner-data ul').css('marginTop', -tickerHeight);
    function moveTop() {
        $('.carousel-inner-data ul').animate({
            top: -tickerHeight
        }, 600, function () {
            $('.carousel-inner-data ul li:first-child').appendTo('.carousel-inner-data ul');
            $('.carousel-inner-data ul').css('top', '');
        });
    }
    setInterval(function () {
        moveTop();
    }, 3000);
});


function autocomplete(inp, arr) {
    /*the autocomplete function takes two arguments,
    the text field element and an array of possible autocompleted values:*/
    var currentFocus;
    /*execute a function when someone writes in the text field:*/
    inp.addEventListener("input", function (e) {
        var a, b, i, val = this.value;
        /*close any already open lists of autocompleted values*/
        closeAllLists();
        if (!val) { return false; }
        currentFocus = -1;
        /*create a DIV element that will contain the items (values):*/
        a = document.createElement("DIV");
        a.setAttribute("id", this.id + "autocomplete-list");
        a.setAttribute("class", "autocomplete-items");
        /*append the DIV element as a child of the autocomplete container:*/
        this.parentNode.appendChild(a);
        /*for each item in the array...*/
        for (i = 0; i < arr.length; i++) {
            /*check if the item starts with the same letters as the text field value:*/
            if (arr[i].substr(0, val.length).toUpperCase() == val.toUpperCase()) {
                /*create a DIV element for each matching element:*/
                b = document.createElement("DIV");
                /*make the matching letters bold:*/
                b.innerHTML = "<strong>" + arr[i].substr(0, val.length) + "</strong>";
                b.innerHTML += arr[i].substr(val.length);
                /*insert a input field that will hold the current array item's value:*/
                b.innerHTML += "<input type='hidden' value='" + arr[i] + "'>";
                /*execute a function when someone clicks on the item value (DIV element):*/
                b.addEventListener("click", function (e) {
                    /*insert the value for the autocomplete text field:*/
                    inp.value = this.getElementsByTagName("input")[0].value;
                    /*close the list of autocompleted values,
                    (or any other open lists of autocompleted values:*/
                    closeAllLists();
                });
                a.appendChild(b);
            }
        }
    });
    /*execute a function presses a key on the keyboard:*/
    inp.addEventListener("keydown", function (e) {
        var x = document.getElementById(this.id + "autocomplete-list");
        if (x) x = x.getElementsByTagName("div");
        if (e.keyCode == 40) {
            /*If the arrow DOWN key is pressed,
            increase the currentFocus variable:*/
            currentFocus++;
            /*and and make the current item more visible:*/
            addActive(x);
        } else if (e.keyCode == 38) { //up
            /*If the arrow UP key is pressed,
            decrease the currentFocus variable:*/
            currentFocus--;
            /*and and make the current item more visible:*/
            addActive(x);
        } else if (e.keyCode == 13) {
            /*If the ENTER key is pressed, prevent the form from being submitted,*/
            e.preventDefault();
            if (currentFocus > -1) {
                /*and simulate a click on the "active" item:*/
                if (x) x[currentFocus].click();
            }
        }
    });
    function addActive(x) {
        /*a function to classify an item as "active":*/
        if (!x) return false;
        /*start by removing the "active" class on all items:*/
        removeActive(x);
        if (currentFocus >= x.length) currentFocus = 0;
        if (currentFocus < 0) currentFocus = (x.length - 1);
        /*add class "autocomplete-active":*/
        x[currentFocus].classList.add("autocomplete-active");
    }
    function removeActive(x) {
        /*a function to remove the "active" class from all autocomplete items:*/
        for (var i = 0; i < x.length; i++) {
            x[i].classList.remove("autocomplete-active");
        }
    }
    function closeAllLists(elmnt) {
        /*close all autocomplete lists in the document,
        except the one passed as an argument:*/
        var x = document.getElementsByClassName("autocomplete-items");
        for (var i = 0; i < x.length; i++) {
            if (elmnt != x[i] && elmnt != inp) {
                x[i].parentNode.removeChild(x[i]);
            }
        }
    }
    /*execute a function when someone clicks in the document:*/
    document.addEventListener("click", function (e) {
        closeAllLists(e.target);
    });
}

/*An array containing all the country names in the world:*/
var countries = ["Domicile Certificate", "Senior Citizen Certificate", "Character Certificate", "Religious Minority Certificate", "Widow Certificate", "Non-Creamy layer Certificate For Gujarat Government", "Addition of Name in Ration Card", "Removal of Name from Ration Card", "Change in Ration Card", "Application for New Ration Card ", "Application for Separate Ration Card", "Application for Duplicate Ration Card", "Application for Ration Card Member guardian", "Religious Minority Certificate (Panchayat) (Rural)", "Widow Certificate (Panchayat) (Rural)", "Non-Creamy layer Certificate For Central Government", "Unreserved Economically Weaker Sections(For Job/Education Purpose)", "ST Caste Certificate (Panchayat) (Rural)", "ST Caste Certificate", "Income Certificate", "Farmer Certificate", "SEBC Certificate", "Application for Varsai Certificate", "Unreserved Caste Certificate(WithOut Income)", "Unreserved Caste Certificate(Panchayat-WithOut Income) (Rural)", "Eligibility Certificate for Economically Weaker Sections (With Income)", "Eligibility Certificate for Economically Weaker Sections (Panchayat-With Income) (Rural)", "Eligibility Certificate for Economically Weaker Sections (Panchayat-With Income) (Rural)", "Income and Assets Certificate of Economically Weaker Sections from Central Government", "SC Caste Certificate", "SC Caste Certificate (Panchayat) (Rural)", "COVID-19 Lockdown Exemption Pass for Movement out of Gujarat", "Pass for coming to Gujarat from other state", "VF6 ENTRY DETAILS", "VF7 SURVEY NO DETAILS", "VF8A KHATA DETAILS", "For  Candidates admitted at SPIPA & RTC’s for preparation of preliminary exam of the Civil Services Examination conducted by  UPSC (Monthly Stipend)", "For Candidates who have cleared preliminary exam of the Civil Services Examination conducted by UPSC & qualified for UPSC CSE Mains", "For Candidates who have cleared Mains Examination of Civil Services Examination conducted by UPSC &  selected for final personality test", "For Candidates who are finally selected in All India Civil Services", "Nomad-Denotified Caste Certificate", "Non-Creamy layer Certificate For Gujarat Government (Panchayat) (Rural)", "SEBC Certificate (Panchayat) (Rural)", "Income certificate (Panchayat) (Rural)"];

/*initiate the autocomplete function on the "myInput" element, and pass along the countries array as possible autocomplete values:*/
//autocomplete(document.getElementById("myInput"), countries);



/* ==========================================================================
   When document is Scrollig, do
   ========================================================================== */
$(document).ready(function () {
    // Show or hide the sticky footer button
    $(window).scroll(function () {
        if ($(this).scrollTop() > 400) {
            $('.scroll-top').fadeIn(400);
        } else {
            $('.scroll-top').fadeOut(400);
        }
    });

    // Animate the scroll to top
    $('.scroll-top').click(function (event) {
        event.preventDefault();

        $('html, body').animate({ scrollTop: 0 }, 300);
    })
});

/* ====================Main Nav Bar Active Class(Add/Remove) =========================== */

$(document).ready(function () {
    var url = window.location;
    $('ul.navbar-nav .nav-link[href="' + url + '"]').parent().addClass('active');
    $('ul.navbar-nav .nav-link').filter(function () {
        return this.href == url;
    }).parent().addClass('active');
});


/* ==================== Font Size =========================== */

    var $affectedElements = $("p, h1, h2, h3, h4, h5, h6, a, div, .nav-link"); // Can be extended, ex. $("div, p, span.someClass")

    // Storing the original size in a data attribute so size can be reset
    $affectedElements.each(function () {
        var $this = $(this);
        $this.data("orig-size", $this.css("font-size"));
    });

    $("#btn-increase").click(function () {
        changeFontSize(1);
    })

    $("#btn-decrease").click(function () {
        changeFontSize(-1);
    })

    $("#btn-orig").click(function () {
        $affectedElements.each(function () {
            var $this = $(this);
            $this.css("font-size", $this.data("orig-size"));
        });
    })

    function changeFontSize(direction) {
        $affectedElements.each(function () {
            var $this = $(this);
            $this.css("font-size", parseInt($this.css("font-size")) + direction);
        });
    }



/* ==================== Select Option Width =========================== */
