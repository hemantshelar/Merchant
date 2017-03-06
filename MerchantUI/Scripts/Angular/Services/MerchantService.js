var merchantModule = angular.module("merchantModule");

merchantModule.service('MerchantService', function ($http, $q) {

    var self = this;

    self.getMerchants = function (pageNo, noOfRecordsPerPage) {
        var defer = $q.defer();

        var url = 'http://api.demo.muulla.com/cms/merchant/all/active';
        url = url + '/' + noOfRecordsPerPage;
        url = url + '/' + pageNo;
       

        //Best way to inject this token is to write interceptor for $http
        $http.defaults.headers.common['Authorization'] = 'Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1NGQxOTY4MGI1MWMxNTI2MGI5NDRmZDUiLCJpc3N1ZV9kYXRlIjoiMjAxNS0wOS0wOVQwNToxMzo1My40NThaIn0.Hk2XypA_KMUnIKdSVYnwq3Rn3QyMNSQ-e80-sZsA9bY';

        $http({
            url: url,
            method: 'GET'
        }).then(function (response) {
            console.log('got data');
            defer.resolve(response.data);
        });

        return defer.promise;

    }

    return self;
});