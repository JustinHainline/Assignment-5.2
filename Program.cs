namespace Assignment_5._2
{
    internal class Program
    {
        static int NumbersRecursive(int number)
        {
            if ( number != 0)
            {
                return number % 10 + NumbersRecursive(number/10);
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            int result = NumbersRecursive(inputNumber);
            Console.WriteLine($"The sum of the digits of the number {inputNumber} is: {result}");
        }
    }
}
