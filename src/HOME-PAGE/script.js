const menuHamburguer = document.querySelector(".menu-hamburguer");
const menu = document.querySelector(".menu");

menuHamburguer.addEventListener("click", function() {
  menuHamburguer.classList.toggle("active");
  menu.classList.toggle("active");
});

function cadastrar(){
  window.alert('Você precisa estar Logado!');
};

function precaucoes(){
  window.alert('Você precisa estar Logado!');
};

function verMais(){
  let verMais = document.querySelectorAll('.card-link');
  window.alert('Você precisa estar Logado!');
};