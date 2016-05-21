/// <reference path="lib/json-stringify-pretty-compact.js" />

$(function () {
    $("#submit").click(function () {
        $.getJSON("/api/tradesuggestions","teamUrl=" + $('#teamUrl').val())
            .done(function (data)
            {
                $('#rawResults').text(new Date().toJSON() + "\n" + lydellStringify(data, null, 2));
            })
    });



}());