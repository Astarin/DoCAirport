(function() {
    'use strict'
    app.controller('overviewCtrl', overviewCtrl);

    function overviewCtrl($scope, AirportPersonelSvc, $modal) {

        var init = function() {
            AirportPersonelSvc.getAllAirportPersonel().then(function(data) {
                $scope.list = data;
            });
        };

        $scope.info = function(id) {
            AirportPersonelSvc.getAirportPersonInfo(id).then(function(personFull) {
                if (personFull !== null) {
                    var modalInstance = $modal.open({
                        animation: true,
                        templateUrl: '/App/AirportPersonel/Views/EditAirportPersonModal.html',
                        controller: 'EditAirportPersonModalCtrl',
                        windowClass: 'center-modal',
                        resolve: {
                            person: function () { return personFull; }
                        }
                    });
                }
            });
        }

        init();
    }
})();
