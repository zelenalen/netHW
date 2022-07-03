namespace netHW.HW1.Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int UserInputValue = 0;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Which name of day whould you like to know?");
            Console.WriteLine("Enter number from 1 to 7 please:");

            bool isCorrectValue = int.TryParse(Console.ReadLine(), out int UserInputValue);
            if (isCorrectValue && UserInputValue>=1 && UserInputValue<=7)
            {
                Console.WriteLine($"The {UserInputValue} day of week is {GetValue(UserInputValue)}");
            }
            else
            {
                Console.WriteLine("Invalid value entered");
            }

        }

        static string GetValue(int UserInputValue) 
        {
            string Result = "";
            switch (UserInputValue)
            {
                case 1:
                    Result = "Monday";
                    break;
                case 2:
                    Result = "Tuesday";
                    break;
                case 3:
                    Result = "Wednesday";
                    break;
                case 4:
                    Result = "Thursday";
                    break;
                case 5:
                    Result = "Friday";
                    break;
                case 6:
                    Result = "Saturday";
                    break;
                case 7:
                    Result = "Sunday";
                    break;
            }
            return Result;
        }
    }
}