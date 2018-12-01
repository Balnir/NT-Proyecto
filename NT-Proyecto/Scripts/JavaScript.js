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
