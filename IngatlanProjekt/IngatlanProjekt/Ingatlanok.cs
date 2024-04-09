using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Ingatlanok
{
    private List<Ingatlan> ingatlanLista;

    public Ingatlanok()
    {
        Beolvasas();
    }

    private void Beolvasas()
    {
        ingatlanLista = new List<Ingatlan>();
        try
        {
            using (StreamReader sr = new StreamReader("realestatetransactions.csv"))
            {
                sr.ReadLine(); // Első sor kihagyása (fejléc)
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    ingatlanLista.Add(new Ingatlan(sor));
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public int EladasokSzama()
    {
        return ingatlanLista.Count;
    }
    public Ingatlan Legnagyobb()
    {
        Ingatlan max = ingatlanLista[0];
        foreach (var item in ingatlanLista)
        {
            if (item.Terulet > max.Terulet)
            {
                max = item;
            }
        }
        return max;
    }
    public int Osszes()
    {
        int ossz = 0;
        foreach (var item in ingatlanLista)
        {
            ossz += item.Ar;
        }
        return ossz;
    }
}
