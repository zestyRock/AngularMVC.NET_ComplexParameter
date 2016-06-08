angular.module("service")
    .factory("todoService", ["$location", "$http", function($location, $http) {
        var baseUrl = $location.protocol() + "://" + $location.host() + ":" + $location.port();

        var factory = {};

        factory.getTodoList = function() {
            var url = baseUrl + "/home/getalltodo";
            return $http.get(url);
        }

        factory.getFilteredTodo = function(params) {
            var url = baseUrl + "/home/GetFilteredTodo?filter=" + params;
            return $http.get(url);
        }
        return factory;
    }]);