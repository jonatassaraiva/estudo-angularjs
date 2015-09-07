/// <reference path="/bower_components/angular/angular.js" />

(function () {
  var MainController = function ($scope, $http) {
    var onComplete = function (response) {
      $scope.user = response.data;
    };

    var onError = function (response) {
      $scope.error = 'Erro ao obter usuário';
    };

    $http.get('https://api.github.com/users/jonatassaraiva')
          .then(onComplete, onError);

    $scope.message = 'Olá AngularJS';
  }

  var app = angular.module('AngularApp', []);

  app.controller('MainController', MainController);
}());
