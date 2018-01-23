var myApp = angular.module("ngMyApp", []);
myApp.controller("ngMyController", ['$scope', function ($scope) {

    // LOGIN          
    $scope.loginSubmitForm = function (isValid) {

        // formun valid olup olmadığna bakılır.
        if (isValid) {
            alert('Login Form  tamamen doğru');
        }

    };

    $scope.registerSubmitForm = function (isValid) {

        // formun valid olup olmadığna bakılır.
        if (isValid) {
            alert('Register Form tamamen doğru');
        }

    };
  
}])

-

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

myApp.directive('mostRead', function () {
    return {
        templateUrl: '/home/mostRead'
    };
});

myApp.directive('mostCommented', function () {
    return {
        templateUrl: '/home/mostCommented'
    };
});

myApp.directive('lastQuestions', function () {
    return {
        templateUrl: '/home/lastQuestions'
    };
});

myApp.directive('contentDetail', function () {
    return {
        templateUrl: '/home/contentDetail'
    };
});

myApp.directive('trainingSets', function () {
    return {
        templateUrl: '/home/trainingSets'
    };
});