/* CARROSSEL */

const $ = selector => {
  return document.querySelector(selector);
};

function next() {
  var last = $(".hide"); 
  var first = $(".new-next");
  
  if (last.innerHTML.trim() != "") {
   first.innerHTML = last.innerHTML;
} else {
  //pass
}
  
   $(".hide").remove(); 

  /* Step */

  if ($(".prev3")) {
    $(".prev3").classList.add("hide");
    $(".prev3").classList.remove("prev3");
  }
  
  $(".prev2").classList.add("prev3");
  $(".prev2").classList.remove("prev2");
  
  $(".prev1").classList.add("prev2");
  $(".prev1").classList.remove("prev1");
  
  $(".prev").classList.add("prev1");
  $(".prev").classList.remove("prev");

  $(".act").classList.add("prev");
  $(".act").classList.remove("act");
  
  $(".next").classList.add("act");
  $(".next").classList.remove("next");
  
  $(".next1").classList.add("next");
  $(".next1").classList.remove("next1");
  
  $(".next2").classList.add("next1");
  $(".next2").classList.remove("next2");
  
  $(".next3").classList.add("next2");
  $(".next3").classList.remove("next3");

  /* New Next */
   $(".new-next").classList.add("next3");
  $(".new-next").classList.remove("new-next");

  const addedEl = document.createElement('li');

  $(".list").appendChild(addedEl);
  addedEl.classList.add("new-next");
}

function prev() {
  var last = $(".hide"); 
  var first = $(".new-next");
  
  if (first.innerHTML.trim() != "") {
   last.innerHTML = first.innerHTML;
} else {
  //pass
}
  
  $(".new-next").remove();
    
  /* Step */

  $(".next3").classList.add("new-next");
  $(".next3").classList.remove("next3");
  
  $(".next2").classList.add("next3");
  $(".next2").classList.remove("next2");
  
  $(".next1").classList.add("next2");
  $(".next1").classList.remove("next1");
  
  $(".next").classList.add("next1");
  $(".next").classList.remove("next");

  $(".act").classList.add("next");
  $(".act").classList.remove("act");

  $(".prev").classList.add("act");
  $(".prev").classList.remove("prev");

  $(".prev1").classList.add("prev");
  $(".prev1").classList.remove("prev1");
  
   $(".prev2").classList.add("prev1");
  $(".prev2").classList.remove("prev2");
   
  $(".prev3").classList.add("prev2");
  $(".prev3").classList.remove("prev3");
  
  $(".hide").classList.add("prev3");
  $(".hide").classList.remove("hide");

  /* New Prev */

  const addedEl = document.createElement('li');

  $(".list").insertBefore(addedEl, $(".list").firstChild);
  addedEl.classList.add("hide");
}

slide = element => {
  /* Next slide */
  
  if (element.classList.contains('next') || element.parentElement.classList.contains('next')) {
    next();
    
  /* Previous slide */
    
  } else if (element.classList.contains('prev') || element.parentElement.classList.contains('prev')) {
    prev();
  }
}

const slider = $(".list"),
      swipe = new Hammer($(".swipe"));

slider.onclick = event => {
  slide(event.target);
}

swipe.on("swipeleft", (ev) => {
  next();
});

swipe.on("swiperight", (ev) => {
  prev();
});
(() => {
  'use strict';
  if (document.querySelector('#sidebarToggler') != null) {
      document.querySelector('#sidebarToggler').addEventListener('click', () => {
          document.querySelector('#sidebar').classList.toggle('d-none')
      })
  }
})()
