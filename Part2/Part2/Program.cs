using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////PART 2 //////////////
            //////////////////////////////////1/////////////////////////////////////////////////////////////////
            //Console.Write("Input 1st number: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input 2nd number: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //if (number1 == number2)
            //{
            //    Console.WriteLine(number1 + " and " + number2 + " are equal");
            //}
            //else
            //{
            //    Console.WriteLine(number1 + " and " + number2 + " are not equal");
            //}
            //////////////////////////////////2////////////////////////////////////////////////////////////////
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine(number + " is an even integer");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is an odd integer");
            //}
            //////////////////////////////////3///////////////////////////////////////////////////////////////
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine(number + " is a positive number");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine(number + " is a negative number");
            //}
            //else
            //{
            //    Console.WriteLine("The number is zero");
            //}
            //////////////////////////////////4//////////////////////////////////////////////////////////////
            //Console.Write("Enter a year: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //{
            //    Console.WriteLine(year + " is a leap year.");
            //}
            //else
            //{
            //    Console.WriteLine(year + " is not a leap year.");
            //}
            //////////////////////////////////5/////////////////////////////////////////////////////////////
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("Congratulations! You are eligible for casting your vote.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are not eligible for casting your vote.");
            //}
            //////////////////////////////////6/////////////////////////////////////////////////////////////
            //Console.Write("Enter the value of Number : ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //int n;
            //if (m > 0)
            //{
            //    n = 1;
            //}
            //else if (m == 0)
            //{
            //    n = 0;
            //}
            //else
            //{
            //    n = -1;
            //}
            //Console.WriteLine("The value of n = " + n);
            //////////////////////////////////7/////////////////////////////////////////////////////////////
            //Console.Write("Enter the person's height in centimeters: ");
            //int height = Convert.ToInt32(Console.ReadLine());
            //if (height < 150)
            //{
            //    Console.WriteLine("The person is Dwarf.");
            //}
            //else if (height >= 150 && height < 175)
            //{
            //    Console.WriteLine("The person is Average height.");
            //}
            //else if (height >= 175 && height < 195)
            //{
            //    Console.WriteLine("The person is Tall.");
            //}
            //else
            //{
            //    Console.WriteLine("The person is Very Tall.");
            //}
            //////////////////////////////////8////////////////////////////////////////////////////////////
            //Console.Write("Input the 1st number: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input the 2nd number: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input the 3rd number: ");
            //int number3 = Convert.ToInt32(Console.ReadLine());
            //int largestNumber = Math.Max(Math.Max(number1, number2), number3);
            //Console.WriteLine("The largest number among the three is: " + largestNumber);
            //////////////////////////////////9//////////////////////////////////////////////////////////////
            //Console.Write("Input the value for X coordinate: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input the value for Y coordinate: ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the First quadrant.");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the Second quadrant.");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the Third quadrant.");
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the Fourth quadrant.");
            //}
            //else
            //{
            //    Console.WriteLine("The coordinate point (" + x + "," + y + ") lies at the origin.");
            //}
            //////////////////////////////////10/////////////////////////////////////////////////////////////
            //Console.Write("Input the marks obtained in Physics: ");
            //int physicsMarks = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input the marks obtained in Chemistry: ");
            //int chemistryMarks = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input the marks obtained in Mathematics: ");
            //int mathMarks = Convert.ToInt32(Console.ReadLine());
            //int totalMarks = physicsMarks + chemistryMarks + mathMarks;
            //if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && totalMarks >= 180)
            //{
            //    Console.WriteLine("The candidate is eligible for admission.");
            //}
            //else if (totalMarks >= 140)
            //{
            //    Console.WriteLine("The candidate is eligible for admission.");
            //}
            //else
            //{
            //    Console.WriteLine("The candidate is not eligible for admission.");
            //}
            //////////////////////////////////11/////////////////////////////////////////////////////////////
            //Console.Write("Input the value of a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Input the value of b: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Input the value of c: ");
            //double c = double.Parse(Console.ReadLine());
            //double discriminant = b * b - 4 * a * c;
            //if (discriminant > 0)
            //{
            //    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            //    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            //    Console.WriteLine("the root is : " + root1 + "," + root2);
            //}
            //else
            //{
            //    Console.WriteLine("Roots are imaginary; No Solution.");
            //}
            //////////////////////////////////12////////////////////////////////////////////////////////////
            //int rollNo;
            //string name;
            //int physicsMarks, chemistryMarks, computerMarks;
            //double totalMarks, percentage;
            //string division;
            //Console.Write("Input the Roll Number of the student: ");
            //rollNo = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input the Name of the Student: ");
            //name = Console.ReadLine();
            //Console.Write("Input the marks of Physics, Chemistry, and Computer Application: ");
            //string[] marks = Console.ReadLine().Split(' ');
            //physicsMarks = Convert.ToInt32(marks[0]);
            //chemistryMarks = Convert.ToInt32(marks[1]);
            //computerMarks = Convert.ToInt32(marks[2]);
            //totalMarks = physicsMarks + chemistryMarks + computerMarks;
            //percentage = (totalMarks / 300) * 100;
            //if (percentage >= 60)
            //{
            //    division = "First";
            //}
            //else if (percentage >= 50)
            //{
            //    division = "Second";
            //}
            //else if (percentage >= 40)
            //{
            //    division = "Third";
            //}
            //else
            //{
            //    division = "Fail";
            //}
            //Console.WriteLine("Roll No : " + rollNo);
            //Console.WriteLine("Name of Student : " + name);
            //Console.WriteLine("Marks in Physics : " + physicsMarks);
            //Console.WriteLine("Marks in Chemistry : " + chemistryMarks);
            //Console.WriteLine("Marks in Computer Application : " + computerMarks);
            //Console.WriteLine("Total Marks = " + totalMarks);
            //Console.WriteLine("Percentage = " + percentage.ToString("0.00"));
            //Console.WriteLine("Division = " + division);
            //////////////////////////////////13/////////////////////////////////////////////////////////
            //Console.Write("Enter the temperature in centigrade: ");
            //int temperature = int.Parse(Console.ReadLine());
            //string message = "";
            //if (temperature < 0)
            //{
            //    message = "Freezing weather";
            //}
            //else if (temperature >= 0 && temperature <= 10)
            //{
            //    message = "Very Cold weather";
            //}
            //else if (temperature > 10 && temperature <= 20)
            //{
            //    message = "Cold weather";
            //}
            //else if (temperature > 20 && temperature <= 30)
            //{
            //    message = "Normal in Temp";
            //}
            //else if (temperature > 30 && temperature <= 40)
            //{
            //    message = "Its Hot";
            //}
            //else if (temperature >= 40)
            //{
            //    message = "Its Very Hot";
            //}
            //Console.WriteLine(message);
            ///////////////////////////////////////////////////14/////////////////////////////////////////////
            //Console.WriteLine("Enter the lengths of the sides of the triangle: ");
            //int side1 = int.Parse(Console.ReadLine());
            //int side2 = int.Parse(Console.ReadLine());
            //int side3 = int.Parse(Console.ReadLine());
            //if (side1 == side2 && side2 == side3)
            //{
            //    Console.WriteLine("This is an equilateral triangle.");
            //}
            //else if (side1 == side2 || side2 == side3 || side1 == side3)
            //{
            //    Console.WriteLine("This is an isosceles triangle.");
            //}
            //else
            //{
            //    Console.WriteLine("This is a scalene triangle.");
            //}
            ///////////////////////////////////////////////////15//////////////////////////////////////////////////////
            //Console.WriteLine("Enter the three angles of the triangle: ");
            //int angle1 = int.Parse(Console.ReadLine());
            //int angle2 = int.Parse(Console.ReadLine());
            //int angle3 = int.Parse(Console.ReadLine());
            //if (angle1 + angle2 + angle3 == 180)
            //{
            //    Console.WriteLine("The triangle is valid.");
            //}
            //else
            //{
            //    Console.WriteLine("The triangle is not valid.");
            //}
            ///////////////////////////////////////////////////16/////////////////////////////////////////////////////
            //Console.Write("Enter an alphabet letter: ");
            //string input = Console.ReadLine();
            //char letter = input[0];
            //if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
            //    letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            //{
            //    Console.WriteLine("The alphabet is a vowel.");
            //}
            //else
            //{
            //    Console.WriteLine("The alphabet is a consonant.");
            //}
            ///////////////////////////////////////////////////17////////////////////////////////////////////////////
            //Console.Write("Enter the cost price: ");
            //double costPrice = double.Parse(Console.ReadLine());
            //Console.Write("Enter the selling price: ");
            //double sellingPrice = double.Parse(Console.ReadLine());
            //double profitOrLoss = sellingPrice - costPrice;
            //if (profitOrLoss > 0)
            //{
            //    Console.WriteLine("You can book your profit amount: " + profitOrLoss);
            //}
            //else if (profitOrLoss < 0)
            //{
            //    Console.WriteLine("You have incurred a loss amount: " + (-profitOrLoss));
            //}
            //else
            //{
            //    Console.WriteLine("No profit, no loss.");
            //}
            ///////////////////////////////////////////////////18///////////////////////////////////////////////////
            //Console.Write("Customer IDNO: ");
            //string customerId = Console.ReadLine();
            //Console.Write("Customer Name: ");
            //string customerName = Console.ReadLine();
            //Console.Write("Unit Consumed: ");
            //int unitConsumed = int.Parse(Console.ReadLine());
            //double chargesPerUnit;
            //if (unitConsumed <= 199)
            //{
            //    chargesPerUnit = 1.20;
            //}
            //else if (unitConsumed < 400)
            //{
            //    chargesPerUnit = 1.50;
            //}
            //else if (unitConsumed < 600)
            //{
            //    chargesPerUnit = 1.80;
            //}
            //else
            //{
            //    chargesPerUnit = 2.00;
            //}
            //double amountCharges = unitConsumed * chargesPerUnit;
            //double surchargeAmount = (amountCharges > 400) ? amountCharges * 0.15 : 0.0;
            //double netAmountPaid = Math.Max(amountCharges + surchargeAmount, 100);
            //Console.WriteLine("Customer IDNO: " + customerId);
            //Console.WriteLine("Customer Name: " + customerName);
            //Console.WriteLine("Unit Consumed: " + unitConsumed);
            //Console.WriteLine("Amount Charges @Rs. " + chargesPerUnit + " per unit: " + amountCharges.ToString("F2"));
            //Console.WriteLine("Surcharge Amount: " + surchargeAmount.ToString("F2"));
            //Console.WriteLine("Net Amount Paid By the Customer: " + netAmountPaid.ToString("F2"));
            ///////////////////////////////////////19//////////////////////////////////////////////////////////////////
            //Console.Write("Input the grade: ");
            //string input = Console.ReadLine();
            //char grade = Char.ToLower(input[0]);
            //string description;
            //switch (grade)
            //{
            //    case 'e':
            //        description = "Excellent";
            //        break;
            //    case 'v':
            //        description = "Very Good";
            //        break;
            //    case 'g':
            //        description = "Good";
            //        break;
            //    case 'a':
            //        description = "Average";
            //        break;
            //    case 'f':
            //        description = "Fail";
            //        break;
            //    default:
            //        description = "Invalid Grade";
            //        break;
            //}
            //Console.WriteLine("You have chosen: " + description);
            ///////////////////////////////////////20////////////////////////////////////////////////////////////////
            //Console.Write("Enter the day number: ");
            //int dayNumber = Convert.ToInt32(Console.ReadLine());

            //string dayName;

            //switch (dayNumber)
            //{
            //case 1:
            //    dayName = "Sunday";
            //    break;
            //case 2:
            //    dayName = "Monday";
            //    break;
            //case 3:
            //    dayName = "Tuesday";
            //    break;
            //    case 4:
            //        dayName = "Wednesday";
            //        break;
            //    case 5:
            //        dayName = "Thursday";
            //        break;
            //    case 6:
            //        dayName = "Friday";
            //        break;
            //    case 7:
            //        dayName = "Saturday";
            //        break;
            //    default:
            //        dayName = "Invalid day number";
            //        break;
            //}
            //Console.WriteLine("The day is: " + dayName);
            ///////////////////////////////////////21//////////////////////////////////////////////////////////////
            //Console.Write("Enter a digit: ");
            //int digit = Convert.ToInt32(Console.ReadLine());
            //string digitWord;
            //switch (digit)
            //{
            //    case 0:
            //        digitWord = "Zero";
            //        break;
            //    case 1:
            //        digitWord = "One";
            //        break;
            //    case 2:
            //        digitWord = "Two";
            //        break;
            //    case 3:
            //        digitWord = "Three";
            //        break;
            //    case 4:
            //        digitWord = "Four";
            //        break;
            //     case 5:
            //         digitWord = "Five";
            //         break;
            //     case 6:
            //         digitWord = "Six";
            //         break;
            //     case 7:
            //         digitWord = "Seven";
            //         break;
            //     case 8:
            //         digitWord = "Eight";
            //         break;
            //     case 9:
            //         digitWord = "Nine";
            //         break;
            //     default:
            //         digitWord = "Invalid digit";
            //         break;
            // }
            //Console.WriteLine("The digit in word is: " + digitWord);
            ///////////////////////////////////////22/////////////////////////////////////////////////////////////
            //Console.Write("Enter the month number: ");
            //int monthNumber = Convert.ToInt32(Console.ReadLine());
            //string monthName;
            //switch (monthNumber)
            //{
            //    case 1:
            //        monthName = "January";
            //        break;
            //    case 2:
            //        monthName = "February";
            //        break;
            //    case 3:
            //        monthName = "March";
            //        break;
            //    case 4:
            //        monthName = "April";
            //        break;
            //    case 5:
            //        monthName = "May";
            //        break;
            //    case 6:
            //        monthName = "June";
            //        break;
            //    case 7:
            //        monthName = "July";
            //        break;
            //    case 8:
            //        monthName = "August";
            //        break;
            //    case 9:
            //        monthName = "September";
            //        break;
            //    case 10:
            //        monthName = "October";
            //        break;
            //    case 11:
            //        monthName = "November";
            //        break;
            //    case 12:
            //        monthName = "December";
            //        break;
            //    default:
            //        monthName = "Invalid month";
            //        break;
            //}
            //Console.WriteLine("The month is: " + monthName);
            ///////////////////////////////////////23///////////////////////////////////////////////////////////
            //Console.Write("Enter the month number: ");
            //int monthNumber = Convert.ToInt32(Console.ReadLine());

            //int daysInMonth;

            //switch (monthNumber)
            //{
            //    case 1:
            //        daysInMonth = 31;
            //        break;
            //    case 2:
            //        daysInMonth = 28;
            //        break;
            //case 3:
            //    daysInMonth = 31;
            //    break;
            //case 4:
            //    daysInMonth = 30;
            //    break;
            //case 5:
            //    daysInMonth = 31;
            //    break;
            //case 6:
            //    daysInMonth = 30;
            //    break;
            //case 7:
            //    daysInMonth = 31;
            //    break;
            //case 8:
            //    daysInMonth = 31;
            //    break;
            //case 9:
            //    daysInMonth = 30;
            //    break;
            //case 10:
            //    daysInMonth = 31;
            //    break;
            //case 11:
            //    daysInMonth = 30;
            //        break;
            //    case 12:
            //        daysInMonth = 31;
            //        break;
            //    default:
            //        daysInMonth = -1; // Invalid month number
            //        break;
            //}

            //if (daysInMonth != -1)
            //{
            //    Console.WriteLine("Month has " + daysInMonth + " days.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid month number.");
            //}
            //    ///////////////////////////////////////24/////////////////////////////////////////////////////////
            //    Console.WriteLine("Choose a shape:");
            //    Console.WriteLine("1. Circle");
            //    Console.WriteLine("2. Rectangle");
            //    Console.WriteLine("3. Triangle");
            //    Console.Write("Enter your choice: ");
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            CalculateCircleArea();
            //            break;
            //        case 2:
            //            CalculateRectangleArea();
            //            break;
            //        case 3:
            //            CalculateTriangleArea();
            //            break;
            //        default:
            //            Console.WriteLine("Invalid choice.");
            //            break;
            //    }
            //}
            //static void CalculateCircleArea()
            //{
            //    Console.Write("Enter the radius of the circle: ");
            //    double radius = Convert.ToDouble(Console.ReadLine());
            //    double area = Math.PI * radius * radius;
            //    Console.WriteLine("The area is: " + area.ToString("F"));
            //}
            //static void CalculateRectangleArea()
            //{
            //    Console.Write("Enter the length of the rectangle: ");
            //    double length = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Enter the width of the rectangle: ");
            //    double width = Convert.ToDouble(Console.ReadLine());
            //    double area = length * width;
            //    Console.WriteLine("The area is: " + area.ToString("F"));
            //}
            //static void CalculateTriangleArea()
            //{
            //    Console.Write("Enter the base of the triangle: ");
            //    double bas = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Enter the height of the triangle: ");
            //    double height = Convert.ToDouble(Console.ReadLine());
            //    double area = 0.5 * bas * height;
            //    Console.WriteLine("The area is: " + area.ToString("F"));
            //}
        }


    }
}