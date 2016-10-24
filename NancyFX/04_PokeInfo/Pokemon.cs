using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;



namespace HelloNancy
{
    public class Pokemon
    {   
       public static int ID {get; set;}
       public static string URL {get; set;}

       public static string getUrl()
       {    
           if(ID == 0)
                URL  = "http://pokeapi.co/api/v2/pokemon/1";
            else 
               URL  = "http://pokeapi.co/api/v2/pokemon/" + ID.ToString();
            return URL ;

       }

       public static void setID(string id)
       {    
           ID = Int32.Parse(id);
       }

       public static string getImage()
       {    
           if(ID == 0 ) return "<img class='poke' src='http://pokeapi.co/media/img/"+ 1 +".png'>";
           else return "<img class='poke' src='http://pokeapi.co/media/img/"+ ID +".png'>";

       }

        
    }
}