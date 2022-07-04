namespace netHW.HW2.Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am calculator. Let's start.");

            bool isContinue = false;
            do
            {
                PrintMathMenu();
                var inputOperation = Console.ReadLine();
                bool isSelectedOperation = int.TryParse(inputOperation, out int selectedOperation);
                if (isSelectedOperation && selectedOperation >= 1 && selectedOperation <= 6)
                {
                    switch (selectedOperation)
                    {
                        case 1:
                            DoAdd();
                            break;
                        case 2:
                            DoSubtract();
                            break;
                        case 3:
                            DoMultiply();
                            break;
                        case 4:
                            DoDivide();
                            break;
                        case 5:
                            DoPow();
                            break;
                        case 6:
                            DoCalculateFactorial();
                            break;
                    }
                }
                else
                {
                    MessageIncorrectInput();
                }
                Console.WriteLine("Press Y to continue or any key to end");
                isContinue = Console.ReadLine().ToUpperInvariant() == "Y";
            } while (isContinue);
        }

        static double Add(double x, double y)
        {
            var result = x + y;
            if (double.IsInfinity(result))
            {
                MessageIsOverflow();
            };
            return result;
        }

        static double Subtract(double x, double y)
        {
            var result = x - y;
            if (double.IsInfinity(result))
            {
                MessageIsOverflow();
            };
            return result;
        }

        static double Multiply(double x, double y)
        {
            var result = x * y;
            //result = checked(x * y);
            if (double.IsInfinity(result))
            {
                MessageIsOverflow();
            };
            return result;
        }

        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Error. Dividing by 0.");
                return double.NaN;
            }
            else
            {
                var result = x / y;
                if (double.IsInfinity(result))
                {
                    MessageIsOverflow();
                };
                return result;
            }
        }

        static double Pow(double x, double y)
        {
            var result = Math.Pow(x, y);
            if (double.IsInfinity(result))
            {
                MessageIsOverflow();
            };
            return result;
        }

        static long CalculateFactorial(int x)
        {
            var result = 1l;
            try
            {
                checked
                {
                    for (int i = 1; i <= x; i++)
                    {
                        result *= i;
                    }
                }
            }
            catch (Exception e)
            {
                MessageIsOverflow();
            }
            return result;
        }
        static void PrintMathMenu()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - X + Y");
            Console.WriteLine("2 - X - Y");
            Console.WriteLine("3 - X * Y");
            Console.WriteLine("4 - X / Y");
            Console.WriteLine("5 - X ^ Y");
            Console.WriteLine("6 - X!");
        }
        static void DoAdd()
        {
            double x = EnterValue("X");
            double y = EnterValue("Y");
            if (!double.IsNaN(x) && !double.IsNaN(y))
            {
                Console.WriteLine($"{x} + {y} = {Add(x, y)}");
            }
            //else
            //{
            //    MessageIncorrectInput();
            //}
        }
        static void DoSubtract()
        {
            double x = EnterValue("X");
            double y = EnterValue("Y");
            if (!double.IsNaN(x) && !double.IsNaN(y))
            {
                Console.WriteLine($"{x} - {y} = {Subtract(x, y)}");
            }
            //else
            //{
            //    MessageIncorrectInput();
            //}
        }
        static void DoMultiply()
        {
            double x = EnterValue("X");
            double y = EnterValue("Y");
            if (!double.IsNaN(x) && !double.IsNaN(y))
            {
                Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
            }
            //else
            //{
            //    MessageIncorrectInput();
            //}
        }
        static void DoDivide()
        {
            double x = EnterValue("X");
            double y = EnterValue("Y");
            if (!double.IsNaN(x) && !double.IsNaN(y))
            {
                Console.WriteLine($"{x} / {y} = {Divide(x, y)}");
            }
        }
        static void DoPow()
        {
            double x = EnterValue("X");
            double y = EnterValue("Y");
            if (!double.IsNaN(x) && !double.IsNaN(y))
            {
                Console.WriteLine($"{x} * {y} = {Pow(x, y)}");
            }
        }
        static void DoCalculateFactorial()
        {
            int x = EnterIntegerValue("X");
            Console.WriteLine($"{x}! = {CalculateFactorial(x)}");
        }
        static double EnterValue(string ValueName)
        {
            Console.WriteLine($"Enter {ValueName}");
            bool IsInputCorrect = double.TryParse(Console.ReadLine(), out double value);
            if (IsInputCorrect)
            {
                return value;
            }
            else
            {
                MessageIncorrectInput();
                return double.NaN;
            }
        }
        static int EnterIntegerValue(string ValueName)
        {
            Console.WriteLine($"Enter integer {ValueName}");
            bool IsInputCorrect = int.TryParse(Console.ReadLine(), out int value);
            if (IsInputCorrect)
            {
                return value;
            }
            else
            {
                MessageIncorrectInput();
                return 0;
            }
        }
        static void MessageIncorrectInput()
        {
            Console.WriteLine("Incorrect input");
            //throw new InvalidOperationException("Incorrect input throw");
        }
        static void MessageIsOverflow()
        {
            Console.WriteLine("Is overflow");
        }
    }
}