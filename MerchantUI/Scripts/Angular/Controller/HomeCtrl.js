var merchantModule = angular.module("merchantModule");

merchantModule.controller('HomeCtrl', function ($scope, $http, MerchantService) {
    
    $scope.pagination = undefined;
    $scope.merchants = [];
      
    $scope.pageNo = 1;
    $scope.recordCount = 10;

    $scope.getMerchants = function () {
        
        MerchantService.getMerchants($scope.pageNo, $scope.recordCount).then(function (response) {

            var result = [];
            for (var i = 0; i < response.data.data.length; i++) {
                merchant = {};

                merchant.display_name = response.data.data[i].display_name;
                merchant.email = response.data.data[i].email;
                merchant.phone = response.data.data[i].phone;
                merchant.status = response.data.data[i].status;
                merchant.logo = response.data.data[i].logo.path_to_file;


                var addr = response.data.data[i].address;

                var fullAddress = addr.address1;
                if (addr.address2) {
                    fullAddress = fullAddress + ",\r\n " + addr.address2;
                }
                fullAddress = fullAddress + ",\r\n " + addr.suburb;

                fullAddress = fullAddress + " - " + addr.postcode;

                merchant.displayAddress = fullAddress;

                result.push(merchant);
            }

            $scope.pagination = response.data.pagination;
            $scope.merchants = result;
        });
    }

    $scope.nextPage = function (pageNo) {
        $scope.pageNo = pageNo + 1;
        $scope.getMerchants();
        return false;
    }

    //Entry point...

    $scope.getMerchants();

});