using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class DataTypes
    {
        public void CheckDataType()
        {
            //interger-used to work with numbers. 
            //4 bytes
            //Range ==  -2,147,483,648 to 2,147,483,647
            int num = 30;
            Console.WriteLine("Interger Number = "+num);

            //Long-This is used when int is not large enough to store
            //8 bytes
            //Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long number1 = 30;
            Console.WriteLine("Long Number = " + number1);

            ///-------------Float,Double,Decimal------------
            //-if number with a decimal, such as 9.99 or 3.5.
            //store fractional numbers. 
            //Float-you should end the value with an "F"----float	4 byte
            //double-you should end the value with an "d"-----double	8 bytes
            //Decimal-you should end the value with an "m"------decimal 16 bytes 

            float myNum = 5.75F;
            Console.WriteLine("Float Number = " + myNum);

            double myNum1 = 5.75d;
            Console.WriteLine("double Number = " +myNum1);

            decimal myNum2 = 5.75m;
            Console.WriteLine("Decimal Number = " +myNum2);


            //string--- used to work with String values,store a sequence of characters (text).
            //surrounded by double quotes
            //2 bytes per character

            string message = "Hello";
            Console.WriteLine("String ="+ message);

            //Char-	2 bytes
            //Stores a single character/letter, surrounded by single quotes

            char message1 = 'H';
            Console.WriteLine("Char =" +message1);

        }

    }
}
