//$.ajax({
//    url: 'https://localhost:44399/cuenta/Efectivo',
//    type: 'get'
//}).done(function (response) {
//    $("div#cuerpo").html(response);
//});



//var h1 = $("h1#hola");
//var boton = $("button#boton");

//boton.click(function () {

//    if (h1.hasClass("black")) {
        
//    } else if (h1.hasClass("red")) {
//        h1.removeClass("red");
//        h1.addClass("black");
//    }
//});

//option.click(function () {

//});

function ddlselect() {
    var d = document.getElementById("seleccion");
    var displaytext = d.options[d.selectedIndex].value;
    document.getElementById("valorinput").value = displaytext;
    if (document.getElementById("valorinput").value == 1) {
        $.ajax({
            url: 'https://localhost:44399/cuenta/Efectivo',
            type: 'get'
        }).done(function (response) {
            $("div#cuerpo").html(response);
        });
    }

    if (document.getElementById("valorinput").value == 2) {
        $.ajax({
            url: 'https://localhost:44399/cuenta/CuentaBancaria',
            type: 'get'
        }).done(function (response) {
            $("div#cuerpo").html(response);
        });
    }
    if (document.getElementById("valorinput").value == 3) {
        $.ajax({
            url: 'https://localhost:44399/cuenta/TarjetaDébito',
            type: 'get'
        }).done(function (response) {
            $("div#cuerpo").html(response);
        });
    }
    if (document.getElementById("valorinput").value == 4) {
        $.ajax({
            url: 'https://localhost:44399/cuenta/TarjetaCrédito',
            type: 'get'
        }).done(function (response) {
            $("div#cuerpo").html(response);
        });
    }
    if (document.getElementById("valorinput").value == 5) {
        $.ajax({
            url: 'https://localhost:44399/cuenta/Electronica',
            type: 'get'
        }).done(function (response) {
            $("div#cuerpo").html(response);
        });
    }
    if (document.getElementById("valorinput").value == 6) {
        $.ajax({
            url: 'https://localhost:44399/cuenta/Activo',
            type: 'get'
        }).done(function (response) {
            $("div#cuerpo").html(response);
        });
    }
    if (document.getElementById("valorinput").value == 7) {
        $.ajax({
            url: 'https://localhost:44399/cuenta/Pasivo',
            type: 'get'
        }).done(function (response) {
            $("div#cuerpo").html(response);
        });
    }
    if (document.getElementById("valorinput").value == 8) {
        $.ajax({
            url: 'https://localhost:44399/cuenta/Indefinida',
            type: 'get'
        }).done(function (response) {
            $("div#cuerpo").html(response);
        });
    }
    
}

