app.controller('estoque-cadastro-controller',
    function ($scope, $estoqueServices) {
        $scope.model = {
            Nome: ''
        };

        $scope.cadastrar = function () {
            $scope.desabilitarBotao = true;
            $scope.sucesso = '';
            $scope.erro = '';
            $scope.validacoes = [];

            $estoqueServices.cadastrar($scope.model)
                .then(function (d) {
                    console.log("sucesso", d);

                    $scope.sucesso = 'Estoque cadastrado com sucesso!';
                    $scope.model.Nome = '';

                })
                .catch(function (e) {
                    if (e.status == 500)
                        $scope.erro = 'Ocorreu um erro:' + e.data;
                    else if (e.status == 400) {
                        $scope.erro = 'Ocorreram erros de validação.';
                        $scope.validacoes = e.data;
                    }

                })
                .finally(function () {
                    $scope.desabilitarBotao = false;
                });
        };
    });