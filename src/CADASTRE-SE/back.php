<?php
    if(isset($_GET['submit'])){

        include_once('conectbd.php');

        $nome = $_GET['nome'];
        $usuario = $_GET['usuario'];
        $senha =  $_GET['senha'];

        $result = mysqli_query($conexao, "INSERT INTO usuario(nome,usuario,senha) VALUES('$nome','$usuario','$senha')");

    }
?>