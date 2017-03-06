var merchantModule = angular.module("merchantModule");

merchantModule.controller('HomeCtrl', function ($scope, $http, MerchantService) {

    $scope.Test = "controller in place...";
    $scope.pagination = undefined;


    $scope.myNum = 5;



    $scope.getMerchants = function () {
        MerchantService.getMerchants(1, 10).then(function (data) {
            console.log('data')
            $scope.pagination = data.pagination;
        });
    }

    $scope.nextPage = function (pageNo) {
        console.log(pageNo);
        return false;
    }
});