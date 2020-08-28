using Herança_e_Polimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace Herança_e_Polimorfismo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of products:");
            int qtd = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, used or imported(c / u / i) ?");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case 'c':
                        list.Add(new Product(name, price));
                        break;

                    case 'u':
                        Console.Write("Manufacture Date:");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, manufactureDate));
                        break;

                    case 'i':
                        Console.Write("Customs Fee:");
                        double fee = double.Parse(Console.ReadLine());
                        list.Add(new ImportedProduct(name, price, fee));
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            foreach (Product item in list)
            {
                Console.WriteLine(item.Pricetag());
            }
        }
    }
}