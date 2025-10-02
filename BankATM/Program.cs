using System.ComponentModel;
using System.Drawing;

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
            Console.ForegroundColor = ConsoleColor.White;           

            Console.WriteLine("\n\n------------Welcome To The Bank Of Elvis!------------\n\n");

            // time to prompt the user to insert card
            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("NOTE: this is just a simulation and not a real bank application so have fun!");
            Console.WriteLine("Add as much money as you want!");




            Console.WriteLine("\n\nPress Enter To Continue...\n");
            Console.ReadLine();


        }
    }
}
