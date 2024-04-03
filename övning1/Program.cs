using System;
using System.Collections.Generic;
namespace övning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bil1 = new Bil("volvo", "XC90", 2016, 170000, "ABC123");
            Console.WriteLine($"Märke: {bil1.märke}");
            Console.WriteLine($"Modell: {bil1.modell}");
            Console.WriteLine($"Årsmodell: {bil1.årsmodell}");
            Console.WriteLine($"Strecka körd: {bil1.streckakörd}");
            Console.WriteLine($"Nummerplåt: {bil1.plåtnummer}");
        }
    }
}