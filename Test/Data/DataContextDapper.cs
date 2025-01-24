using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Test.Data
{
    public class DataContextDapper
    {
        // private IConfiguration _config; 
        private string ? _connectionString;       
        public IEnumerable<T> LoadData<T>(string sql){
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Query<T>(sql);
        }
        public T LoadDataSingle<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.QuerySingle<T>(sql);
        }
        public int ExecuteSql(string sql){
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Execute(sql);
        }
        public DataContextDapper(IConfiguration config){
            // _config = config;
            _connectionString = config.GetConnectionString("DefaultConnection");
        }
    }
}