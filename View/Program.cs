using Data;
using Model;
using System;
using System.Linq;

namespace View
{
    class Program
    {
        public static Context context = new Context();
        static void Main(string[] args)
        {
            context.Database.EnsureCreated();
            Console.WriteLine("Enter School's name to add to database!");
            var school = new School();
            school.Name = Console.ReadLine();
            context.Schools.Add(school);
            context.SaveChanges();
            var schoolList = context.Schools.ToList();
            Console.WriteLine("Printing Schools");
            foreach (var item in schoolList)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
