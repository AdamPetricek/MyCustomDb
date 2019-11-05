using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MyCustomDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MainDbContext();
            foreach (var r in db.City.Include(r => r.Houses).OrderBy(r => r.Name).ToList())
            {
                Console.WriteLine("-- " + r.Name + " --");
                foreach (var m in r.Houses.OrderBy(h => h.Height))
                {
                    Console.WriteLine(m.Height);
                }
            }
        }
    }
}
