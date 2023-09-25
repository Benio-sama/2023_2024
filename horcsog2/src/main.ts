/*import { Allat } from './allat';
let a = new Allat('Pötyi');
a.szuletesnap();
console.log(a);
function duplazo(ertek : number) : number
{                                  //^amit visszaad
                      //^ ertek amit kap
  return ertek * 2
}
let valtozo = 45;
//valtozo = "asdf";
let masik : string;
let t : string[] = [];*/
import { Horcsog } from './horcsog';

async function betolt() {
  let valasz = await fetch('adatok.csv');
  if (valasz.ok) {
    let tartalom = valasz.text();
    let sorok = (await tartalom).trim().split('\n')
    for (let sor of sorok) {
      let ertekek = sor.split(';')
      let nev = ertekek[0];
      let szin = ertekek[1];
      let hossz = parseInt(ertekek[2]);

      let a = new Horcsog(nev, szin, hossz);
      lista.push(a);
      console.log(lista);
    }
  }
}




let lista: Horcsog[] = [];

document.addEventListener('DOMContentLoaded', () => {
  document.getElementById("feldolgoz")!.addEventListener("click", feldolgoz);
  function feldolgoz()
  {
    let nev = (document.getElementById("hnev") as HTMLInputElement)!.value;
    let szin = (document.getElementById("hszin") as HTMLInputElement)!.value;
    let hossz = parseInt((document.getElementById("hhossz") as HTMLInputElement)!.value);

    let a = new Horcsog(nev, szin, hossz);
    lista.push(a);
    console.log(a.toString());
    console.log(lista.length);
  }
  betolt();
})

