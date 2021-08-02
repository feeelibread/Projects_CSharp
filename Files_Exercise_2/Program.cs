using System;
using System.IO;
using System.Globalization;
using Files_Exercise_2.Entities;

namespace Files_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);
                
                string sourceDirPath = Path.GetDirectoryName(sourceFilePath);
                string targetDirPath = sourceDirPath + @"\out";
                string targetFilePath = targetDirPath + @"\summary.csv";
                Directory.CreateDirectory(targetDirPath);

                using StreamWriter sw = File.AppendText(targetFilePath);
                foreach (var item in lines)
                {
                    string[] v = item.Split(';');
                    string name = v[0];
                    double price = double.Parse(v[1],CultureInfo.InvariantCulture);
                    int quantity = int.Parse(v[2]);
                    Product p = new Product(name, price, quantity);

                    sw.WriteLine(p.Name + ';' + p.Total().ToString("F2", CultureInfo.InvariantCulture));

                }


            }
            catch (IOException e)
            {

                Console.WriteLine("An error has ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
