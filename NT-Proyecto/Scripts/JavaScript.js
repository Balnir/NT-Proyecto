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

function submitSuper() {
    document.MyForm.submit();
    return;
}


/*carga dinamica de las views*/
$(document).ready(function () {

    const url = 'https://api.myjson.com/bins/rjt7a';
    let banner = $('#banner');
    var categoria;
    var busqueda = $('h1').text().toLowerCase();

    if (busqueda == "almacen") {
        categoria = "almacen";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/almacen-superior.png"></div>');
    } else if (busqueda == "bebidas") {
        categoria = "bebidas";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/bebidas-superior.png"></div>');
    } else if (busqueda == "congelados") {
        categoria = "congelados";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/congelados-superior.png"></div>');
    } else if (busqueda == "lacteos") {
        categoria = "lacteos";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/lacteos-superior.png"></div>');
    } else if (busqueda == "limpieza") {
        categoria = "limpieza";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/limpieza-superior.png"></div>');
    } else if (busqueda == "perfumeria") {
        categoria = "perfumeria";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/perfumeria-superior.png"></div>');
    } else if (busqueda == "coto") {
        categoria = "coto";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/coto.png"></div>');
    } else if (busqueda == "disco") {
        categoria = "disco"
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/disco.jpg"></div>');
    } else if (busqueda == "walmart") {
        categoria = "walmart";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/walmart.png"></div>');
    } else if (busqueda == "carrefour") {
        categoria = "carrefour";
        banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/carrefour2.jpg"></div>');
    } else {
        categoria = $('h1').text().toLowerCase().split(" ").join("");
        console.log(categoria);
        document.getElementById("titulo").style.marginTop = "75px";
    }
    
    var i = 0;
    var j = 0;
    search = false;
    $.getJSON(url, function (data) {
        $.each(data, function (key, entry) {

                if (entry.tags.toLowerCase().includes(categoria)) {

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
                    items_img.append($('<img class="item-imagen" id="item_image">').attr('src', entry.imagen));
                    items_img.append($('<img class="item-imagen-super" id="item_image">').attr('src', entry.supermercado));
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
                    search = true;
                }
            
        })
        if (search != true) {
            banner.empty();
            banner.append('<div class="col-md-12"><img class="superior" src="../Content/img/sad.jpg"></div>');
            document.getElementById("titulo").style.marginTop = "300px";
            let rows = $('#container');
            rows.append('<div class="row margen" id="row_productos">');
            let row_items = $("#row_productos");
            row_items.append('<div class="col-md-12" id="col_producto" align="center"><h1>No se han encontrado resultados</h1>');
        }
    });
   
});
