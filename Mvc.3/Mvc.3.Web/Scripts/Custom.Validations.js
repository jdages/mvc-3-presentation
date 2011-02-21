/// <reference path="jquery-1.4.4-vsdoc.js" />
/// <reference path="jquery.validate.unobtrusive.js" />
/// <reference path="jquery.unobtrusive-ajax.js" />

$().ready(function () {
    $.validator.addMethod("startswitha", function (value, element, param) {
        return value[0] == 'a' || value[0] == 'A';
    });
});

$.validator.unobtrusive.adapters.add("startswitha", ['bonus'], function (options) {
    options.rules['startswitha'] = '#' + options.params.bonus;
    options.messages['startswitha'] = options.message;
});
   