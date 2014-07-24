var app = angular.module('Chirpster', ['ngRoute']);
app.config(function ($routeProvider, $httpProvider) {
    $routeProvider.when('/', {
        templateUrl: '/app/views/home.html',
        controller: 'homeController'
    })
    $routeProvider.when('/Profile', {
        templateUrl: '/app/views/Profile.html',
        controller: 'homeController'
    })

    $httpProvider.interceptors.push('AuthInterceptor');
})