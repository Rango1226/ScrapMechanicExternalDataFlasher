using System;
using System.IO;

namespace ScrapMechanicExternalDataFlasher
{
    partial class main
    {
        static string GetFilePath()
        {
            string filePath = @"";

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter file path of the file you want to flash: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(@"e.g. C:\Users\User\Desktop\Input.txt");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                filePath = Console.ReadLine();

                if (!(File.Exists(filePath)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("coulnd find file!");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            while (!(File.Exists(filePath)));

            return filePath;
        }
    }
}
