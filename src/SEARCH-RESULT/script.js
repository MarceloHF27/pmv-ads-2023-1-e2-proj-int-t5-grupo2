
// As imagens ainda estão sempre com a foto da maria pois é necessário puxar do banco com o Back-end

function CreateCard(name,idade,datdes,ultavist){
    return `
    <div class="card">
        <div class="card-img">
            <img src="../IMG/maria.jpg" alt="Foto da pessoa desaparecida">
        </div>
        <div class="card-content">
            <h3 class="card-title">${name}</h3>
            <p class="card-text">${idade} anos</br>Desaparecida desde o dia ${datdes}. Vista por último na Av. ${ultavist}</p>
            <a href="#" class="card-link">Ver mais</a>
        </div>
    </div>
    `
}

function cadastrar(){
  window.location.href = 'http://127.0.0.1:5500/src/FORMUL%C3%81RIO%20DE%20CADASTRO/index.html';
}

function precaucoes(){
  window.location.href = 'http://127.0.0.1:5500/src/SOS%20-%20Precau%C3%A7%C3%B5es/index.html';
}

function voltar(){
  window.location.href = 'http://127.0.0.1:5500/src/HOME-PAGE/index.html';
}

let resultCard = document.querySelector('#app').innerHTML = `
<main>
    <section class="escolher">
      <div class="container">
      <button class="opcao" onclick="cadastrar()">CADASTRAR DESAPARECIDO</button>
      <button class="opcao" onclick="precaucoes()">PRECAUÇÕES</button>
        <div class="filtrando">
          <input type="text" name="nome" class="filtro" placeholder="nome">
          <input type="text" name="cidade" class="filtro" placeholder="cidade">
          <a href="#" class="buscar"><img src="../IMG/lupa.png" alt="Buscar"></a>
        </div>
      </div>
    </section>
    
    <section class="pessoas-desaparecidas">
      <div class="container">
        <h2 class="titulo-secao">Resultado de Busca</h2>
        <div class="cards">
            ${CreateCard ('maria', '23', '23/04/2023', 'Contagem')}
            ${CreateCard ('João', '43', '27/05/2023', 'São João')}
            ${CreateCard ('Mario', '63', '12/04/2023', 'São josé da Lapa')}
            ${CreateCard ('Alex', '13', '05/04/2023', 'Niteroi')}
          </div>
        </div>
      </div>
    </section>
  </main>
`