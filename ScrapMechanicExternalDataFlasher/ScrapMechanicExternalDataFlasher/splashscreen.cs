using System;

namespace ScrapMechanicExternalDataFlasher
{
    partial class main
    {
        static void splashscreen()
        {
            
            for(int index = 0; index < 9; index++)
            {
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                    Scrap Mechanic External Data Flasher program (V1)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("                    this program is capable of flashing ");
            Console.WriteLine("                    data from a .txt file into scrap mechanic");
            Console.WriteLine("                    logic creations");
            Console.WriteLine("");
            Console.WriteLine("                    press any key to continue");
            Console.ReadKey();
        }
    }
}
