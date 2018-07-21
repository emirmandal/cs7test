using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table");
            for (int row = 0; row <= 12; row++)
            {
                WriteLine(
                    $"{row} x {number} = {row * number}");
            }
        }
        static void RunTimesTable()
        {
            WriteLine("Enter a number between 0 and 255: ");
            if (byte.TryParse(ReadLine(), out byte number))
            {
                TimesTable(number);
            }
            else
            {
                WriteLine("You did not enter a valid number!");
            }
        }
        static void Main(string[] args)
        {
            RunTimesTable();
        }
    }
}
