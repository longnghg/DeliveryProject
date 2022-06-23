
$.ajax({
    type: "GET",
    url: "/Cart/getAmountCart",
    success: function (respone) {
        $('.quantity').text(respone.amount)
    }
});

$('#ShowCart').click(function () {
    loadCart();
})
function loadCart() {
    $.ajax({
        type: "GET",
        url: "/Cart/Index/",
        success: function (viewHTML) {
            $("#gridViewCart").html(viewHTML);
            $('.product-item_remove').click(function () {
                var idProduct = $(this).data("value");
                console.log(idProduct);
                removeItemInCart(idProduct);
            })
        },
    });
}
$('a.category').click(function () {
    var catID = $(this).data('value');
    loadMainView(catID);
})

$('#FilterPrice').click(function () {
    console.log($("#amount").val())
})
function loadMainView(id) {
    $.ajax({
        type: "GET",
        data: {
            cat : id
        },
        url: "/Home/ViewProduct/",
        success: function (viewHTML) {
            $("#gridView").html(viewHTML);
            $('.addtoCart').click(function () {
                var idProduct = $(this).data("value");
                addToCart(idProduct);
            })
        },
    });
}


function loadMainProductView() {
    $.ajax({
        type: "GET",
        url: "/Product/ViewProduct/",
        success: function (viewHTML) {
            $("#gridView").html(viewHTML);
            $('.addtoCart').click(function () {
                var idProduct = $(this).data("value");
                addToCart(idProduct);
            })
        },
    });
}

// cart 
function loadCartDetails() {
    $.ajax({
        type: "GET",
        url: "/Cart/DetailsCartPartialView/",
        success: function (viewHTML) {
            $("#gridViewCartDetails").html(viewHTML);
            eventDetailsCart();
            $('.product-item_remove').click(function () {
                var idProduct = $(this).data("value");
                console.log(idProduct)
                removeItemInCart(idProduct);
            })
        },
    });
}

function eventDetailsCart() {
    $('.dec').click(function () {
        var id = $(this).data("idproduct");
        console.log(id);
        loadAmountDetailCart("DesAmount",id);
    })
    $('.inc').click(function () {

        var id = $(this).data("idproduct");

        loadAmountDetailCart("IncAmount",id);
    })
}
function loadAmountDetailCart(action,id) {
    $.ajax({
        type: "GET",
        data: {
            productID: id
        },
        url: "/Cart/" + action.toString() + "/",
        success: function (respone) {
            if (respone.success)
                loadCartDetails();
        },
    });
}

function removeItemInCart(idProduct) {
    $.ajax({
        type: "GET",
        url: "/Cart/Remove/",
        data: {
            productID: idProduct
        },
        success: function (result) {
            if (result.success) {
                loadCart();
                loadCartDetails();
                $('.quantity').text(result.amount);
            }
        },
    });
}

function addToCart(idProduct) {
    $.ajax({
        type: "GET",
        url: "/Cart/AddToCart/",
        data: {
            productID: idProduct
        },
        success: function (result) {
            if (result.success) {
                $('.quantity').text(result.amount);
            }
        },
    });
}



$('#priceFilter').change(function () {
    filter();
})
$('#sbOrdering').change(function () {
    filter();
})
$('#catFilter').change(function () {
    filter();
})
$('#searchName').click(function () {
    filter();
})
function filter() {
    var priceFilter = $('#priceFilter option:selected').val();
    var catFilter = $('#catFilter option:selected').val();
    var nameFilter = locdau($('#nameFilter').val());
    var ordering = $('#sbOrdering option:selected').val();
    $.ajax({
        type: "GET",
        data: {
            cat: catFilter,
            price: priceFilter,
            name: nameFilter,
            orderby: ordering
        },
        url: "/Product/ViewProduct/",
        success: function (viewHTML) {
            $("#gridView").html(viewHTML);
            $('.addtoCart').click(function () {
                var idProduct = $(this).data("value");
                addToCart(idProduct);
            });
        },
    });
}

function locdau(str) {
    str = str.replace(/à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ/g, "a");
    str = str.replace(/è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ/g, "e");
    str = str.replace(/ì|í|ị|ỉ|ĩ/g, "i");
    str = str.replace(/ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ/g, "o");
    str = str.replace(/ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ/g, "u");
    str = str.replace(/ỳ|ý|ỵ|ỷ|ỹ/g, "y");
    str = str.replace(/đ/g, "d");
    str = str.replace(/À|Á|Ạ|Ả|Ã|Â|Ầ|Ấ|Ậ|Ẩ|Ẫ|Ă|Ằ|Ắ|Ặ|Ẳ|Ẵ/g, "A");
    str = str.replace(/È|É|Ẹ|Ẻ|Ẽ|Ê|Ề|Ế|Ệ|Ể|Ễ/g, "E");
    str = str.replace(/Ì|Í|Ị|Ỉ|Ĩ/g, "I");
    str = str.replace(/Ò|Ó|Ọ|Ỏ|Õ|Ô|Ồ|Ố|Ộ|Ổ|Ỗ|Ơ|Ờ|Ớ|Ợ|Ở|Ỡ/g, "O");
    str = str.replace(/Ù|Ú|Ụ|Ủ|Ũ|Ư|Ừ|Ứ|Ự|Ử|Ữ/g, "U");
    str = str.replace(/Ỳ|Ý|Ỵ|Ỷ|Ỹ/g, "Y");
    str = str.replace(/Đ/g, "D");
    return str.toUpperCase();
}