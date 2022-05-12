using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------Basics---------------");
            Console.ResetColor();
           


           
            while (true)
            {
                Console.WriteLine("Select\n1)Data Type\n2)Conditional Statement\n3)Loop\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        DataTypes dataTypes = new DataTypes();
                        dataTypes.CheckDataType();
                        break;
                    case 2:
                        ConditionalStatment statment = new ConditionalStatment();
                        statment.IfStatement();

                        statment.IfElseStatement();

                        statment.ElseIfStatement();

                        statment.NestedElseIfStatement();
                        break;
                    case 3:
                        Loops loops = new Loops();
                        loops.ForLoop();
                        Console.WriteLine(" ");
                        loops.WhileLoop();
                        Console.WriteLine(" ");
                        loops.Switch();
                        break;

                }
            }

        }
    }
}
