angular.module("sportsStore", ["customFilters", "cart", "ngRoute"])
    .config(function ($routeProvider) {
        $routeProvider.when("/checkout", {
            templateUrl: "/Components/Checkout/checkoutSummary.html"
        })
            .when("/products", {
                templateUrl: "/Templates/productList.html"
            })
            .when("/complete", {
                templateUrl:"/Templates/thankYou.html"
            })
            .when("/placeOrder", {
                templateUrl:"/Templates/placeOrder.html"
            })
            .otherwise({
                templateUrl: "/Templates/productList.html"
            });
    });

angular.module("sportsStore")
    .constant("dataUrl", "http://localhost:61763/api/ProductsApi")
    .controller("sportsStoreCtrl", function ($scope, $http, dataUrl) {
        //$scope.data = {
        //    products: [
        //        { name: "Product #1", description: "A product", category: "Category #1", price: 100 },
        //        { name: "Product #2", description: "A product", category: "Category #1", price: 110 },
        //        { name: "Product #3", description: "A product", category: "Category #2", price: 210 },
        //        { name: "Product #4", description: "A product", category: "Category #3", price: 202 }
        //    ]
        //};

        $scope.data = {};
        $http.get(dataUrl).success(function (data) {
            $scope.data.products = data;
        })
            .error(function (error) {
                $scope.data.error = error;
            });
    });