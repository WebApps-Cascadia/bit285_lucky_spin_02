using System;

namespace LuckySpin
{
    public interface ILuckySpin
    {
        string Output();
    }

    public class Lucky7 
    {
        //TODO: Add an integer parameter to the Output method called "luck"
        public string Output() {
            //Get three random values
                Random random = new Random();
                int a = random.Next(1, 10);
                int b = random.Next(1, 10);
                int c = random.Next(1, 10);
                int luck = random.Next(1, 10);//changes the lucky number.
            //Use the ternary operator ?: to assign a value to the image variable
            //TODO: Use the parameter value "luck" instead of the fixed number 7
            string image = (a == luck || b == luck|| c == luck) ?
                    "<img src='http://faculty.cascadia.edu/brianb/images/LuckySevenExercise.jpg'/>" :
                    ""; //empty string if none of the values match

            //Create the output String using the static method Format
            string output = String.Format(
                    "<button onclick='history.go(0)'>Spin</button>" +
                    "<div>{0}</div><div>{1}</div><div>{2}</div>" +
                    "<h1> Lucky {3} </h1>{4}", a, b, c, luck, image);
            return output;
        }
    }
}
