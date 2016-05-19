$(function () {
    $("#submit").click(function () {
        $.ajax("/api/tradesuggestions", {
            data: "teamUrl=" + $('#teamUrl').val()
        }).done(function (data) {
            $('#rawResults').text(new Date().toJSON() + "\n" + data);
        })
    });



}());