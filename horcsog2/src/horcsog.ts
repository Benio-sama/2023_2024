export class Horcsog {
    private nev: string;
    private szin: string;
    private hossz: number;

    constructor(nev: string, szin: string, hossz: number) {
        
        if (hossz <=  0) {
            throw new Error('a hossza nem lehet 0 vagy annal kisebb');
        }

        this.nev = nev;
        this.szin = szin;
        this.hossz = hossz;
    }
    toString() : string {
        return `${this.nev}, ${this.szin}, (${this.hossz} cm)`;
    }
}