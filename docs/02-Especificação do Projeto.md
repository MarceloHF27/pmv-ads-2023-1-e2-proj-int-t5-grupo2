# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários. 

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem. 

### Carlos Silva 
<img src="img/carlos.png" width="100px"/>

Idade: 20 

Ocupação: Programador junior e estudante de Engenharia da Computação 

Aplicativos: 
- Instagram 
- Twitter 
- YouTube 

Motivações:
- Familia 
- Realização pessoal 

Frustrações:
- Falta de tempo com sua familia 

Hobbies, História:

- Jogar e ver series
- Carlos é um rapaz de 20 anos apaixonado por tecnologia, ele está cursando o 5 período de engenharia computacional e trabalha em uma empresa de desenvolvimento de softwares. Carlos vive com seus pais e seu avô em um apartamento no centro de Belo Horizonte onde passa a maior parte de seu tempo livre jogando no computador. 

### Roseni Magalhães 
<img src="img/roseni.png" width="100px"/>

Idade: 50 

Ocupação: Doméstica 

Aplicativos: 
- Facebook 
- Whats App 

Motivações:
- Seus Filhos 
- Amor pelo que faz 

Frustrações:
- não poder dar uma vida melhor para os filhos 

Hobbies, História:
- Cozinhar e cuidar de sua pequena horta 
- Roseni é uma senhora de 58 que mora no interior de Minas Gerais com sua família, ela é esposa do João e mãe de 3 filhos jovens, entre seus 17 e 23 anos. Roseni trabalha como doméstica cuidando da casa enquanto seu marido trabalha em uma fazenda de café e devido sua condição mais humilde não tem muito contato com a tecnologia. 

### Sofia Santos
<img src="img/sofia.png" width="100px"/>

Idade: 32

Ocupação: digital "influencer", começou a cursar Artes Cênicas pela UFMG. Sofia é uma pessoa muito determinada e persistente. Ela não desiste facilmente de seus objetivos e sempre busca maneiras de superar obstáculos. Além disso, ela é muito solidária e empática, sempre colocando as necessidades dos outros em primeiro lugar. 

Aplicativos: 
- Facebook;
- Instagram; 
- Snapchat;
- Kwaii; 
- WhatsApp. 

Motivações:
- A principal motivação de Sofia é ajudar a encontrar pessoas desaparecidas e levar suas famílias a terem um pouco de paz. Ela acredita que, mesmo que não consiga encontrar sua amiga, pode ajudar outras pessoas a terem um final feliz em suas histórias. 

Frustrações:
- Sofia ainda não conseguiu encontrar sua amiga e isso tem sido uma grande fonte de frustração para ela. Além disso, ela enfrenta constantemente a dificuldade de lidar com pessoas que não levam a causa dos desaparecidos a sério.

Hobbies, História:
- praticar esportes ao ar livre, como corrida e escalada.
- Sofia é uma influenciadora digital que se destaca pelo seu estilo de vida saudável e dicas de moda e beleza. Ela é muito popular nas redes sociais, tendo mais de 500 mil seguidores no Instagram. No entanto, sua vida mudou completamente quando sua melhor amiga desapareceu sem deixar pistas. 


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Ana Silva           | O acesso a informações de pessoas desaparecida seja mais simples e menos burocrático.            | Para que seja mais acessível e fácil de se encontrar informações.               |
|Marcos Oliveira     | Ter acesso a mais informações dos desaparecidos.                | Entender melhor o “caso” e ter maior chance de encontrar essas pessoas.  |
|Luana Ferreira      | Que as informações estejam corretas e atualizadas.                 | Para que não haja problemas durante as buscas e seus direitos não sejam violados.  |
|Carlos Gomes        | Fazer comentários em notícias e reportar minha opinião.                | Discutir com grupos de interesse comum. |
|Sofia Santos        | Compartilhar o caso nas redes sociais em que faço parte.                 | Poder compartilhar com os conhecidos, amigos e colegas o caso alcançando mais pessoas.  |
|Amanda Alves        | Poder realizar uma pesquisa sobre notícias acerca de um tema específico.                  | Localizar tópicos específicos e conseguir maior objetividade em algumas leituras.  |
|Felipe Noronha      | Poder Inserir imagens e arquivos.                 | Para auxiliar nas buscas dos entes queridos e facilitar as buscas das pessoas desaparecidas. |
|Felipe Noronha      | Felipe deseja utilizar um sistema de pessoas desaparecidas para ajudar as famílias a encontrar seus entes queridos desaparecidos de forma mais eficiente e rápida.                   | Para que o sistema pode ser uma ferramenta valiosa para ajudar a salvar vidas, identificar pessoas desaparecidas e trazer paz de espírito às famílias afetadas.  |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues. 

|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ID                           Descrição                                                                                                      |  Prioridade         |
|---------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
|RF-01          |     O site deve ser simples e acessível                                                                                     |    Média            |
|---------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
|RF-02          |     O site deve conter todas as informações dodesaparecido e estar sempre atualizado dentro do possível                     |    Alta             |
|---------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
|RF-03          |     O site deve permitir ao usuário visualizar o texto completo da notícia com todos os detalhes da publicação              |    Média            |
|---------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
|RF-04          |     O site deve oferecer um menu adicional que permita ao usuário visualizar notícias de fontes distintas (sources).        |    Média            |
| --------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
|RF-05          |     O site deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar um texto específico que   |    Alta             |
|               |      será informado na caixa de pesquisa.7,5                                                                                |                     |
|---------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
|RF-06          |     O site deve permitir visualizar as informações de contatos do mantenedor do site                                        |    Média            |
|---------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
|RF-07          |     O site deve permitir o compartilhamento de notícias visualizadas em plataformas de redes sociais                        |    Baixa            |
|---------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
|RF-08          |     O site deve permitir salvar notícias preferidas                                                                         |    Baixa            |
| --------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
|RF-09          |     O site deve permitir verificar as notícias salvas como preferidas                                                       |    Baixa            |
|---------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
| RF-10         |      O site deve permitir que usuários possam comentar notícias                                                             |     Baixa           |
|---------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|
| RF-11         |      O site deve permitir que o usuário possa anexar imagens e arquivos                                                     |     Alta            |
----------------|-----------------------------------------------------------------------------------------------------------------------------|---------------------|

 


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku) | ALTA | 
|RNF-002| O site deverá ser responsivo permitindo a visualização em um celular de forma adequada |  ALTA | 
|RNF-003| O site deve ter bom nível de contraste entre os elementos da tela em conformidade |  MÉDIA |
|RNF-004| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) |  ALTA |

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
