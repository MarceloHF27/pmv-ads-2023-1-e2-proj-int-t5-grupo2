const menuHamburguer = document.querySelector(".menu-hamburguer");
const menu = document.querySelector(".menu");

menuHamburguer.addEventListener("click", function() {
  menuHamburguer.classList.toggle("active");
  menu.classList.toggle("active");
});

function cadastrar(){
  window.location.href = 'http://localhost:80/FORMULARIODECADASTRO/index.html';
};

function precaucoes(){
  window.location.href = 'http://localhost:80/PRECAUCOES/index.html';
};