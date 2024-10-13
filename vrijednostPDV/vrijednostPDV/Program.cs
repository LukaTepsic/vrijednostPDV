using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite cijenu bez PDV-a: ");
        decimal cijenaBezPDV = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Unesite cijenu s PDV-om: ");
        decimal cijenaSPDV = Convert.ToDecimal(Console.ReadLine());

        decimal pdv = cijenaSPDV - cijenaBezPDV;
        decimal pdvPostotak = (pdv / cijenaBezPDV) * 100;

        Console.WriteLine($"Izračunati PDV: {pdv} kn");
        Console.WriteLine($"Postotak PDV-a: {pdvPostotak}%");
    }
}
