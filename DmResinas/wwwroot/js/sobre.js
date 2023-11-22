/* PAGINA SOBRE */

const boxes = document.querySelectorAll('.datesSobre, .infoSobre');
window.addEventListener('scroll', checkBoxes);
checkBoxes();

function checkBoxes() {
  const triggerBottom = window.innerHeight / 5 * 4;
  boxes.forEach(box => {
    const boxTop = box.getBoundingClientRect().top;

    if (boxTop < triggerBottom - 50) {
      box.classList.add('mostrar');
    } else {
      box.classList.remove('mostrar')
    }
  });
}