app.controller('produto-consulta-controller',
    function ($scope, $produtoServices) {
        $scope.erro = "";

        $produtoServices.consultar()
            .then(function (d) {

                $scope.produtoList = d.data;

            })
            .catch(function (e) {
                $scope.erro = "Ocorreu um erro: " + e.data;
            })
            .finally(function () {
                //TODO
            });
    });