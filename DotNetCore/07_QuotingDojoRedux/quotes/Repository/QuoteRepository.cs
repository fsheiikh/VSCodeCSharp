using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using DapperApp.Models;
using Microsoft.Extensions.Options;

namespace DapperApp.Repository {

    public class QuoteRepository : IRepository<Quote> {
        
        private readonly IOptions<MySqlOptions> mysqlConfig;
        public QuoteRepository(IOptions<MySqlOptions> conf) {
            mysqlConfig = conf;
        }
        internal IDbConnection Connection {
            get {
                return new MySqlConnection(mysqlConfig.Value.ConnectionString);
            }
        }

        public void Add(Quote item){
            using (IDbConnection dbConnection = Connection) {
                string query = "INSERT INTO quotes (quote, user_id, created_at, updated) VALUES (@quote, @user_id, NOW(), NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, item);
            }
        }
        public IEnumerable<Quote> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Quote>("select quotes.*, users.name from quotes left join users on users.id = quotes.user_id");
            }
        }
        public Quote FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Quote>("SELECT * FROM quotes WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

        public void DeleteByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query<Quote>("Delete from quotes WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

        // public User FindByEmail(string Email)
        // {
        //     using (IDbConnection dbConnection = Connection)
        //     {
        //         dbConnection.Open();
        //         return dbConnection.Query<User>("SELECT * FROM users WHERE email = @email", new { email = Email }).FirstOrDefault();
        //     }
        // }
    }
}