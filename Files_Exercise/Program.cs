using System;
using Files_Exercise.Entities;
using System.Globalization;
using System.IO;

namespace Files_Exercise
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

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using StreamWriter sw = File.AppendText(targetFilePath);
                foreach (var item in lines)
                {
                    string[] fields = item.Split(';');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    double quantity = int.Parse(fields[2]);

                    Product p = new Product(name, price, quantity);

                    sw.WriteLine(p.Name + ';' + p.Total().ToString("F2", CultureInfo.InvariantCulture));

                }

            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
