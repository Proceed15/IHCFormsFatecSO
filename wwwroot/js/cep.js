﻿function SearchZipCode() {
    let cep = document.getElementById("CEP").value;

    if (cep != "") {
        let url = "https://brasilapi.com.br/api/cep/v1/" + cep;

        let req = new XMLHttpRequest();

        req.open("GET", url);
        req.send();

        // trata a resposta
        req.onload = function () {
            if (req.status === 200) {
                let address = JSON.parse(req.response);

                document.getElementById("Rua").value = address.street.toUpperCase();
                document.getElementById("Bairro").value = address.neighborhood.toUpperCase();
                document.getElementById("Cidade").value = address.city.toUpperCase();
                document.getElementById("UF").value = address.state.toUpperCase();
''            }
            else if (req.status === 404) {
                alert("CEP ínválido");
            }
            else {
                alert("Erro ao fazer a requisição");
            }
        }
    }
}

window.onload = function () {
    let address_ZipCode = document.getElementById("CEP");
    address_ZipCode.addEventListener("blur", SearchZipCode);
}