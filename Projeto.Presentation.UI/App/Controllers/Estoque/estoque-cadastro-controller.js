app.controller('estoque-cadastro-controller',
    function ($scope, $estoqueServices) {
        $scope.model = {
            Nome: ''
        };

        $scope.cadastrar = function () {
            $scope.desabilitarBotao = true;
            $scope.sucesso = '';
            $scope.erro = '';

            $estoqueServices.cadastrar($scope.model)
                .then(function (d) {
                    console.log("sucesso", d);

                    $scope.sucesso = 'Estoque cadastrado com sucesso!';
                    $scope.model.Nome = '';

                })
                .catch(function (e) {
                    console.log("erro", e);
                    $scope.erro = 'Ocorreu um erro:' + e.data;

                })
                .finally(function () {
                    $scope.desabilitarBotao = false;
                });
        };
    });