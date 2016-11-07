using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using quotingdojo.Models;
namespace quotingdojo.Factory
{
    public class QuoteFactory : IFactory<Quote>
    {
        private string connectionString;
        public QuoteFactory()
        {
            connectionString = "server=localhost;userid=root;password=root;port=8889;database=quotingdojo;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(connectionString);
            }
        }

         public void Add(Quote item)
        {
            using (IDbConnection dbConnection = Connection) {
                string query =  "INSERT INTO quotes (name, comment, created_at) VALUES (@name, @comment, NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, item);
            }
        }
        public IEnumerable<Quote> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Quote>("SELECT * FROM quotes");
            }
        }
        public Quote FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Quote>("SELECT * FROM quote WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

        public void DeleteByID(int id)
        {   
           
            using (IDbConnection dbConnection = Connection)
            {
                string query = "DELETE FROM quotes WHERE id = " +  id;
                dbConnection.Open();
                dbConnection.Execute(query, id);
            }
        }
    }
}