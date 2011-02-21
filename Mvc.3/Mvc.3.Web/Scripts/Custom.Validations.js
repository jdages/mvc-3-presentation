/// <reference path="jquery-1.4.4-vsdoc.js" />
/// <reference path="jquery.validate.unobtrusive.js" />
/// <reference path="jquery.unobtrusive-ajax.js" />

$.validator.addMethod
(
    'startingLetter',
    function (inboundValue, element, parameters) {
        return false;
    },
    'Invalid starting letter'
);