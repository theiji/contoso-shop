// definindo módulo raiz
angular.module('app', []);

angular.module('app').
    controller('createProductController', createProductController);

angular.module('app').
    controller('listProductsController', listProductsController);

var apiBaseAddress = 'http://localhost:51309';

function listProductsController($http)
{
    var vm = this;

    vm.products = [];

    vm.load = load;

    function load()
    {
        $http.get(apiBaseAddress + '/products').then(showData);
    }

    function showData(response)
    {
        vm.products = response.data;
    }
}

function createProductController($http)
{
    var vm = this;

    vm.form = {};
    vm.save = save;

    function save()
    {
        // TODO: Criar combo de seleção
        vm.form.departamentId = 1;

        $http.post(apiBaseAddress + '/products', vm.form).
            then(showSuccess, showError);

        console.log(vm.form);
    }

    function showError(response)
    {
        console.error(response);

        window.alert('Falha');
    }

    function showSuccess()
    {
        vm.form = {};

        window.alert('Sucesso');
    }
}