const menuHamburguer = document.querySelector(".menu-hamburguer");
const menu = document.querySelector(".menu");

menuHamburguer.addEventListener("click", function() {
  menuHamburguer.classList.toggle("active");
  menu.classList.toggle("active");
});

function cadastrar(){
  window.location.href = 'http://127.0.0.1:5500/src/FORMUL%C3%81RIO%20DE%20CADASTRO/index.html';
}

function precaucoes(){
  window.location.href = 'http://127.0.0.1:5500/src/SOS%20-%20Precau%C3%A7%C3%B5es/index.html';
}