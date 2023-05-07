<?php

    if(isset($_POST['submit'])){

        include_once('conectDB.php');

        $usuario = $_POST['usuario'];
        $senha = $_POST['senha'];

        $sql = "SELECT usuario, senha FROM usuarios WHERE usuario = '$usuario'";
        
        $result = $conexao -> query($sql);

        $verify_user;
        $verify_password;

        while($user_data = mysqli_fetch_assoc($result)){
            $verify_user = $user_data['usuario'];
            $verify_password = $user_data['senha'];
        }
         if($usuario == $verify_user){
            if($senha == $verify_password){
                print_r('Entrou com sucesso');
                // direcionar para a homepage
            }
            else{
                print_r('Senha ou Usuário errado');
                // Voltar para area de login
            }
         }
         else{
            print_r('Senha ou Usuário errado');
            // Voltar para area de login
        }


    }

?>