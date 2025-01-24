using System;
using Test.Models;

namespace Test
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer()
            {
                Motherboard="Z460",
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 1000.47m,
                VideoCard = "RTX 4050"
            };
            Console.WriteLine(myComputer.Motherboard);
            
        }
    }
}
