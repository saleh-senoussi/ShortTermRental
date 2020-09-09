
$.validator.addMethod(
    'ValidateDateGreaterThanCheckIn',
    function (value, element, params) {
        return Date.parse(value) >= Date.parse(params.minumumdate);
    });

$.validator.unobtrusive.adapters.add(
    'ValidateDateGreaterThanCheckIn', ['checkin'], function (options) {
        var params = {
            minumumdate: options.params.minumumdate,
        };
        options.rules['ValidateDateGreaterThanCheckIn'] = params;
        options.messages['ValidateDateGreaterThanCheckIn'] = options.message;
});

$.validator.addMethod(
    'ValidateDateRange',
    function (value, element) {
        return Date.parse(value) >= Date.parse(Date.now());
    });

$.validator.unobtrusive.adapters.add(
    'ValidateDateRange', function (options) {
        options.messages['ValidateDateGreaterThanCheckIn'] = options.message;
    });