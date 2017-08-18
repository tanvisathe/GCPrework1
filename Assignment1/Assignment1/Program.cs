using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Declaring variables and lists
                var digitList1 = new List<int>();
                var digitList2 = new List<int>();
                var sum = new List<int>();
                int count = 0;
                string input;

                do
                {


                    //Taking two integer numbers as input from  user

                    Console.WriteLine("Please enter two integer numbers (Positive & Non-Zero) with the same number of digits (example: number1= 234, number2 = 564) ");
                    Console.WriteLine("Please enter number1:");
                    var number1 = Console.ReadLine();
                    Console.WriteLine("Please enter number2:");
                    var number2 = Console.ReadLine();

                    //Calculating the length of the integers
                    var len1 = number1.Length;
                    var len2 = number2.Length;

                    //Converting string inputs to int type

                    var num1 = int.Parse(number1);
                    var num2 = int.Parse(number2);
                    int value;



                    //Input Validation Checks

                    if (int.TryParse(number1, out value) && int.TryParse(number2, out value))
                    {
                        if (num1 == 0 || num2 == 0)
                        {
                            Console.WriteLine("Please enter numbers greater than zero...");

                        }


                        if (len1 != len2)
                        {
                            Console.WriteLine("Please enter numbers of same length and try again...");
                        }

                        else if (len1 == len2)
                        {
                            while (num1 > 0)
                            {
                                // % Gives the last digit in a number    
                                digitList1.Add(num1 % 10);
                                // Decrement the digits
                                num1 /= 10;
                            }
                            while (num2 > 0)
                            {
                                digitList2.Add(num2 % 10);
                                num2 /= 10;
                            }
                            digitList1.Reverse();
                            digitList2.Reverse();
                            // Storing the addition of two corresponding digits in a list called "sum"

                            for (int i = 0; i < len1; i++)
                            {
                                sum.Add(digitList1[i] + digitList2[i]);
                            }

                            Console.WriteLine("The sum of corresponding digits is:");

                            // Loop to display elements in list "sum"
                            foreach (var item in sum)
                            {
                                Console.WriteLine(item);
                            }

                            //Checking each element in the list "sum" against the other to find if they match

                            for (int j = 0; j < sum.Count - 1; j++)
                            {
                                for (int k = j + 1; k < sum.Count; k++)
                                {

                                    if (sum[j] != sum[k])
                                    {
                                        //Taking count of number of times the elements in list "sum" did not match; True if matched;False if it didn't  
                                        count = count + 1;
                                    }
                                    else
                                    {
                                        //do nothing);
                                    }
                                }
                            }
                            // checking if there was even one false value then the elements in list "sum" are not equal
                            if (count > 0)
                            {
                                Console.WriteLine(false);
                            }
                            else
                            {
                                Console.WriteLine(true);
                            }
                        }
                    }
                    else
                    {
                        //displays a message if both numbers are not entered correctly
                        Console.WriteLine("Please enter number in correct format");
                    }

                    Console.WriteLine("Do you want to continue?(Yes/No)");
                    input = Console.ReadLine();
                    sum.Clear();

                } while (input == "Yes" || input == "yes");

            }

            catch (Exception)
            {
                //Catches any other errors/exceptions and displays the below message
                Console.WriteLine("Oops.. something went wrong please try again");
            }
        }
    }
}
