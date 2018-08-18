app.controller('produto-cadastro-controller',
    function ($scope, $produtoServices, $estoqueServices) {
        $scope.model = {
            Nome: '',
            Preco: 0,
            Quantidade: 0,
            IdEstoque: ''
        };

        $scope.obterEstoques = function () {
            //Executar serviço de consulta de estoques da API
            $estoqueServices.consultar()
                .then(function (d) {
                    console.log("sucesso", d);

                    //$scope.sucesso = 'Produto cadastrado com sucesso!';
                    //$scope.model.Nome = '';
                    $scope.EstoqueList = d.data;

                })
                .catch(function (e) {
                    //if (e.status == 500)
                    //    $scope.erro = 'Ocorreu um erro:' + e.data;
                    //else if (e.status == 400) {
                    //    $scope.erro = 'Ocorreram erros de validação.';
                    //    $scope.validacoes = e.data;
                    //}

                })
                .finally(function () {
                    //$scope.desabilitarBotao = false;
                });
        };

        $scope.cadastrar = function () {
            $scope.desabilitarBotao = true;
            $scope.sucesso = '';
            $scope.erro = '';
            $scope.validacoes = [];

            $produtoServices.cadastrar($scope.model)
                .then(function (d) {
                    console.log("sucesso", d);

                    $scope.sucesso = 'Produto cadastrado com sucesso!';
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