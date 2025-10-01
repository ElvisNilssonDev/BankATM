namespace BankATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setting up the console
            Console.Clear();
            // Setting the title of the console window
            Console.Title = "Bank Of Elvis ATM";
            // Setting the foreground color to blue because why not
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Welcome To The Bank Of Elvis!");
            Console.WriteLine("\n\nPress Enter To Continue...\n");
            Console.ReadLine();
        }
    }
}
