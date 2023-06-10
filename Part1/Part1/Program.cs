using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////PART 1////////////////////////////////////////   

            ////////////////////////////////////////1////////////////////////////////////////
            //int num1, num2;
            //Console.WriteLine("Enter the first number:");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number:");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //int sum = num1 + num2;
            //if (num1 == num2)
            //{
            //    sum *= 3;
            //}
            //Console.WriteLine("The result is: " + sum);
            ////////////////////////////////////////2//////////////////////////////////////// 
            //Console.Write("Enter  number ");
            //double number = Convert.ToDouble(Console.ReadLine());
            //if (number > 51)
            //{
            //    Console.WriteLine("your result is :" + (number - 51) * 3);
            //}
            //else
            //{ Console.WriteLine("your result is :" + (51 - number)); }   
            ////////////////////////////////////////3//////////////////////////////////////// 
            //int num1, num2;
            //Console.WriteLine("Enter the first number:");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number:");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //bool result = (num1 == 30 || num2 == 30 || num1 + num2 == 30);
            //Console.WriteLine("The result is: " + result);
            ////////////////////////////////////////4//////////////////////////////////////// 
            //int number;
            //Console.WriteLine("Enter a number:");
            //number = Convert.ToInt32(Console.ReadLine());
            //bool result = (number >= 90 && number <= 110) || (number >= 190 && number <= 210);
            //Console.WriteLine("The result is: " + result);
            ////////////////////////////////////////5//////////////////////////////////////// 
            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();
            //string result = input;
            //if (!input.Contains("if "))
            //{
            //    result = "if " + input;
            //}
            //Console.WriteLine("The result is: " + result);
            ////////////////////////////////////////6////////////////////////////////////////   
            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();
            //Console.WriteLine("Enter the position of the character to remove:");
            //int position = Convert.ToInt32(Console.ReadLine());
            //string result = input.Remove(position, 1);
            //Console.WriteLine("The result is: " + result);
            ////////////////////////////////////////7////////////////////////////////////////   
            //Console.Write("Enter string ");
            //string anything = Console.ReadLine();
            //if (anything.Length > 1)
            //    Console.WriteLine(anything.Substring(anything.Length - 1) + anything.Substring(1, anything.Length - 2) + anything.Substring(0, 1));
            //else Console.WriteLine(anything);
            ////////////////////////////////////////8////////////////////////////////////////   
            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();
            //string result = input.Length < 2 ? input : new string(input.Substring(0, 2).ToCharArray()).PadRight(8, ' ');
            //Console.WriteLine("The result is: " + result);
            //////////////////////////////////////////9///////////////////////////////////////   
            //  Console.WriteLine("Enter a string:");
            //  string input = Console.ReadLine();
            // string result = input.Length < 1 ? input : input[input.Length - 1] + input + input[input.Length - 1];
            //  Console.WriteLine("The result is: " + result);        
            //    ///////////////////////////10///////////////////////////////////////////////
            //    Console.WriteLine(IsMultipleOfThreeOrSeven(3));
            //    Console.WriteLine(IsMultipleOfThreeOrSeven(14));
            //    Console.WriteLine(IsMultipleOfThreeOrSeven(12));
            //    Console.WriteLine(IsMultipleOfThreeOrSeven(37));
            //}
            //static bool IsMultipleOfThreeOrSeven(int number)
            //{
            //    return number % 3 == 0 || number % 7 == 0;
            //}

            //    ///////////////////////////11///////////////////////////////////////////////
            //    Console.WriteLine(AddCharacters("Python"));
            //    Console.WriteLine(AddCharacters("JS"));
            //    Console.WriteLine(AddCharacters("Code"));
            //}
            //static string AddCharacters(string input)
            //{
            //    string firstThreeChars = input.Length >= 3 ? input.Substring(0, 3) : input;
            //    return firstThreeChars + input + firstThreeChars;
            //}
            //    ///////////////////////////12///////////////////////////////////////////////

            //    Console.WriteLine(StartsWithCSharp("C# Sharp"));
            //    Console.WriteLine(StartsWithCSharp("C#"));
            //    Console.WriteLine(StartsWithCSharp("C++"));
            //}
            //static bool StartsWithCSharp(string input)
            //{
            //    return input.StartsWith("C#");
            //}

            ////////////////////////////13///////////////////////////////////////////////          
            //    Console.WriteLine(CheckTemperatures(120, -1));
            //    Console.WriteLine(CheckTemperatures(-1, 120));
            //    Console.WriteLine(CheckTemperatures(2, 120));
            //}
            //static bool CheckTemperatures(int temp1, int temp2)
            //{
            //    bool isTemp1BelowZero = temp1 < 0;
            //    bool isTemp2Above100 = temp2 > 100;

            //    return isTemp1BelowZero && isTemp2Above100;
            ////////////////////////////14///////////////////////////////////////////////          
            //    Console.WriteLine(CheckInRange(100, 199));
            //    Console.WriteLine(CheckInRange(250, 300));
            //    Console.WriteLine(CheckInRange(105, 190));
            //}
            //static bool CheckInRange(int num1, int num2)
            //{
            //    bool isNum1InRange = num1 >= 100 && num1 <= 200;
            //    bool isNum2InRange = num2 >= 100 && num2 <= 200;

            //    return isNum1InRange || isNum2InRange;
            //}
            ////////////////////////////15///////////////////////////////////////////////          
            //    Console.Write("Enter first number ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter sec number ");
            //int secNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter third number ");
            //int thirdNumber = Convert.ToInt32(Console.ReadLine());
            //    if ((firstNumber >= 20 && firstNumber <= 50) || (secNumber >= 20 && secNumber <= 50) || (thirdNumber >= 20 && thirdNumber <= 50))
            //    {
            //        Console.WriteLine("True");
            //    }
            //    else { Console.WriteLine("False"); }
            ////////////////////////////16///////////////////////////////////////////////          
            //    Console.WriteLine(CheckInRange(20, 84));
            //    Console.WriteLine(CheckInRange(14, 50));
            //    Console.WriteLine(CheckInRange(11, 45));
            //    Console.WriteLine(CheckInRange(25, 40));
            //}
            //static bool CheckInRange(int num1, int num2)
            //{
            //    bool isNum1InRange = num1 >= 20 && num1 <= 50;
            //    bool isNum2InRange = num2 >= 20 && num2 <= 50;

            //    return isNum1InRange || isNum2InRange;
            //}
            ////////////////////////////17///////////////////////////////////////////////          
            //    Console.WriteLine(ProcessString("Python"));
            //    Console.WriteLine(ProcessString("ytade"));
            //    Console.WriteLine(ProcessString("jsues"));
            //}
            //static string ProcessString(string input)
            //{
            //    if (input.Length >= 2 && input.Substring(1, 2) == "yt")
            //    {
            //        return input.Remove(1, 2);
            //    }

            //    return input;
            //}
            ////////////////////////////18///////////////////////////////////////////////          
            //Console.Write("Enter first number ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter sec number ");
            //int secNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter third number ");
            //int thirdNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Math.Max( Math.Max(firstNumber,secNumber),thirdNumber));
            ////////////////////////////19///////////////////////////////////////////////          
            //Console.Write("Enter first number ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter sec number ");
            //int secNumber = Convert.ToInt32(Console.ReadLine());
            //if (firstNumber == secNumber)
            //{
            //    Console.WriteLine(0);
            //}
            //else if (Math.Abs(100 - firstNumber) < Math.Abs(100 - secNumber))
            //{
            //    Console.WriteLine(firstNumber);
            //}
            //else { Console.WriteLine(secNumber); }
            ////////////////////////////20///////////////////////////////////////////////          
            //Console.Write("Enter first number ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter sec number ");
            //int secNumber = Convert.ToInt32(Console.ReadLine());
            //if (((firstNumber >= 40 && firstNumber <= 50) && (secNumber >= 40 && secNumber <= 50)) || ((firstNumber >= 50 && firstNumber <= 60) && (secNumber >= 50 && secNumber <= 60)))
            //{
            //    Console.WriteLine("True");
            //}
            //else { Console.WriteLine("False"); }
            ////////////////////////////21///////////////////////////////////////////////          
            //Console.Write("Enter first number ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter sec number ");
            //int secNumber = Convert.ToInt32(Console.ReadLine());
            //if (((firstNumber >= 20 && firstNumber <= 30) && (secNumber >= 20 && secNumber <= 30)))
            //{
            //    Console.WriteLine(Math.Max(firstNumber, secNumber));
            //}
            //else { Console.WriteLine(0); }    
            ////////////////////////////22//////////////////////////////////////////////          
            //Console.Write("Enter string ");
            //string anything = Console.ReadLine();
            //string temp;
            //if (anything.Length >= 4)
            //{
            //    temp = anything.Substring(1, 3);
            //    if (temp.Contains("z"))
            //    {
            //        Console.WriteLine("true");
            //    }
            //    else { Console.WriteLine("false"); }
            //}
            //else { Console.WriteLine("please more than 3 char"); }
            ////////////////////////////23//////////////////////////////////////////////          
            //Console.Write("Enter first number: ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //if (Math.Abs(firstNumber % 10) == Math.Abs(secondNumber % 10))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            ////////////////////////////24//////////////////////////////////////////////          
            //Console.Write("Enter string ");
            //string anything = Console.ReadLine();
            //if (anything.Length <= 3) {
            //    Console.WriteLine(anything.ToUpper()); }
            //else { Console.WriteLine(anything.Remove(anything.Length - 3) + anything.Substring(anything.Length - 3).ToUpper()); }
            ////////////////////////////25//////////////////////////////////////////////          
            //Console.Write("Enter string ");
            //string anything = Console.ReadLine();
            //Console.Write("Enter number  ");
            //int number =Convert.ToInt32( Console.ReadLine());
            //for  (int i = 0; i < number; i++)
            //{
            //    Console.Write(anything);
            //}
            //Console.WriteLine("");

        }
    }
}
