using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Test.Data;
using Test.Models;

namespace Test
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            
            DataContextDapper dapper = new DataContextDapper(config);
            string sqlCommand = "SELECT * FROM TutorialAppSchema.Computer WHERE Motherboard = 'Z360'";

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
