using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3Calculator
{
    public class Calculator
    {
        public static double input1;
        public static double input2;
        public static double result;
        public static string resultString;
        public static string calcFormString;

        public static List<string> CalculationHistory = new List<string>();

        public static bool mainMenu = true;
        public static bool calcFormMenu = true;



        public static void MainMenu()
        {

            while (mainMenu)
            {

                Console.WriteLine("-----------------------   Calculator   -----------------------\n\n1. Calculate \n2. Calculate History\n3. Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        UserInputs();
                        CalculationForm();
                        break;
                    case "2":
                        PrintCalcHistory();
                        break;
                    case "3":
                        Exit();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
        public static void UserInputs()
        {
            Console.Clear();


            Console.WriteLine("Please enter a number");
            while (!double.TryParse(Console.ReadLine(), out input1))
            {
                Console.WriteLine("Error, enter a number instead");
            }

            Console.WriteLine("Please enter another number");
            while (!double.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("Error, enter a number instead");
            }
            Console.Clear();


        }
        public static void CalculationForm()
        {
            Calculator cal = new Calculator();

            while (calcFormMenu)
            {
                Console.WriteLine("Choose your from of calculation\n1. Addition (+)\n2. Subtraction (-)\n3. Division(/)\n4. Multiplication(*)");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        cal.Addition(input1, input2);
                        StoreCalculation("+");
                        PrintResult();
                        calcFormMenu = false;

                        break;
                    case "2":
                        Console.Clear();
                        cal.Subtraction(input1, input2);
                        StoreCalculation("-");
                        PrintResult();
                        calcFormMenu = false;
                        break;
                    case "3":
                        Console.Clear();
                        cal.Division(input1, input2);
                        StoreCalculation("/");
                        PrintResult();
                        calcFormMenu = false;
                        break;
                    case "4":
                        Console.Clear();
                        cal.Multiplication(input1, input2);
                        StoreCalculation("*");
                        PrintResult();
                        calcFormMenu = false;
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }
            calcFormMenu = true;
        }
        public static void StoreCalculation(string calcOperator)
        {
            calcFormString = calcOperator;
            resultString = $"{input1} {calcFormString} {input2} = {result}";
            CalculationHistory.Add(resultString);
        }
        public static void PrintResult()
        {
            Console.WriteLine($"Your calculation: {resultString} \n\nYour result was : {result}\n\nPress enter to go back to menu...");
            Console.ReadLine();
            Console.Clear();
        }


        public double Addition(double inputOne, double inputTwo)
        {
            input1 = inputOne;
            input2 = inputTwo;

            result = input1 + input2;
            return result;

        }
        public double Subtraction(double inputOne, double inputTwo)
        {
            input1 = inputOne;
            input2 = inputTwo;

            result = input1 - input2;
            return result;
        }
        public double Multiplication(double inputOne, double inputTwo)
        {
            input1 = inputOne;
            input2 = inputTwo;

            result = input1 * input2;
            return result;
        }
        public double Division(double inputOne, double inputTwo)
        {
            input1 = inputOne;
            input2 = inputTwo;

            result = input1 / input2;
            return result;
        }




        public static void PrintCalcHistory()
        {
            Console.Clear();
            if (CalculationHistory.Count > 0)
            {
                Console.WriteLine("Calculation History \n");
                foreach (string item in CalculationHistory)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nPress enter to go back to menu...");
            }
            else
            {
                Console.WriteLine("No results was found!\nPress enter to go back to menu...");
            }
            Console.ReadLine();
            Console.Clear();
        }
        public static void Exit()
        {
            mainMenu = false;
            Console.WriteLine("The application is shutting down...");
            Thread.Sleep(3000);
        }



    }
}
