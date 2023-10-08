import './style.css'

import { Robot } from "./robot";

let lista: Robot[] = [];

document.addEventListener('DOMContentLoaded', () => {
  document.getElementById('feldolgoz')!.addEventListener("click", feldolgoz);
  
  function feldolgoz() {
    let sorozat = (document.getElementById('sorozatszam') as HTMLInputElement)!.value;
    let feladat = (document.getElementById('feladatkor') as HTMLInputElement)!.value;
    let suly = parseInt((document.getElementById('suly') as HTMLInputElement)!.value);
    let tartalek = <HTMLInputElement> document.getElementById('tartalek'); 
    let tart: boolean;
    if (tartalek.checked) {
      tart = true;
    }
    else {
      tart = false;
    }
    //console.log(sorozat, feladat, suly, tart);

    let r = new Robot(sorozat, feladat, suly, tart);
    lista.push(r);

    lista.forEach(element => {
      console.log(element.toString());
    });
    (document.getElementById('sorozatszam') as HTMLInputElement)!.value = "";
    (document.getElementById('feladatkor') as HTMLInputElement)!.value = "";
    (document.getElementById('suly') as HTMLInputElement)!.value = "";
    tartalek.checked = false;
  }
})
