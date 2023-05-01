const btnCadastrar = document.getElementById("btn-cadastrar");
    btnCadastrar.addEventListener("click", () => {
        // Ação de cadastro
        alert("Usuário cadastrado com sucesso!");
    });

document.getElementById("btn-cadastrar").addEventListener("click", function() {

    var nomeInput = document.getElementById("nome");
    var idadeInput = document.getElementById("idade");
    var fotoInput = document.getElementById("foto");
    var telefoneInput = document.getElementById("telefone");
    var descricaoInput = document.getElementById("descricao");
    nomeInput.value = "";
    idadeInput.value = "";
    fotoInput.value = "";
    telefoneInput.value = "";
    descricaoInput.value = "";
});

function voltar(){
    window.location.href = 'http://127.0.0.1:5500/src/HOME-PAGE/index.html';
}