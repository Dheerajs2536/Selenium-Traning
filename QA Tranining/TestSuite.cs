using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QA_Tranining
{
    public class Tests
    {
        static void Main(string[] args)
        {


            //string text = Tests.Reverse("Welcome to Csharp corner");

            int[] arr = {1,2,4,3,5,99,522};

            int max1 = int.MinValue;
            int max2 = int.MinValue;
            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i >= max2 && i != max1)
                {
                    max2 = i;
                }
            }
            Console.WriteLine(max2); ;
        
        Tests.countOfOccurrnet();
            Tests.isPalindrome("1221");

            //Console.WriteLine("The value of the reversed string is : " + text);

            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine();
            var arlist1 = new ArrayList(5);
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(3.5);
            arlist1.Add(null);

            List<string> primeNumbers = new List<string>();
            primeNumbers.Add("");
            IWebDriver driver = new ChromeDriver();
            List<IWebElement> selectCountry = new List<IWebElement>(driver.FindElements(By.XPath("")));




            DateTime now = DateTime.Now;

            // foreach loop begin
            // it will run till the
            // last element of the array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            string[] cars2 = new string[3] { "Volvo", "BMW", "Ford" };

            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements


        }

        public static string Reverse(string Input)
        {

            // Converting string to character array
            char[] charArray = Input.ToCharArray();

            // Declaring an empty string
            string reversedString = String.Empty;

            // Iterating the each character from right to left
            for (int i = charArray.Length - 1; i > -1; i--)
            {

                // Append each character to the reversedstring.
                reversedString += charArray[i];
            }

            // Return the reversed string.
            return reversedString;

        }

        public static void isPalindrome(string str)
        {
            bool flag = false;

            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)

            {

                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }

            if (flag)
            {
                Console.WriteLine("It is palindrome");
            }
            else
            {
                Console.WriteLine("It is not palindrome");
            }
        }

        public static void countOfOccurrnet()
        {
            string str = "Welcome";
            Console.WriteLine(str);

            while(str.Length >0)
            {
                int cal = 0;

                for(int j= 0; j<str.Length; j++)
                {
                    if(str[0] == str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine("The count of word is : " + cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            
        }

        public static void FindSecondLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i >= max2 && i != max1)
                {
                    max2 = i;
                }
            }
            Console.WriteLine(max2); ;
        }

    }
}

