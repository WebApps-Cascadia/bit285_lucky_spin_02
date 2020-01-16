using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace LuckySpin
{
    public interface LuckySpin
    {
        string Output();
    }

    public class Lucky7
    {
        //TODO: Add an integer parameter to the Output method called "luck"
        public string Output( int luck )
        {
             

            //Get three random values
            Random random = new Random();
            int Luck = random.Next(1, 9);
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);
             



            //Use the ternary operator ?: to assign a value to the image variable
            //TODO: Use the parameter value "luck" instead of the fixed number 7
            string image = (a == luck || b == luck || c == luck)?
                    "<img src='http://faculty.cascadia.edu/brianb/images/LuckySevenExercise.jpg'/>" : "";
            //empty string if none of the values match

            //Create the output String using the static method Format
            string output = String.Format(
                    "<button onclick='history.go(0)'>Spin</button>" +
                    "<div>{a}</div><div>{b}</div><div>{c}</div>" +
                    "<h1> Lucky" + luck + "</h1>{3}", a, b, c, image);


            return output;
        }

   
        }
    }