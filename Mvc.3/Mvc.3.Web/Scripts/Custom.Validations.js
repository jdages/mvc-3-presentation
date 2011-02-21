/// <reference path="jquery-1.4.4-vsdoc.js" />
/// <reference path="jquery.validate.unobtrusive.js" />
/// <reference path="jquery.unobtrusive-ajax.js" />

$().ready(function () {
    $.validator.addMethod("startwitha", function (value, element, param) {
        return value[0] == 'a' || value[0] == 'A';
    });
});

$.validator.unobtrusive.adapters.add("startwitha", ['bonus'], function (options) {
    options.rules['startwitha'] = '#' + options.params.bonus;
    options.messages['startwitha'] = options.message;
});
   