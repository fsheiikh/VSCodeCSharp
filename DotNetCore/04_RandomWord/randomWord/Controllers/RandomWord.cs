using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace randomWord.Controllers
{
    public class RandomWord
    {
        public static string name()
        {   
            Random random = new Random();
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVQXYZ";
            string word = "";

            for (int i = 0; i < random.Next(5,20); i++)
            {
                word += alpha[random.Next(i, 26)];
            }

                return word;
        }
    }
}
