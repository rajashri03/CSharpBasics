using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class ConditionalStatment
    {
        /// <summary>
        /// if a boolean condition evaluates to true, then the code block will be executed, otherwise not.
        /// </summary>
        public void IfStatement()
        {
            Console.WriteLine("--------------If statement--------------");
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number >= 50)
            {
                Console.WriteLine("Number is greater than 80");
            }
            if (number <= 50)
            {
                Console.WriteLine("Number is Less than 80");
            }
        }

        /// <summary>
        /// else statement to specify a block of code to be executed if the condition is False.
        /// </summary>
        public void IfElseStatement()
        {
            Console.WriteLine("--------------If else statement--------------");
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 50)
            {
                Console.WriteLine("Number is greater than 80");
            }
            else
            {
                Console.WriteLine("Number is Less than 80");
            }
        }

        /// <summary>
        /// else if statement to specify a new condition if the first condition is False.
        /// </summary>
        public void ElseIfStatement()
        {
            Console.WriteLine("--------------else If statement--------------");
            Console.WriteLine("Enter Percentage");
            int percentage = Convert.ToInt32(Console.ReadLine());
            if (percentage >= 80)
            {
                Console.WriteLine("Grade--A");
            }
            else if (percentage >= 65)
            {
                Console.WriteLine("Grade--B");
            }
            else if (percentage >= 35)
            {
                Console.WriteLine("Grade--C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        /// <summary>
        /// if else statements inside another if else statements. This are called nested if else statements.
        /// </summary>
        public void NestedElseIfStatement()
        {
            Console.WriteLine("--------------else If statement--------------");
            Console.WriteLine("Enter Percentage");
            int percentage = Convert.ToInt32(Console.ReadLine());
            if (percentage >= 80)
            {
                if(percentage >= 90)
                {
                    Console.WriteLine("Grade--A1");
                }
                else
                {
                    Console.WriteLine("Grade--A");
                }

            }
            else if (percentage >= 65)
            {
                if (percentage >= 75)
                {
                    Console.WriteLine("Grade--B1");
                }
                else
                {
                    Console.WriteLine("Grade--B");
                }
            }
            else if (percentage >= 35)
            {
                Console.WriteLine("Grade--C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }

}
