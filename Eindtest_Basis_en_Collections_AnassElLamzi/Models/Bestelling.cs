using Eindtest_Basis_en_Collections_AnassElLamzi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eindtest_Basis_en_Collections_AnassElLamzi.Models
{
    public class Bestelling : IBerekenbaar
    {
        public static List<Product> bestellingen { get; set; } = new List<Product>();

        static int productNummer = 1000;
        public void VoegProductToe(Product product)
        {
           //product.ProductNummer = productNummer;
            bestellingen.Add(product);
            productNummer++;
        }
        public void ToonLijst(List<Product> bestellingen)
        {
            foreach (var item in bestellingen)
            {
                Console.WriteLine(item);
            }
        }
        public void ToonPerMerk(List<Product> bestellingen, string merk)
        {
            foreach (var item in bestellingen)
            {
                if (item.Merk == merk)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public Product ZoekDuursteProduct(List<Product> bestellingen)
        {
            double hoogstePrijs = bestellingen.Max(p => p.Prijs);
            var item = bestellingen.First(x => x.Prijs == hoogstePrijs);
            Console.WriteLine(item);
            return item;
        }
        public void ToonParfums(List<Product> bestellingen)
        {
            foreach (var item in bestellingen)
            {
                Parfum parfum = item as Parfum;

                if (parfum != null)
                {
                    Console.WriteLine(parfum);
                }
            }
        }
        public double TotalePrijs()
        {
            double totalePrijs = 0; 
            //double totalePrijs = bestellingen.Sum(p => p.Prijs);
            foreach (var item in bestellingen)
            {
                totalePrijs += item.Prijs;
            }
            return totalePrijs;
        }
        //public double TotalePrijs()
        //{
        //    //throw new NotImplementedException();
        //}
    }
}
