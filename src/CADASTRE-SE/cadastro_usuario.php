<?php
    if(isset($_POST['submit'])){

        include_once('conectDB.php');

        $nome = $_POST['nome'];
        $usuario = $_POST['usuario'];
        $senha =  $_POST['senha'];

        $sql = "SELECT * FROM usuarios WHERE nome = '$nome' and usuario = '$usuario'";
        
        $result = $conexao->query($sql);

    
        if(mysqli_num_rows ($result) < 1){
            
            $insert_bd = mysqli_query($conexao, "INSERT INTO usuarios(nome,usuario,senha) VALUES('$nome','$usuario','$senha')");
            header('Location: http://localhost:80/LOGIN/index.html');
            die();
        }
        else{
            print_r('esse usuário já existe');

            //aqui falta estilizar essa pagina, exibir um alert ou coisa do tipo ao invés de voltar pra pagina inicial ou de login

           
        }
        
        

        // O location do header é diferente para o xamp e wamp portanto é necessário alterar a localização para cada computador
        // No meu computador, utilizando o wamp o caminho correto fica: "C:\wamp64\www\pmv-ads-2023-1-e2-proj-int-t5-grupo2" mas no seu pode 
        // ser diferente então atente-se para isso
        




        


    }
?>