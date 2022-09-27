using WindowsInput.Native;
using WindowsInput;
using System;

namespace ScrapMechanicExternalDataFlasher
{
    partial class main
    {
        static bool TransferDataV1(ref bool[] data, ref string filePath)
        {
            int bitsPerSecond = 30;
            int phaseDelay = (int)(1 / (float)bitsPerSecond * 1000);

            Console.Clear();
            Console.WriteLine("file path: " + filePath);
            Console.WriteLine("file size: " + data.Length / 8 + " bytes");
            Console.WriteLine();
            Console.WriteLine("Press enter to flash");
            Console.ReadLine();

            for (int index = 5; index > 0; index--)
            {
                Console.Clear();
                Console.WriteLine("Flashing in " + index + " Seconds...");
                Console.WriteLine();
                Console.WriteLine("If you want to cancel, use alt + F4 lol");
                System.Threading.Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Flashing...");
            Console.WriteLine();
            Console.WriteLine("If you want to cancel, use alt + F4 lol");
            
            InputSimulator sim = new InputSimulator();

            sim.Keyboard.KeyDown(VirtualKeyCode.VK_3);
            System.Threading.Thread.Sleep(phaseDelay);
            sim.Keyboard.KeyUp(VirtualKeyCode.VK_3);
            System.Threading.Thread.Sleep(phaseDelay);

            for (int index = 0; index < data.Length; index++)
            {
                if (data[index] == true)
                {
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_2);
                    System.Threading.Thread.Sleep(phaseDelay);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_2);
                }
                else 
                {
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_1);
                    System.Threading.Thread.Sleep(phaseDelay);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_1);
                }
                System.Threading.Thread.Sleep(phaseDelay);
            }
            return true;
        }
    }
}
