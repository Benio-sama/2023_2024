export class Allat {
    nev: string;
    eletkor: number;
  
    constructor(nev: string) {
      this.nev = nev;
      this.eletkor = 0;
    }
  
    szuletesnap(): void {
      this.eletkor++;
    }
}

export const ertek = 5;
export function segedfv() :string {
    return 'asdf';
}
