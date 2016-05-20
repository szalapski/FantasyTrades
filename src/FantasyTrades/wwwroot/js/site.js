$(function () {
    $("#submit").click(function () {
        $.getJSON("/api/tradesuggestions","teamUrl=" + $('#teamUrl').val())
            .done(function (data)
            {
                $('#rawResults').text(new Date().toJSON() + "\n" + JSON.stringify(data, null, 2));
            })
    });



}());