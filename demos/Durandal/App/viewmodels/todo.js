//TODO: Inject dependencies
define(['plugins/router','durandal/app'],
    function (router, app) {
        // Internal properties and functions
        var name = ko.observable();
        
        // Reveal the bindable properties and functions
        var vm = {
            activate: activate,
            goBack: goBack,
            title: 'todo',
            name: name,
            sayHello: function () { app.showMessage('Hello ' + name() + '!!!'); }
        };

        return vm;
        
        function activate (id, querystring) {
            //TODO: Initialize lookup data here.

            //TODO: Get the data for this viewmodel, return a promise.
        }

        function goBack(complete) {
            router.navigateBack();
        }
    });