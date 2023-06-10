using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////PART 4 /////////////////////////////////////////////////////////////////
            //--------------------1--------------------------------
            //Console.Write("Enter the number of natural numbers to display: ");
            //int count = int.Parse(Console.ReadLine());
            //Console.WriteLine("The first " + count + " natural numbers are:");
            //for (int i = 1; i <= count; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //--------------------2--------------------------------
            //Console.Write("Enter the number of terms: ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //Console.WriteLine("The first " + n + " natural numbers are:");
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i + " ");
            //    sum += i;
            //}
            //Console.WriteLine("\nThe sum is: " + sum);
            //--------------------3--------------------------------
            //Console.Write("Enter the value of n: ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //Console.WriteLine("The first " + n + " natural numbers are:");
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i + " ");
            //    sum += i;
            //}

            //Console.WriteLine("\nThe sum of natural numbers up to " + n + " terms is: " + sum);
            //--------------------4--------------------------------
            //int sum = 0;
            //int count = 10;
            //Console.WriteLine("Input the 10 numbers:");
            //for (int i = 1; i <= count; i++)
            //{
            //    Console.Write("Number-");
            //    Console.Write(i);
            //    Console.Write(": ");
            //    int number = int.Parse(Console.ReadLine());
            //    sum += number;
            //}
            //double average = (double)sum / count;
            //Console.Write("The sum of 10 numbers is: ");
            //Console.Write(sum);
            //Console.Write("\nThe average is: ");
            //Console.Write(average.ToString("F6"));
            //--------------------5--------------------------------
            //Console.Write("Input number of terms: ");
            //int numTerms = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= numTerms; i++)
            //{
            //    int cube = i * i * i;
            //    Console.WriteLine("Number is: " + i + " and cube of " + i + " is: " + cube);
            //}
            //--------------------6--------------------------------
            //Console.Write("Input the number (Table to be calculated): ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Multiplication table of " + number + ":");
            //for (int i = 1; i <= 10; i++)
            //{
            //    int result = number * i;
            //    Console.WriteLine(number + " X " + i + " = " + result);
            //}
            //--------------------7--------------------------------
            //Console.Write("Enter the number up to which you want the multiplication table: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Multiplication table from 1 to " + n + ":");
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write(j + "x" + i + " = " + (j * i) + ", ");
            //    }
            //    Console.WriteLine();
            //}
            //--------------------8---------------------------------
            //    Console.Write("Enter the number of terms: ");
            //    int terms = int.Parse(Console.ReadLine());
            //    int sum = 0;
            //    Console.Write("The odd numbers are: ");
            //    for (int i = 1; i <= terms; i++)
            //    {
            //        int oddNumber = 2 * i - 1;
            //        Console.Write(oddNumber + " ");
            //        sum += oddNumber;
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("The Sum of odd Natural Numbers up to " + terms + " terms: " + sum);
            //}
            //--------------------9---------------------------------
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //--------------------10---------------------------------
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //--------------------11---------------------------------
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}
            //--------------------12---------------------------------
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //int number = 1;
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(number + " ");
            //        number++;
            //    }
            //    Console.WriteLine();
            //}
            //--------------------13---------------------------------
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //int number = 1;
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(number + " ");
            //        number++;
            //    }

            //    Console.WriteLine();
            //}
            //--------------------14---------------------------------
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}
            //--------------------15---------------------------------
            //Console.Write("Input the number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine("The Factorial of " + number + " is: " + factorial);
            //--------------------16---------------------------------
            //Console.Write("Input number of terms: ");
            //int numTerms = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //Console.Write("The even numbers are: ");
            //for (int i = 1; i <= numTerms; i++)
            //{
            //    int evenNumber = 2 * i;
            //    sum += evenNumber;

            //    Console.Write(evenNumber + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("The Sum of even Natural Number upto " + numTerms + " terms: " + sum);
            //--------------------17---------------------------------
            //Console.WriteLine("Enter the number of rows for the pyramid:");
            //int rows = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int k = 1; k <= i; k++)
            //    {
            //       Console.Write(i + " ");
            //    }
            //   Console.WriteLine();
            //}
            //// q18-----------------------------------------------------------------------------------------------------------------------
            //Console.Write("Input the Value of x: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input the number of terms: ");
            //int numTerms = Convert.ToInt32(Console.ReadLine());
            //double sum = 1.0;
            //double power = 1.0;
            //double factorial = 1.0;
            //int sign = -1;
            //for (int i = 2; i <= 2 * numTerms; i += 2)
            //{
            //    power *= x * x;
            //    factorial *= i * (i - 1);
            //    sum += sign * (power / factorial);
            //    sign *= -1;
            //}
            //Console.WriteLine("The sum = " + sum.ToString("F6"));
            //Console.WriteLine("Number of terms = " + numTerms);
            //Console.WriteLine("Value of x = " + x.ToString("F6"));
            //// q19-----------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("Input the number of terms:");
            //int terms = int.Parse(Console.ReadLine());
            //double sum = 0.0;
            //Console.Write("Harmonic Series: ");
            //for (int i = 1; i <= terms; i++)
            //{
            //    Console.Write("1/" + i);
            //    if (i != terms)
            //    {
            //        Console.Write(" + ");
            //    }
            //    sum += 1.0 / i;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Sum of Series up to " + terms + " terms: " + sum);
            //// q20-----------------------------------------------------------------------------------------------------------------------
            //Console.Write("Input the number of terms: ");
            //int numbers = int.Parse(Console.ReadLine());
            //for (int i = 0; i < numbers; i++)
            //{
            //    for (int k = 0; k < 2 * i + 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    }
            // q21-----------------------------------------------------------------------------------------------------------------------
            //Console.Write("Input the number of terms: ");
            //int numbers = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int num = 9;
            //for (int i = 0; i < numbers; i++)
            //{
            //    sum += num;
            //    Console.Write(num + " ");
            //    num = num * 10 + 9;
            //}
            //Console.WriteLine("\nThe sum of the series = " + sum);
            // q22-----------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("Enter the number of rows for Floyd's Triangle:");
            //int rows = int.Parse(Console.ReadLine());

            //int num = 1;
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");
            //    }
            //    Console.WriteLine();
            // q23----------------------------------------------------------------------------------------------------------------
            //    Console.Write("Input the value of x: ");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Input the number of terms: ");
            //    int numTerms = Convert.ToInt32(Console.ReadLine());
            //    double sum = 1; // Initialize sum with the first term (1)
            //    double term = 1; // Initialize the first term (1)
            //    for (int i = 1; i < numTerms; i++)
            //    {
            //        term *= x / i; // Calculate the next term
            //        sum += term; // Add the next term to the sum
            //    }
            //    Console.WriteLine("The sum is: " + sum.ToString("F6"));
            //    Console.WriteLine("Number of terms = " + numTerms);
            //    Console.WriteLine("The value of x = " + x.ToString("F6"));
            //}
            // q24--------------------------------------------------------------------------------------------------------------------
            //    Console.Write("Input the value of x: ");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Input the number of terms: ");
            //    int terms = Convert.ToInt32(Console.ReadLine());
            //    int sum = 0;
            //    int power = 1;
            //    int sign = 1;
            //    for (int i = 0; i < terms; i++)
            //    {
            //        int term = sign * (int)Math.Pow(x, power);
            //        sum += term;
            //        sign *= -1;
            //        power += 2;
            //    }
            //    Console.WriteLine("The sum = " + sum);
            //    Console.WriteLine("Number of terms = " + terms);
            //    Console.WriteLine("The value of x = " + x);
            //}
            // q25-----------------------------------------------------------------------------------------------------------------------
            // Console.WriteLine("Enter of numbers :");
            // int numbers = int.Parse(Console.ReadLine());
            // int[] num = new int[numbers];
            // int sum = 0;

            // for (int x = 1; x < numbers + 1; x++)
            // {
            //     int square = x * x;
            //     Console.WriteLine("The square natural upto " + numbers + " terms are " + square);
            //     sum += square;
            // }
            // Console.WriteLine("The sum of the square numbers up to " + numbers + " terms = " + sum);

        }
    }
}