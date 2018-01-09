var myApp = angular.module("ngMyApp", []);
myApp.controller("ngMyController", ['$scope', function ($scope) {
    $scope.myName = "volkan kılıç";
}])



// Directive
myApp.directive('searchBar', function () {
    return {
        templateUrl: '/home/searchBar'
    };
});

myApp.directive('contents', function () {
    return {
        templateUrl: '/home/contents'
    };
});

myApp.directive('coffeeBox', function () {
    return {
        templateUrl: '/home/coffeeBox'
    };
});