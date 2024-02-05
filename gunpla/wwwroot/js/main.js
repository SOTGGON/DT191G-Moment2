"use strict";

// Elements
let openBtn = document.querySelector(".open");
let closeBtn = document.querySelector(".close");

// Eventlyssnare
openBtn.addEventListener('click', toggleMenu);
closeBtn.addEventListener('click', toggleMenu);

function toggleMenu(){
    let navMenuEl = document.querySelector("nav");
    let style = window.getComputedStyle(navMenuEl);

    if(style.display === "none"){
        navMenuEl.style.display = "block";
        openBtn.style.display = "none";
        closeBtn.style.display = "block";
    }else{
        navMenuEl.style.display = "none";
        closeBtn.style.display = "none";
        openBtn.style.display = "block";
    }
}