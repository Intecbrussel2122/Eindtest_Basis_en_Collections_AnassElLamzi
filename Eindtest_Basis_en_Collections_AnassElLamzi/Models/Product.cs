using Eindtest_Basis_en_Collections_AnassElLamzi.Interfaces;
using System;
using System.Collections.Generic;

namespace Eindtest_Basis_en_Collections_AnassElLamzi.Models
{
    public abstract class Product : IComparer<Product>
    {
        public int ProductNummer { get; set; }
        public string Merk { get; set; }
        public string Naam { get; set; }
        public int Volume { get; set; }
        public double Prijs { get; set; }

        public Product(int productNummer, string merk, string naam, int volume, double prijs)
        {
            ProductNummer = productNummer;
            Merk = merk;
            Naam = naam;
            Volume = volume;
            Prijs = prijs;
        }
        public int Compare(Product other)
        {
            return Merk.CompareTo(other.Merk);
        }
        public string GetProductCode()
        {
            return Merk.PadRight(3).Substring(0, 3).ToUpper() + Naam.PadRight(3).Substring(0, 3).ToUpper() + Volume.ToString().Replace(' ', '_').ToUpper();
        }
        public override string ToString()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (Prijs.ToString().Contains(",00") && Prijs.ToString().Contains(","))
            {
                Console.WriteLine(".00");
            }
            return $"{ProductNummer} Merk: {Merk, -20} Naam: {Naam, -20} \tVolume: {Volume}ml \tPrijs: €{Prijs},- \tCode: {GetProductCode(), -10}";
        }

        public int Compare(Product x, Product y)
        {
            throw new NotImplementedException();
        }
    }
}
