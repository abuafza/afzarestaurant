// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification

// MINUS FUNCTION
function minus() {
    let beefStack = document.getElementById('beefStack');
    let quantityCounter = beefStack.textContent;

    let x = parseInt(quantityCounter, 2);
    if (x > 1) {
        beefStack.innerHTML = --x;
    } else {
        beefStack.innerHTML = x;
    }
}

// PLUS FUNCTION
function plus() {
    let beefStack = document.getElementById('beefStack');
    let quantityCounter = beefStack.textContent;

    let x = parseInt(quantityCounter, 2);
    beefStack.innerHTML = ++x;
}

// ADD ORDER FUNCTION
function addOrder() {
    let beefStack = document.getElementById('beefStack').textContent;
    let foodName = document.getElementById('foodName').textContent;
    let foodPrice = document.getElementById('foodPrice').textContent;
    let itemPrice = foodPrice * beefStack;

    let orderData = `<div class=" d-flex justify-content-between">
                        <p>${beefStack} x ${foodName}</p>
                        <p>$ ${itemPrice}</p>
                    </div>`;

    document.getElementById('orderList').innerHTML = orderData;
}

/* ---------------------------------------------------
	5 - Back to top Button 
----------------------------------------------------- */
/* show / hide the button */
var toTop = $('#to-top'),
	scrollTrig = 300, // 300px
	backTop = function () {
		var windScroll = $(window).scrollTop();
		if (windScroll >= scrollTrig) {
			toTop.addClass('show');
		} else {
			toTop.removeClass('show');
		}
	};
backTop();
$(window).on('scroll', function () {
	backTop();
});
/* Move to top after clicking on to-top button */
toTop.on('click', function () {
	$('html, body').animate({
		scrollTop: 0
	}, 1000);
});

/* ---------------------------------------------------