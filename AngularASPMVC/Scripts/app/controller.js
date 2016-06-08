angular.module("controller")
    .controller("ctrl", ["$scope", "todoService", function($scope, todoservice) {
        todoservice.getTodoList().then(function(response) {
            $scope.allTodo = response.data.Data;
        }, function(err) {
            //error handling
        });

        var filter = {
            "Title": "Adele",
            "Color": "Yellow"
        };

        todoservice.getFilteredTodo(JSON.stringify(filter)).then(function(response) {
            $scope.filteredTodo = response.data.Data;
        }, function(err) {
            //error handling
        });
    }]);
