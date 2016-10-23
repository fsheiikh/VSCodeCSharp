using System;
using ConsoleWithDb;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //var input = "Delete from players where players.id = 9";
            //DbConnector.ExecuteQuery(input);
            
            var stuff = DbConnector.ExecuteQuery("select Concat(players.first_name, ' ', players.last_name) as name, Concat(teams.city, teams.name) as team from players left join teams on teams.id = players.team_id where players.team_id = 2");
            foreach (var item in stuff)
            {
                System.Console.WriteLine(item["name"]);
            }
        }
    }
}
