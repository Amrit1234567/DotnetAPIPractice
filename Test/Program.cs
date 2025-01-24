using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Test.Data;
using Test.Models;

namespace Test
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContextDapper dapper = new DataContextDapper();
            string sqlCommand = "SELECT * FROM TutorialAppSchema.Computer";

            Computer result1 = dapper.LoadDataSingle<Computer>(sqlCommand);

            Console.WriteLine(result1.Motherboard);

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
