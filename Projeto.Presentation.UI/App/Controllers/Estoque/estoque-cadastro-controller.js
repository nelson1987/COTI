app.controller('estoque-cadastro-controller',
    function ($scope, $estoqueServices) {
        $scope.model = {
            Nome: ''
        };

        $scope.Cadastrar = function () {
            $scope.sucesso = '';
            $scope.erro = '';

            $estoqueServices.cadastrar($scope.model)
                .then(function (d) {

                    $scope.sucesso = 'Estoque cadastrado com sucesso!';
                    $scope.model.Nome = '';

                })
                .catch(function (e) {

                    $scope.erro = 'Ocorreu um erro:' + e.data;

                });
        };
    });