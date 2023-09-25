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

let lista: Horcsog[] = [];

document.getElementById("feldolgoz")?.addEventListener("click", feldolgoz);
function feldolgoz()
{
  let nev = (document.getElementById("hnev") as HTMLInputElement)?.value;
  let szin = (document.getElementById("hszin") as HTMLInputElement)?.value;
  let magassag = parseInt((document.getElementById("hmag") as HTMLInputElement)?.value);

  let a = new Horcsog(nev, szin, magassag);
  lista.push(a);
  console.log('neve: ' + a.nev + ', szine: ' + a.szin + ', magassaga: ' + a.magassag);
  console.log(lista.length);
}