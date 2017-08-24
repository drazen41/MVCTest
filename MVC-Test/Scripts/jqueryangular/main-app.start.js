"use strict";

angular.module('MainApp', [
])



    
.controller("MainController", function ($scope, $http) {

    var config = {
        headers: {
            'X-ZUMO-APPLICATION': 'ImDNVYiBYFCuENASFmQupAMlDUzamP37'
        }
    };
    $scope.hello = "Hi there";
  getNames();

  $scope.people_old = [{ 'Name': 'Judy', 'Location': 'NYC' }, { 'Name': 'Mary', 'Location': 'Goston' }];
  $scope.people = [];
  $scope._name     = "Default Name";
  $scope._location = "Default Location";
  $scope.user      = {

    Name:function(theName){
      if(angular.isDefined(theName)){
        this._name = theName;
      }
      return this._name;
    },

    Location:function(theLocation){
      if(angular.isDefined(theLocation)){
        this._location = theLocation;
      }
      return this._location;
    }
  }

  function getNames() {
      $http.get('http://localhost/MVC-Test/api/people/getallpeople')
   .then(function (res) {
       console.log(res);
       $scope.people = res.data;
   });
  }
// add in resource 
 function addName(user){
     //$scope.categories.push(user);
     $http.post('http://localhost/MVC-Test/api/people/post', user)
       .then(function (res) {
           $scope.getNames();
       });
     console.log("Add user name" + user.name);
 }

 $scope.addName = addName;
 $scope.getNames = getNames;

})

