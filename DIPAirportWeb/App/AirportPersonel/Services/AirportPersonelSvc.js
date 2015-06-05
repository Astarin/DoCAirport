'use strict'
app.service('AirportPersonelSvc', [
    '$http',
    function ($http) {

        var serviceBase = 'http://localhost:2060/api';

        this.getAllAirportPersonel = function () {
            return $http.get(serviceBase + '/airportPersonel/all').then(function (data) {
                return data.data;
            });
        }

        this.getAirportPersonInfo = function(person) {
            return $http.post(serviceBase + '/airportPersonel/persondetail',person).then(function(data) {
                return data.data;
            });
        }

        this.editPerson = function(person) {
            return $http.put(serviceBase + '/airportPersonel/editperson', person);
        }
    }
]);