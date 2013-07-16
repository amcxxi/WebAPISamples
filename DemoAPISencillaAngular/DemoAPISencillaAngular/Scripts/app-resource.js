var app = angular.module("paisesApp", ["ngResource"]);

var mainCtrl = function ($scope, $resource) {

    var paisesService = $resource('/api/values');

    var obtenerPaises = function () {
        paisesService.query({},
            function (data) {
                $scope.paises = data;
            },
            function (err) {
                $scope.error = err;
            }
        );
    };

    obtenerPaises();
}