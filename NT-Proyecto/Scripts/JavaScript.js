/*modal*/
$("#login").click(function () {
    $("#myModal").modal();
});

/*dropdown barrios*/``
$(document).ready(function () {

    let dropdown = $("#barrio");
    dropdown.empty();

    dropdown.append('<option selected="true" disabled>Seleccione su barrio</option>');
    dropdown.prop('selectedIndex', 0);

    const url = 'https://api.myjson.com/bins/rrlzm';

    $.getJSON(url, function (data) {
        $.each(data, function (key, entry) {
            dropdown.append($('<option></option>').attr('value', entry.abbreviation).text(entry.name));
        })
    });
});

/*validate pass y vencimiento tarjeta*/
$(document).ready(function () {
    bootstrapValidate(
        '#email',
        'email:Por favor ingrese un e-mail válido'
    );
    bootstrapValidate('#pass', 'min:8:Ingrese al menos 8 caracteres');
    bootstrapValidate('#pass', 'regex:^[a-zA-Z0-9]+$:Debe tener sólo letras y/o numeros');
    bootstrapValidate('#pass2', 'matches:#pass:Las contraseñas no coinciden');
    bootstrapValidate('#tarjeta-vencimiento', 'numeric:Ingrese sólo números');
    bootstrapValidate('#tarjeta-vencimiento', 'min:4:Debe tener 4 dígitos');
    bootstrapValidate('#tarjeta-vencimiento', 'max:4:Debe tener 4 dígitos');

});

/*validate tarjeta*/
$("#tarjeta").change(function () {
    
    bootstrapValidate('#tarjeta-numero', 'numeric:Ingrese sólo números');
    bootstrapValidate('#tarjeta-codigo', 'numeric:Ingrese sólo números');

    if (value == "visa") {
        bootstrapValidate('#tarjeta-numero', 'min:16:Debe tener 16 dígitos');
        bootstrapValidate('#tarjeta-numero', 'max:16:Debe tener 16 dígitos');
        bootstrapValidate('#tarjeta-codigo', 'min:3:Debe tener 3 dígitos');
        bootstrapValidate('#tarjeta-codigo', 'max:3:Debe tener 3 dígitos');
    } else {
        bootstrapValidate('#tarjeta-numero', 'min:15:Debe tener 15 dígitos');
        bootstrapValidate('#tarjeta-numero', 'max:15:Debe tener 15 dígitos');
        bootstrapValidate('#tarjeta-codigo', 'min:4:Debe tener 4 dígitos');
        bootstrapValidate('#tarjeta-codigo', 'max:4:Debe tener de 4 dígitos');
    };
});


/*carga dinamica de las views*/
$(document).ready(function () {

    const url = 'https://api.myjson.com/bins/1ddxcu';
    let banner = $('#banner');
    var categoria;

    if ($('h1').text() == "almacen") {
        categoria = "almacen";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/almacen-superior.png"></div>');
    } else if ($('h1').text() == "bebidas") {
        categoria = "bebidas";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/bebidas-superior.png"></div>');
    } else if ($('h1').text() == "congelados") {
        categoria = "congelados";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/congelados-superior.png"></div>');
    } else if ($('h1').text() == "lacteos") {
        categoria = "lacteos";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/lacteos-superior.png"></div>');
    } else if ($('h1').text() == "limpieza") {
        categoria = "limpieza";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/limpieza-superior.png"></div>');
    } else if ($('h1').text() == "perfumeria") {
        categoria = "perfumeria";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/perfumeria-superior.png"></div>');
    } else if ($('h1').text() == "Coto") {
        categoria = "coto";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/coto.png"></div>');
    } else if ($('h1').text() == "Disco") {
        categoria = "disco;"
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/disco.jpg"></div>');
    } else if ($('h1').text() == "Walmart") {
        categoria = "walmart";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/walmart.png"></div>');
    } else if ($('h1').text() == "Carrefour") {
        categoria + "carrefour";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/carrefour2.jpg"></div>');
    } else {
        categoria = $('h1').text();
    }
    
    var i = 0;
    var j = 0;

    $.getJSON(url, function (data) {
        $.each(data, function (key, entry) {

            var tags = entry.tags.split(' ');
            var display = 0;
            tags.forEach(function (tag) {

                if (categoria.includes(tag) && (display==0)) {

                    let rows = $('#container');
                    var result = i % 4;

                    if (result == 0) {
                        j++;
                        rows.append('<div class="row margen" id="row_productos' + j + '">');
                    }

                    let row_items = $("#row_productos" + j);
                    row_items.append('<div class="col-md-3" id="col_producto' + i + '"><div class="item-contenedor" id="producto_contenedor' + i + '">');
                    let items = $("#producto_contenedor" + i);

                    items.append('<div id="producto_img' + i + '">')
                    let items_img = $("#producto_img" + i);
                    items_img.append($('<img class="item-imagen">').attr('src', entry.imagen));
                    items.append('</div>');

                    items.append('<div class="item-descripcion" id = "producto_des' + i + '">');
                    let items_des = $("#producto_des" + i);
                    items_des.append($('<p></p>').text(entry.descripcion));
                    items.append('</div>');

                    items.append('<div class="item-precio" id="producto_pre' + i + '">');
                    let items_pre = $("#producto_pre" + i);
                    items_pre.append($('<h4></h4>').text(entry.precio));
                    items.append('</div>');

                    items.append('<div class="item-comprar"><div class= "input-group"><input type="number" name="cantidad" class="form-control item-comprar-cantidad" value="1" min="1" max="20"><span class="input-group-btn"><button type="button" class="btn btn-default item-comprar-agregar" data-type="" data-field="">AGREGAR</button></span></div></div></div></div>');
                    i++;
                    if (result == 0) {
                        rows.append('</div>');
                    }
                    display = 1;
                }
            }); 
            
        })
    });
});
