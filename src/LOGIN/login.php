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
         if($usuario === $verify_user && $senha === $verify_password ){
                header('Location: http://localhost:80/HOME-PAGESAIR/index.html');
                die();
                // direcionar para a homepage
         }else{
            echo("
                <script> 
                    window.location.href = 'http://localhost:80/LOGIN/index.html';
                    window.alert('Usuário ou Senha inválidos');
                </script>
            ");
            
         }
    }

?>