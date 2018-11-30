$(document).ready(function () {

    var quantitiy = 0;
    $('.qty-plus').click(function (e) {

        // Stop acting like a button
        e.preventDefault();
        // Get the field name
        var quantity = parseInt($('#qty').val());

        // If is not undefined

        $('#qty').val(quantity + 1);


        // Increment

    });

    $('.qty-minus').click(function (e) {
        // Stop acting like a button
        e.preventDefault();
        // Get the field name
        var quantity = parseInt($('#qty').val());

        // If is not undefined

        // Increment
        if (quantity > 1) {
            $('#qty').val(quantity - 1);
        }
    });

});



$("#login").click(function () {
    $("#myModal").modal();
});

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
