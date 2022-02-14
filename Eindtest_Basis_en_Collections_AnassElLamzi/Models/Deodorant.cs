using System;

namespace Eindtest_Basis_en_Collections_AnassElLamzi.Models
{
    public class Deodorant : Product
    {
        public enum DeoType
        {
            VAPO,
            STICK
        }
        DeoType soort = (DeoType)0;
        public Deodorant(int productNummer, string merk, string naam, int volume, double prijs, DeoType soort) : base(productNummer, merk, naam, volume, prijs)
        {

        }
        public override string ToString()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            return $"{ProductNummer} Merk: {Merk, -20} Naam: {Naam,-20} \tVolume: {Volume}ml \tPrijs: €{Prijs},- \tCode: {GetProductCode(), -10} {soort} ";
        }
    }
}
