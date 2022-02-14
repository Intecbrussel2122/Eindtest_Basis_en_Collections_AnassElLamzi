using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Eindtest_Basis_en_Collections_AnassElLamzi.Models
{
    public class SchrijfNaarBestand
    {
        //string path = ConfigurationManager.AppSettings["file"];
        static string path = Directory.GetCurrentDirectory() + "\\bestelling.txt";
        public static void WriteToFile(List<Product> products)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (var item in products)
                {
                    sw.WriteLine(item);
                }
            }
        }
    }
}
