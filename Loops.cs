using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Loops
    {
        /// <summary>
        /// for loop to compute sum of first n natural numbers
        /// </summary>
        public void ForLoop()
        {
            Console.WriteLine("------------For loop-------------");
            //Syntax
            //for (initializer; condition; iterator)
            //{
            //    //code block 
            //}

            int number = 5, sum = 0;

            for (int i = 1; i <= number; i++)
            {
                // sum = sum + i;
                sum += i;
            }

            Console.WriteLine("Sum of first {0} natural numbers = {1}", number, sum);
        }
        public void WhileLoop()
        {
            Console.WriteLine("------------While loop-------------");
            int number = 5, sum = 0;
            int i = 1;
            while(i<=number)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Sum of first {0} natural numbers = {1}", number, sum);
        }
        /// <summary>
        /// switch statement to select one of many code blocks to be executed.
        /// </summary>
        public void Switch()
        {
            Console.WriteLine("----------switch----------");
            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
        }
    }

}
