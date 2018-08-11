﻿var app = angular.module(
    'appAula',
    ['ngRoute']
);

app.config(function ($routeProvider) {

    $routeProvider
        .when('/estoque/cadastro', //ROTA..
            {
                templateUrl: '/App/Views/Estoque/cadastro.html',
                controller: 'estoque-cadastro-controller'
            }
        )
        .when('/estoque/consulta', //ROTA..
            {
                templateUrl: '/App/Views/Estoque/consulta.html',
                controller: 'estoque-consulta-controller'
            }
        )
        .when('/produto/cadastro', //ROTA..
            {
                templateUrl: '/App/Views/Produto/cadastro.html',
                controller: 'produto-cadastro-controller'
            }
        )
        .when('/produto/consulta', //ROTA..
            {
                templateUrl: '/App/Views/Produto/consulta.html',
                controller: 'produto-consulta-controller'
            }
        );
});


app.config(function ($locationProvider) {
    $locationProvider.hashPrefix('');
});
