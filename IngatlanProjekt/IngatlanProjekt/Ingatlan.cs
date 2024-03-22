public class Ingatlan
{
    private string utca;
    private string varos;
    private int iranyitoSzam;
    private int szobaszam;
    private int terulet;
    private string tipus;
    private int ar;

    public Ingatlan(string sor)
    {
        string[] adatok = sor.Split(',');
        this.utca = adatok[0];
        this.varos = adatok[1];
        this.iranyitoSzam = int.Parse(adatok[2]);
        this.szobaszam = int.Parse(adatok[4]);
        this.terulet = int.Parse(adatok[6]);
        this.tipus = adatok[7];
        this.ar = int.Parse(adatok[9]);
    }

    public string Utca { get => utca; set => utca = value; }
    public string Varos { get => varos; set => varos = value; }
    public int IranyitoSzam { get => iranyitoSzam; set => iranyitoSzam = value; }
    public int Szobaszam { get => szobaszam; set => szobaszam = value; }
    public int Terulet { get => terulet; set => terulet = value; }
    public string Tipus { get => tipus; set => tipus = value; }
    public int Ar { get => ar; set => ar = value; }

    public override string ToString()
    {
        return $"{utca}, '{varos}, {iranyitoSzam}, {szobaszam}, {terulet}, '{tipus}, {ar}";
    }
}
