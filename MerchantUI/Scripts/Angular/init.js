var merchantModule = angular.module("merchantModule", ["ngRoute", "ui.bootstrap"]);

merchantModule.config(['$routeProvider', function ($routeProvider) {
    //$locationProvider.html5Mode(true);
    $routeProvider.when('/Home', {
        controller: "HomeCtrl",
        templateUrl: "/Content/Angular/Route/Home.html"
    })    
    .otherwise({
        templateUrl: '/Content/Angular/Route/Default.html'
    })
}]);