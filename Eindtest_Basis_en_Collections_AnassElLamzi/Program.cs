using Eindtest_Basis_en_Collections_AnassElLamzi.Models;
using System;
using System.Collections.Generic;

namespace Eindtest_Basis_en_Collections_AnassElLamzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Bestelling bestelling = new Bestelling();

            //List<Product> bestellingen = new List<Product>();
            Parfum p1 = new Parfum(1000, "BVLGARI", "BLV", 75, 61.52);
            AfterShave a1 = new AfterShave(1007, "Cacharel", "Anaïs", 50, 24.50, AfterShave.Soort.VAPO);
            Deodorant d1 = new Deodorant(1008, "DKNY", "Be Delicious Woman", 100, 33.65, Deodorant.DeoType.STICK);
            Parfum p2 = new Parfum(1001, "Dolce & Gabbana", "Light Blue", 100, 66.72);
            Parfum p3 = new Parfum(1002, "Giorgio Armani", "Code Donna", 50, 59.32);
            Parfum p4 = new Parfum(1003, "Giorgio Armani", "Code Donna", 30, 39.84);
            Parfum p5 = new Parfum(1004, "Giorgio Armani", "Code Donna", 75, 76.00);
            Parfum p6 = new Parfum(1005, "Givency", "Absolutely Irresistible", 75, 75.42);
            Parfum p7 = new Parfum(1006, "Ted Lapidus", "Pour Elle", 50, 44.48);
            AfterShave a2 = new AfterShave(1009, "Yves Saint Laurent", "Jazz", 50, 39.84, AfterShave.Soort.VAPO);
            Deodorant d2 = new Deodorant(1010, "Yves Saint Laurent", "Jazz", 100, 57.76, Deodorant.DeoType.VAPO);

            bestelling.VoegProductToe(p1);
            bestelling.VoegProductToe(a1);
            bestelling.VoegProductToe(d1);
            bestelling.VoegProductToe(p2);
            bestelling.VoegProductToe(p3);
            bestelling.VoegProductToe(p4);
            bestelling.VoegProductToe(p5);
            bestelling.VoegProductToe(p6);
            bestelling.VoegProductToe(p7);
            bestelling.VoegProductToe(a2);
            bestelling.VoegProductToe(d2);


            bestelling.ToonLijst(Bestelling.bestellingen);

            Console.WriteLine();

            Console.WriteLine("Van het merk Giorgo Armani:");
            bestelling.ToonPerMerk(Bestelling.bestellingen, "Giorgio Armani");

            Console.WriteLine();

            Console.WriteLine("Alle parfums:");
            bestelling.ToonParfums(Bestelling.bestellingen);

            Console.WriteLine();

            Console.WriteLine("Duurste product:");
            bestelling.ZoekDuursteProduct(Bestelling.bestellingen);

            Console.WriteLine();

            
            var total = bestelling.TotalePrijs();
            Console.WriteLine($"Totale prijs: €{total}");

            SchrijfNaarBestand.WriteToFile(Bestelling.bestellingen);
        }
    }
}
