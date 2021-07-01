using Composition_Exercise.Entities;
using System;

namespace Composition_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2021 14:45:00"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                12);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine("\n" + p2);
        }
    }
}
