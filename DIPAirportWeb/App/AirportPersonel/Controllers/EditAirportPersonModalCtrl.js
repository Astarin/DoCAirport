(function() {
    'use strict'
    app.controller('EditAirportPersonModalCtrl', EditAirportPersonModalCtrl);

    function EditAirportPersonModalCtrl($scope, $modalInstance, person, AirportPersonelSvc) {
            $scope.editedPerson = person;

            $scope.close = function() {
                $modalInstance.close();
            }

            $scope.editPerson = function() {
                return AirportPersonelSvc.editPerson($scope.editedPerson).then(function (response) {
                    if (response.statusText === "OK") {
                        $modalInstance.close();
                    }
                });
            }
        };
})();