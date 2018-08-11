app.controller('estoque-consulta-controller',
    function ($scope, $estoqueServices) {

        $scope.erro = "";

        $estoqueServices.consultar()
            .then(function (d) {

                $scope.estoqueList = d.data;

            })
            .catch(function (e) {
                $scope.erro = "Ocorreu um erro: " + e.data;
            })
            .finally(function () {
                //TODO
            });
    });