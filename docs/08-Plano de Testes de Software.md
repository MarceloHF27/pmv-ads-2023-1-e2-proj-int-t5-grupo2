# Plano de Testes de Software

O plano de teste a seguir foi desenvolvido com o objetivo principal de estabelecer um roteiro claro e estruturado para testar um software e garantir que ele atenda aos requisitos e às expectativas de qualidade.

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>
 
| **Caso de Teste** 	| **CT-01 - Visualizar as notícias com os posts te todos os desaparecidos** 	|
|:---:	|:---:	|
|	Requisitos Associados 	| - RF-02 O site deve gerenciar as informações dos desaparecidos.<br> - RF-03 O sistema deve fornece campos para observações do desaparecido, ex: hora, data, roupa, local que o desaparecido foi visto por último. <br> - RF-05 O sistema deve conter um portal de notícias com todos os desaparecidos.  |
| Objetivo do Teste 	| Verificar se as informações com todos desaparecidos estão aparecendo corretamente na página. |
| Passos 	| 1 - Acessar o navegador <br>    2 - Acessar a página principal do site <br>    3 - Procurar por um link ou botão que leve ao portal de notícias com informações sobre todos os desaparecidos <br>    4 - Clicar no link ou botão para acessar o portal de notícias |
|Critério de Êxito | - O portal de notícias com informações sobre todos os desaparecidos deve ser exibido corretamente. <br>    - Todas as informações relevantes sobre os desaparecidos devem estar incluídas no portal de notícias, como nome, idade, data e local do desaparecimento, características físicas, entre outros. <br>    - As informações devem estar atualizadas e precisas, para ajudar na localização dos desaparecidos. <br>   - O portal de notícias deve ser atualizado regularmente com novas informações sobre pessoas desaparecidas. |
|:---:	|:---:	|
| **Caso de Teste** 	| **Teste CT-02 - Cadastro de usuário**	|
|Requisitos Associados | RF-09 O sistema deve fornecer cadastro/login a fim de assegurar as informações do usuário. |
| Objetivo do Teste 	| Verificar se o cadastro do usuário ocorre corretamente e de forma segura. |
| Passos 	| 1 - Acessar o navegador <br>    2 - Acessar a página de registro de usuário <br>    3 - Preencher as informações necessárias, como nome completo, endereço de e-mail e senha. <br>    4 - Clicar no botão "Registrar" |
|Critério de Êxito | - O usuário deve ser registrado com sucesso no sistema. <br>    - O sistema deve armazenar as informações do usuário de forma segura e protegida. <br>    - O usuário deve ser redirecionado para a página de login. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-03 - Login de usuário** 	|
|	Requisitos Associados 	| RF-09 O sistema deve fornecer cadastro/login a fim de assegurar as informações do usuário. |
| Objetivo do Teste 	| Verificar se login do usuário aconteça corretamente e de forma segura, liberando funcionalidades exclusivas de usuários cadastrados. |
| Passos 	| 1 - Acessar o navegador <br>    2 - Acessar a página de login <br>    3 - Preencher as informações de login, como endereço de e-mail e senha. <br>    4 - Clicar no botão "Entrar" |
|Critério de Êxito | - O usuário deve ser autenticado com sucesso no sistema. <br>    - O sistema deve redirecionar o usuário para a página inicial do site. <br>    - O usuário deve ter acesso às funcionalidades exclusivas para usuários registrados, como postar informações sobre pessoas desaparecidas ou interagir com outros posts. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-04 - Comentários em um posts**	|
|Requisitos Associados | RF-01 Interagir com os Posts de pessoas desaparecidas |
| Objetivo do Teste 	| Verificar se as interações com os posts estão acontecendo corretamente |
| Passos 	| 1 - Acessar o navegador <br>    2 - Realizar o login <br>    3 - Acessar um post <br>    4 - Comentar no post |
|Critério de Êxito | - O comentário deve ser postado com sucesso e aparecer na seção de comentários do post <br>    - O numero de comentários deve ser atualizado |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-05 - Compartilhamento de um posts** 	|
|	Requisitos Associados 	| RF-07 O site deve permitir o compartilhamento de desaparecidos em outras redes de comunicação |
| Objetivo do Teste 	| Verificar se as interações com os posts estão acontecendo corretamente. |
| Passos 	| 1 - Acessar o navegador <br>    2 - Realizar o login <br>    3 - Acessar um post <br>    4 - Compartilhar o post em uma rede social |
|Critério de Êxito | - O post deve ser compartilhado com sucesso na rede social. <br>    - O numero de compartilhamentos deve ser atualizado. <br>    - Deve ser possível visualizar o post compartilhado na rede social compartilhada. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-06 - Visualizar as informações de uma pessoa desaparecida no post**	|
|Requisitos Associados | RF-02 O site deve gerenciar as informações dos desaparecidos   <br>    RF-03 O sistema deve fornece campos para observações do desaparecido, ex: hora, data, roupa, local que o desaparecido foi visto por último. <br>    RF-04 O sistema deve ter a opção de anexar arquivos do desaparecido.   <br>    RF-11 O sistema deve ter a opção de atualizar o cadastro do desaparecido a partir de novas informações de seus familiares/amigos.  |
| Objetivo do Teste 	| Verificar se as informações nos posts estão sendo mostradas corretamente. |
| Passos 	| 1 - Acessar o navegador <br>    2 - Realizar o login <br>    3 - Acessar um post <br>    4 - Visualizar todas as informações como nome, idade, data e local do desaparecimento, características físicas, entre outras além de poder ver anexos relacionados a um desaparecido de forma correta. |
|Critério de Êxito | - As informações sobre a pessoa desaparecida devem ser exibidas corretamente no post. <br>    - Todas as informações relevantes sobre a pessoa desaparecida devem ser incluídas no post. <br>    - As informações devem ser apresentadas de forma clara e objetiva para facilitar a identificação da pessoa desaparecida. <br>    - Todas as informações devem estar atualizadas e precisas para ajudar na localização da pessoa desaparecida. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-07 - Visualizar página de recomendações e instruções** 	|
|	Requisitos Associados 	| RF-10 O sistema deve fornecer uma página com informações de precauções a fim de evitar que um familiar/amigo desapareça. |
| Objetivo do Teste 	| Verificar se as recomendações e instruções estão sendo apresentadas corretamente na página. |
| Passos 	| 1 - Acessar o navegador <br>    2 - Acessar a página principal do site <br>    3 - Clicar no link para a página de informações de precauções para evitar o desaparecimento de pessoase como proceder caso ocorra. |
|Critério de Êxito | - A página de informações de precauções deve ser exibida corretamente. <br>    - Todas as informações relevantes sobre precauções para evitar o desaparecimento de pessoas devem ser incluídas na página. <br>    - Todas as informações relevantes sobre como agir em caso de desaparecimento de pessoas devem ser incluídas na página. <br>    - As informações devem ser apresentadas de forma clara e objetiva para que o usuário possa entendê-las facilmente. <br>    - As informações devem ser baseadas em fontes confiáveis e atualizadas. <br>    - Todas as precauções devem ser descritas de forma a incentivar os usuários a segui-las. <br>    - As precauções devem ser específicas e práticas, de forma a ajudar os usuários a evitarem situações que possam resultar em um desaparecimento e como se comportar caso ocorra com algum conhecido. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-08 - Utilizar o filtro de busca de informações sobre pessoas desaparecidas**	|
|Requisitos Associados | RF-08 O sistema deve conter um filtro para encontrar as informações do desaparecido com mais facilidade.  <br>    RF-11 O sistema deve ter a opção de atualizar o cadastro do desaparecido a partir de novas informações de seus familiares/amigos.         |
| Objetivo do Teste 	| Verificar se o filtro de busca está preciso e funcionando corretamente. |
| Passos 	| 1 - Acessar o navegador <br>    2 - Acessar a página principal do site <br>    3 - Clicar no botão de busca ou no link para a página de busca de informações sobre pessoas desaparecidas <br>    4 - Preencher as informações do filtro de busca, como nome, idade, data e local do desaparecimento, características físicas, entre outros. <br>    5 - Clicar no botão "Buscar" |
|Critério de Êxito | - O sistema deve exibir as informações correspondentes às informações do filtro de busca. <br>    - Todas as informações relevantes sobre as pessoas desaparecidas encontradas devem ser exibidas corretamente. <br>    - As informações devem ser apresentadas de forma clara e objetiva para facilitar a identificação da pessoa desaparecida. <br>    - Todas as informações devem estar atualizadas e precisas para ajudar na localização da pessoa desaparecida. <br>    - O filtro de busca deve ser flexível e permitir ao usuário combinar diferentes critérios de busca para encontrar as informações do desaparecido com mais facilidade.<br>    - O filtro de busca deve ser fácil de usar e não deve apresentar erros ou problemas de funcionamento. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-09 - Acessar a página ou rodapé com informações de contato** 	|
|	Requisitos Associados 	| RF-06 O site deve apresentar uma página ou rodapé com as informações para contato com os mantedores do mesmo. |
| Objetivo do Teste 	| Verificar se as informações de contato estão sendo apresentadas corretamente na página ou rodapé. |
| Passos 	| 1 - Acessar o navegador <br>    2 - Acessar qualquer página do site <br>    3 - Procurar por um link ou botão que leve à página ou ir ao rodapé com informações de contato com os mantenedores do site <br>    4 - Clicar no link ou botão para acessar a página ou ir ao rodapé com informações de contato |
|Critério de Êxito | - A página ou rodapé com as informações de contato deve ser exibida corretamente. <br>    - Todas as informações relevantes sobre como contatar os mantenedores do site devem estar incluídas na página ou rodapé, como endereço de e-mail, número de telefone, endereço físico, entre outros. <br>    - As informações de contato devem estar atualizadas e precisas e serem apresentadas de forma clara e objetiva. |
|	|	|