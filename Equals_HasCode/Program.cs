using Equals_HasCode.Entities;
using System;

namespace Equals_HasCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client { Name = "Robert", Email = "robert@gmail.com" };
            Client client2 = new Client { Name = "Maria", Email = "maria@gmail.com" };

            Console.WriteLine(client1.Equals(client2));

            Console.WriteLine(client2.GetHashCode());
            Console.WriteLine(client1.GetHashCode());
        }
    }
}