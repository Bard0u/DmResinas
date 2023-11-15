/* PAGINA SOBRE */

const boxes = document.querySelectorAll('.datesSobre, .infoSobre');
console.log("oi");
window.addEventListener('scroll', checkBoxes);
console.log('ae');
checkBoxes();

function checkBoxes() {
  const triggerBottom = window.innerHeight / 5 * 4;
  console.log('ae');
  boxes.forEach(box => {
    const boxTop = box.getBoundingClientRect().top;

    if (boxTop < triggerBottom) {
      box.classList.add('mostrar');
    } else {
      box.classList.remove('mostrar')
    }
  });
}