const burger = document.getElementById('burger');
const cross = document.getElementById('cross');
const mobileNav = document.getElementById('head') ; 
const menuMobile = document.getElementById('menuMobile') ; 


menuMobile.addEventListener('click',(e)=>{
   e.preventDefault();  
   mobileNav.classList.toggle('active') ;
});
