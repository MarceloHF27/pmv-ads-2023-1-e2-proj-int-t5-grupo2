<?php
    if(isset($_POST['submit'])){

        include_once('conectDB.php');

        $nome = $_POST['nome'];
        $usuario = $_POST['usuario'];
        $senha =  $_POST['senha'];

        $result = mysqli_query($conexao, "INSERT INTO usuario(nome,usuario,senha) VALUES('$nome','$usuario','$senha')");
        header('Location: http://localhost/pmv-ads-2023-1-e2-proj-int-t5-grupo2/src/LOGIN/index.html');
        die();

        // O location do header é diferente para o xamp e wamp portanto é necessário alterar a localização para cada computador
        // No meu computador, utilizando o wamp o caminho correto fica: "C:\wamp64\www\pmv-ads-2023-1-e2-proj-int-t5-grupo2" mas no seu pode 
        // ser diferente então atente-se para isso
        

    }
?>