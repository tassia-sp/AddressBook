(function () {
    angular.module("myWebApp")
        .factory('$peopleService', PeopleService)

    PeopleService.$inject = ['$http'];

    function PeopleService($http) {
        return {
            getPeople: _getPeople,
        };

        function _getPeople() {
            console.log("getting people...");
            return $http.get('/api/people')
                .then(onSuccessGetPeople)
                .catch(onError);
        }

        function onSuccessGetPeople(response) {
            console.log("In onSuccessGetPeople");
            return response.data;
        }

        function _PostPeople() {
            console.log("In PostPeople()");
            return $http.get('/api/people')
                .then(onSuccessPostPeople)
                .catch(onError);
        }

        function onSuccessPostPeople(response) {
            console.log("In onSuccessPostPeople");
            return response.data;
        }

        function onError() {
            console.log("In PeopleService.onError");
        }
    }
})();