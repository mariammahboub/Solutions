using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////PART 3/////////////////////////////
            ///------------1----------------------
            ///   
            ////Console.WriteLine("Input the string:");
            //string input = Console.ReadLine();
            //Console.WriteLine("The string you entered is: " + input);
            //    / ---------------------------2----------------------------
            //        Console.WriteLine("Input the string:");
            //    string input = Console.ReadLine();
            //    int length = 0;
            //    foreach (char character in input)
            //    {
            //        length++;
            //    }
            //    Console.WriteLine("Length of the string is: " + length);
            //}
            ///---------------------------3----------------------------
            //Console.Write("Input the string: ");
            //string inputString = Console.ReadLine();
            //Console.WriteLine("The characters of the string are:");
            //foreach (char c in inputString)
            //{
            //    Console.Write(c + " ");
            //}
            //Console.WriteLine();
            ///---------------------------4----------------------------
            //Console.Write("Input the string: ");
            //string inputString = Console.ReadLine();
            //Console.WriteLine("The characters of the string in reverse are:");
            //for (int i = inputString.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(inputString[i] + " ");
            //}
            //Console.WriteLine();
            ///////////////////////////////5///////////////////////////////////////////
            //Console.Write("Input the string: ");
            //string inputString = Console.ReadLine();
            //Console.WriteLine("Total number of words in the string is: " + inputString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length);
            ///////////////////////////////6///////////////////////////////////////////
            //Console.Write("Input the 1st string: ");
            //string str1 = Console.ReadLine();
            //Console.Write("Input the 2nd string: ");
            //string str2 = Console.ReadLine();
            //if (str1.Length != str2.Length)
            //{
            //    Console.WriteLine("The length of both strings is not equal.");
            //}
            //else
            //{
            //    bool equal = true;
            //    for (int i = 0; i < str1.Length; i++)
            //    {
            //        if (str1[i] != str2[i])
            //        {
            //            equal = false;
            //            break;
            //        }
            //    }

            //    if (equal)
            //    {
            //        Console.WriteLine("The length of both strings are equal and both strings are equal.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The length of both strings are equal, but the strings are not equal.");
            //    }
            //}
            ///////////////////////////////7///////////////////////////////////////////
            //Console.Write("Input the 1st string: ");
            //string inputString = Console.ReadLine();
            //int alphabetCount = 0;
            //int digitCount = 0;
            //int specialCharCount = 0;
            //foreach (char c in inputString)
            //{
            //    if (char.IsLetter(c))
            //    {
            //        alphabetCount++;
            //    }
            //    else if (char.IsDigit(c))
            //    {
            //        digitCount++;
            //    }
            //    else
            //    {
            //        specialCharCount++;
            //    }
            //}
            //Console.WriteLine("Number of Alphabets in the string is: " + alphabetCount);
            //Console.WriteLine("Number of Digits in the string is: " + digitCount);
            //Console.WriteLine("Number of Special Characters in the string is: " + specialCharCount);
            ///////////////////////////////8///////////////////////////////////////////
            //Console.Write("Input the string: ");
            //string inputString = Console.ReadLine();
            //// Create a new string and copy the input string to it
            //string copiedString = string.Copy(inputString);
            //// Output the original and copied strings
            //Console.WriteLine("The First string is: " + inputString);
            //Console.WriteLine("The Second string is: " + copiedString);
            //// Output the number of characters copied
            //int numCharactersCopied = inputString.Length;
            //Console.WriteLine("Number of characters copied: " + numCharactersCopied);
            ///////////////////////////////9///////////////////////////////////////////
            // Console.WriteLine("Enter the string: ");
            //string input = Console.ReadLine();
            // int vowelCount = 0;
            // int consonantCount = 0;
            // foreach (char c in input)
            // {
            //     if (Char.IsLetter(c))
            //     {
            //         if ("aeiou".Contains(c))
            //             vowelCount++;
            //         else
            //             consonantCount++;
            //     }
            // }
            // Console.WriteLine("The total number of vowels in the string is: " + vowelCount);
            // Console.WriteLine("The total number of consonants in the string is: " + consonantCount);
            ///////////////////////////////10///////////////////////////////////////////
            //Console.Write("Input the string: ");
            //string input = Console.ReadLine();
            //int[] charCount = new int[128];
            //int maxCount = 0;
            //char maxChar = '\0';
            //foreach (char c in input)
            //{
            //    if (char.IsLetter(c))
            //    {
            //        charCount[c]++;
            //        if (charCount[c] > maxCount)
            //        {
            //            maxCount = charCount[c];
            //            maxChar = c;
            //        }
            //    }
            //}
            //Console.WriteLine("The Highest frequency of character '" + maxChar + "'");
            //Console.WriteLine("appears number of times: " + maxCount);
            //////////////////////////////11////////////////////////////////////////////
            //Console.Write("Input the string: ");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');
            //Array.Sort(words);
            //Console.Write("After sorting the string appears like: ");
            //foreach (string word in words)
            //{
            //    foreach (char c in word)
            //    {
            //        Console.Write(c + " ");
            //    }
            //}
            //Console.WriteLine(); 
            ////////////////////////////12////////////////////////////////////////////////
            //Console.Write("Input number of strings: ");
            //int numStrings = int.Parse(Console.ReadLine());
            //string[] strings = new string[numStrings];

            //Console.WriteLine("Input " + numStrings + " strings below:");
            //for (int i = 0; i < numStrings; i++)
            //    strings[i] = Console.ReadLine();
            //for (int i = 0; i < numStrings - 1; i++)
            //    for (int j = 0; j < numStrings - i - 1; j++)
            //        if (string.Compare(strings[j], strings[j + 1]) > 0)
            //        {
            //            string temp = strings[j];
            //            strings[j] = strings[j + 1];
            //            strings[j + 1] = temp;
            //        }
            //Console.WriteLine("After sorting, the array appears like:");
            //foreach (string str in strings)
            //    Console.WriteLine(str);
            //////////////////////////////////13////////////////////////
            //    Console.WriteLine("Input the string:");
            //    string inputString = Console.ReadLine();
            //    Console.WriteLine("Input the position to start extraction:");
            //    int startPosition = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Input the length of substring:");
            //    int length = int.Parse(Console.ReadLine());
            //    string substring = ExtractSubstring(inputString, startPosition, length);
            //    Console.WriteLine("The substring retrieved from the string is: " + substring);
            //}
            //static string ExtractSubstring(string inputString, int startPosition, int length)
            //{
            //    char[] chars = new char[length];

            //    for (int i = 0; i < length; i++)
            //    {
            //        chars[i] = inputString[startPosition + i];
            //    }

            //    return new string(chars);
            //}
            ///////////////////////////////////////14///////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Input the string:");
            //string inputString = Console.ReadLine();
            //Console.WriteLine("Input the substring to search:");
            //string substring = Console.ReadLine();
            //bool isSubstringPresent = inputString.Contains(substring);
            //Console.WriteLine(isSubstringPresent ? "The substring exists in the string." : "The substring does not exist in the string.");
            ///////////////////////////////////////15//////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Input the string:");
            //string inputString = Console.ReadLine();
            //string convertedString = "";
            //foreach (char c in inputString)
            //{
            //    if (char.IsLower(c))
            //    {
            //        convertedString += char.ToUpper(c);
            //    }
            //    else if (char.IsUpper(c))
            //    {
            //        convertedString += char.ToLower(c);
            //    }
            //    else
            //    {
            //        convertedString += c;
            //    }
            //}
            //Console.WriteLine("After conversion, the string is: " + convertedString);
            ///////////////////////////////////////16//////////////////////////////////////////////////////////////////////
            //string validUsername = "user";
            //string validPassword = "pass";
            //Console.WriteLine("Input a username:");
            //string username = Console.ReadLine();
            //Console.WriteLine("Input a password:");
            //string password = Console.ReadLine();
            //bool isPasswordCorrect = username == validUsername && password == validPassword;
            //Console.WriteLine(isPasswordCorrect ? "Password entered successfully!" : "Invalid username or password.");
            ///////////////////////////////////////17//////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Input a String:");
            //string inputString = Console.ReadLine();
            //Console.WriteLine("Input a substring to be found in the string:");
            //string substring = Console.ReadLine();
            //int position = inputString.IndexOf(substring);
            //if (position != -1)
            //{
            //    Console.WriteLine("Found '" + substring + "' in '" + inputString + "' at position " + position);
            //}
            //else
            //{
            //    Console.WriteLine("Substring '" + substring + "' not found in '" + inputString + "'");
            //}
            //////////////////////////////////////////18////////////////////////////////////////////
            //Console.WriteLine("Input a character:");
            //char ch = Console.ReadKey().KeyChar;
            //if (char.IsLetter(ch))
            //{
            //    if (char.IsUpper(ch))
            //    {
            //        Console.WriteLine("\nThe character is uppercase.");
            //    }
            //    else if (char.IsLower(ch))
            //    {
            //        Console.WriteLine("\nThe character is lowercase.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("\nThe character is not an alphabet.");
            //}
            //////////////////////////////////////////19////////////////////////////////////////////
            //Console.WriteLine("Input the original string:");
            //string originalString = Console.ReadLine();
            //Console.WriteLine("Input the string to be searched for:");
            //string searchString = Console.ReadLine();
            //int count = 0;
            //int index = 0;
            //while ((index = originalString.IndexOf(searchString, index)) != -1)
            //{
            //    count++;
            //    index += searchString.Length;
            //}
            //Console.WriteLine("The string '" + searchString + "' occurs " + count + " times");
            //////////////////////////////////////////20////////////////////////////////////////////
            //Console.WriteLine("Input the original string: ");
            //string originalString = Console.ReadLine();
            //Console.WriteLine("Input the string to be searched for: ");
            //string searchString = Console.ReadLine();
            //Console.WriteLine("Input the string to be inserted: ");
            //string insertedString = Console.ReadLine();
            //string modifiedString = originalString.Replace(searchString, insertedString+" " + searchString);
            //Console.WriteLine("The modified string is: " + modifiedString);
            //////////////////////////////////////////////21/////////////////////////////////////////////////
            //Console.WriteLine("Enter the first string:");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Enter the second string:");
            //string str2 = Console.ReadLine();
            //Console.WriteLine("Enter the first substring:");
            //string sub1 = Console.ReadLine();
            //Console.WriteLine("Enter the second substring:");
            //string sub2 = Console.ReadLine();
            //int result = String.Compare(sub1, sub2);
            //if (result < 0)
            //{
            //    Console.WriteLine("Substring '" + sub1 + "' in '" + str1 + "' is less than substring '" + sub2 + "' in '" + str2 + "'.");
            //}
            //else if (result > 0)
            //{
            //    Console.WriteLine("Substring '" + sub1 + "' in '" + str1 + "' is greater than substring '" + sub2 + "' in '" + str2 + "'.");
            //}
            //else
            //{
            //    Console.WriteLine("Substring '" + sub1 + "' in '" + str1 + "' is equal to substring '" + sub2 + "' in '" + str2 + "'.");
            //}
            ////////////////////////////////////////////////////22//////////////////////////////////////////////////////////////////////////
            //string str1 = "Hello World";
            //string str2 = "hello world";
            //bool isSameIgnoreCase = string.Compare(str1, 0, str2, 0, 5, StringComparison.OrdinalIgnoreCase) == 0;
            //bool isSameCaseSensitive = string.Compare(str1, 0, str2, 0, 5, StringComparison.Ordinal) == 0;
            //Console.WriteLine("Comparison ignoring case: {0}", isSameIgnoreCase ? "Substrings are the same" : "Substrings are different");
            //Console.WriteLine("Comparison considering case: {0}", isSameCaseSensitive ? "Substrings are the same" : "Substrings are different");
            ////////////////////////////////////////////////////23/////////////////////////////////////////////////////////////////////////
            //    string str1 = "café";
            //    string str2 = "cafe";
            //    CultureInfo culture = new CultureInfo("en-US", false);
            //    bool isSameIgnoreCase = string.Compare(str1, 0, str2, 0, 4, culture, CompareOptions.IgnoreCase) == 0;
            //    Console.WriteLine("Comparison ignoring case using culture: {0}", isSameIgnoreCase ? "Substrings are the same" : "Substrings are different");
            ////////////////////////////////////////////////////24////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Enter the first person's last name:");
            //string lastName1 = Console.ReadLine();
            //Console.WriteLine("Enter the second person's last name:");
            //string lastName2 = Console.ReadLine();
            //int comparison = string.Compare(lastName1, lastName2, StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine("Sorted alphabetically by last name:");
            //if (comparison <= 0)
            //{
            //    Console.WriteLine("First person: " + lastName1);
            //    Console.WriteLine("Second person: " + lastName2);
            //}
            //else
            //{
            //    Console.WriteLine("First person: " + lastName2);
            //    Console.WriteLine("Second person: " + lastName1);
            //}
            //////////////////////////////////////////////////25///////////////////////////////
            //string[] words = { "encyclopedia", "Encyclopedia", "ENCYCLOPEDIA" };
            //bool currentCultureCaseSensitive = string.Equals(words[0], words[1], StringComparison.CurrentCulture);
            //bool currentCultureIgnoreCase = string.Equals(words[0], words[1], StringComparison.CurrentCultureIgnoreCase);
            //bool invariantCultureCaseSensitive = string.Equals(words[0], words[1], StringComparison.InvariantCulture);
            //bool invariantCultureIgnoreCase = string.Equals(words[0], words[1], StringComparison.InvariantCultureIgnoreCase);
            //bool ordinalCaseSensitive = string.Equals(words[0], words[1], StringComparison.Ordinal);
            //bool ordinalIgnoreCase = string.Equals(words[0], words[1], StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine("case = Case (CurrentCulture): " + currentCultureCaseSensitive);
            //Console.WriteLine("case = Case (CurrentCultureIgnoreCase): " + currentCultureIgnoreCase);
            //Console.WriteLine("case = Case (InvariantCulture): " + invariantCultureCaseSensitive);
            //Console.WriteLine("case = Case (InvariantCultureIgnoreCase): " + invariantCultureIgnoreCase);
            //Console.WriteLine("case = Case (Ordinal): " + ordinalCaseSensitive);
            //Console.WriteLine("case = Case (OrdinalIgnoreCase): " + ordinalIgnoreCase);
        }
    }


}