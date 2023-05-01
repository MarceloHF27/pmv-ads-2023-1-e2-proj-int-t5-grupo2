const menuHamburguer = document.querySelector(".menu-hamburguer");
const menu = document.querySelector(".menu");

menuHamburguer.addEventListener("click", function() {
  menuHamburguer.classList.toggle("active");
  menu.classList.toggle("active");
});