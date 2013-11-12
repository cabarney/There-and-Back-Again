define(function () {
        var dataService = {
            getLibraries: getLibraries
        };
        return dataService;

        function getLibraries() {
            var options = {
                url: 'api/javascriptlibs',
                type: 'GET',
                datatype: 'json'
            };
            return $.ajax(options);
        };
    });