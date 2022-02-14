using System;

namespace Eindtest_Basis_en_Collections_AnassElLamzi.Models
{
    public class Parfum : Product
    {
        public Parfum(int productNummer, string merk, string naam, int volume, double prijs) : base(productNummer, merk, naam, volume, prijs)
        {

        }
        public override string ToString()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            return $"{ProductNummer} Merk: {Merk,-20} Naam: {Naam,-20} \tVolume: {Volume}ml \tPrijs: €{Prijs},- \tCode: {GetProductCode(), -10}";
        }
    }
}
