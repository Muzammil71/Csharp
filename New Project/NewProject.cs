using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project
{
    public class NewProject : INewProject
    {
        //public void GreaterValue()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //    var result = numbers.Where(num => num > 3);
        //    foreach (var num in result)
        //        Console.WriteLine(num);
        //}


        //public void ConvertString()
        //{
        //    String[] numbersAsString = { "3", "1", "2", "4" };

        //    int[] numbersAsInt = numbersAsString.Select(s => int.Parse(s)).ToArray();
        //    var result = string.Join(" ", numbersAsInt);
        //    Console.WriteLine(result);
        //}

        public void FindFactorial()
        {
            {
                Console.Write("Enter a Number : ");
                int number = int.Parse(Console.ReadLine());
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial = factorial * i;
                }
                Console.Write($"Factorial of {number}  is: {factorial}");

                Console.ReadLine();
            }
        }
    }
}