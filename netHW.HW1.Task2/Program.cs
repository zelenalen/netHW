namespace netHW.HW1.Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Let's learn the multiplication table.");
            Console.WriteLine("Enter integer number please:");
            
            bool isCorrectValue = int.TryParse(Console.ReadLine(), out int UserInputValue);
            if (isCorrectValue)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{UserInputValue} * {i} = {Multiply(UserInputValue, i)}");
                }
            }
            else
            {
                Console.WriteLine("Invalid value entered");
            }

        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}