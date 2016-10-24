using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;
using DbConnection;
using System.Collections.Generic;
using System.Linq;



namespace HelloNancy
{
    public class Query
    {   
        public static string query {get; set;}
        public static string allQuotes {get; set;}
       
        public static string selectAll()
        {   
            allQuotes = "";
            query = "SELECT * FROM quotes ORDER BY likes DESC";
            List<Dictionary<string, object>> quotes = DbConnector.ExecuteQuery(query);
            
            foreach (var quote in quotes)
            {
                allQuotes  += "<hr>Name: " + quote["name"] + 
                             "<br>Comment : " + quote["comment"] +
                             "<br>Date: " + quote["created_at"] +
                             "<br><br>Likes :" + quote["likes"] +
                             "<br><a class='btn btn-info' href=quotes/" + quote["id"] + ">Like</a>";
            }

            return allQuotes;

        }

        public static void insertQuote(string name, string comment)
        {
            System.Console.WriteLine(name);
            string Query = $"INSERT INTO quotes (name, comment, created_at) VALUES ('{name}', '{comment}', NOW())";
            DbConnector.ExecuteQuery(Query);

        }
        
    }
}