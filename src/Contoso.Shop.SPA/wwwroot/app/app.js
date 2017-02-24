// definindo módulo raiz
angular.module('app', []);

angular.module('app').
    controller('createProductController', createProductController);

var apiBaseAddress = 'http://localhost:51309';

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
            then(showSuccess);

        console.log(vm.form);
    }

    function showSuccess()
    {
        vm.form = {};
        window.alert('Sucesso');
    }
}