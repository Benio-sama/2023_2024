export class Robot {
    private sorozatszam: string;
    private feladat: string;
    private suly: number;
    private tartalek: boolean;

    constructor(sorozatszam: string, feladat: string, suly: number, tartalek: boolean) {
        
        if (suly <=  0) {
            throw new Error('a sulya nem lehet 0 vagy annal kisebb');
        }
        if (sorozatszam.length != 10) {
            throw new Error('a sorozatszamnak pontosan 10 karakterbol kell allnia');
        }
        if (feladat.length === 0) {
            throw new Error('nem lehet ures a feladatkor');
        }

        this.sorozatszam = sorozatszam;
        this.feladat = feladat;
        this.suly = suly;
        this.tartalek = tartalek;
    }
    toString() : string {
        return `${this.sorozatszam}, ${this.feladat}, ${this.tartalek}, ${this.suly} kilo`;
    }
}