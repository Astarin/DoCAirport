
var app = angular.module('app', ['ngRoute', 'LocalStorageModule', 'ui.bootstrap']);
app.config(function ($routeProvider) {

    $routeProvider
        .when('/home', {
            controller: 'HomeCtrl',
            templateUrl: '/App/Home/Views/Home.html'
        })
        .when('/airportPersonel', {
            controller: 'overviewCtrl',
            templateUrl: '/App/AirportPersonel/Views/AirportPersonelList.html'
        })
        .otherwise({
            redirectTo: '/home'
        });
});
app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});


