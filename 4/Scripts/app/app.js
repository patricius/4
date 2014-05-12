
var app = angular.module('FoursquareApp', ['ngRoute', 'ngResource', 'ui.bootstrap', 'toaster', 'chieffancypants.loadingBar']);

app.config(function ($routeProvider) {

    $routeProvider.when("/explore", {
        controller: "placesExplorerController",
        templateUrl: "scripts/app/views/placesresults.html"
    });

    $routeProvider.when("/places", {
        controller: "myPlacesController",
        templateUrl: "scripts/app/views/myplaces.html"
    });

    $routeProvider.when("/about", {
        controller: "aboutController",
        templateUrl: "scripts/app/views/about.html"
    });

    $routeProvider.otherwise({ redirectTo: "/explore" });

});