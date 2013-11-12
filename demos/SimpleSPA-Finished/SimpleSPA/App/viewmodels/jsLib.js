//TODO: Inject dependencies
define(['plugins/router', 'services/data'],
    function (router, data) {
        var vm = {
            activate: activate,
            goBack: goBack,
            title: 'JavaScript Libraries',
            libraries: ko.observableArray()
        };

        return vm;
        
        function activate (id, querystring) {
            var that = this;
            data.getLibraries().done(function(results) {
                that.libraries(results);
            });
        }

        function goBack(complete) {
            router.navigateBack();
        }
    });