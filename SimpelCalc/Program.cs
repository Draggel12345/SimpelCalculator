using System;
using static System.Console;
using static System.Convert;
using SimpelCalc.Entity;
using SimpelCalc.Service;

namespace SimpelCalc
{
    class Program
    {
        static readonly Numbers one = new();
        static readonly Numbers two = new();
        static readonly NumbersService service = new();

        static void Main(string[] args)
        {
            Play();

            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
        }

        static void Play()
        {
            char choice;
            char quit;
            bool run = true;

            while (run)
            {
                WriteLine("Welcome to the calculator!");
                Write("Please enter in a number: ");
                one.NumOne = ToDouble(ReadLine());
                Write("Choose what operator you want to use: ");
                choice = ToChar(ReadLine());
                Write("Please enter in a second number: ");
                two.NumTwo = ToDouble(ReadLine());

                WriteLine("");
                switch (choice)
                {
                    case '+':
                        {
                            WriteLine($"Answer: {one.NumOne} + {two.NumTwo} = {service.Add(one.NumOne, two.NumTwo)}\n");
                            break;
                        }
                    case '-':
                        {
                            WriteLine($"Answer: {one.NumOne} - {two.NumTwo} = {service.Sub(one.NumOne, two.NumTwo)}\n");
                            break;
                        }
                    case '*':
                        {
                            WriteLine($"Answer: {one.NumOne} * {two.NumTwo} = {service.Multi(one.NumOne, two.NumTwo)}\n");
                            break;
                        }
                    case '/':
                        {
                            WriteLine($"Answer: {one.NumOne} / {two.NumTwo} = {service.Divide(one.NumOne, two.NumTwo)}\n");
                            break;
                        }
                    default:
                        WriteLine("Wrong input!\n");
                        break;
                }
                WriteLine("Do you want to try again? Enter in Y/N");
                quit = ToChar(ReadLine().ToLower());
                if (quit.Equals('n'))
                {
                    run = false;
                }
            }
        }
    }
}
