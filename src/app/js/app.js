(function () {
  var MainController = function ($scope, $http) {
    var onComplete = function (response) {
      $scope.users = response.data;
    };

    var onError = function (response) {
      $scope.error = 'Erro ao obter usuário';
    };

    $http.get('http://localhost/angular.content.api/users')
          .then(onComplete, onError);

    $scope.message = 'Olá AngularJS';
  }

  var app = angular.module('AngularApp', []);

  app.controller('MainController', MainController);
}());
