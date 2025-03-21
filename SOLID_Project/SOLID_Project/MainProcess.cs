using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project
{
    public static class MainProcess
    {
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("____________________Practice SOLID_____________________");
            Console.WriteLine("| 1. SRP (Single Responsibility Principle)____________|");
            Console.WriteLine("| 2. OCP (Open/Closed Principle)______________________|");
            Console.WriteLine("| 3. LSP (Liskov Substitution Principle)______________|");
            Console.WriteLine("| 4. ISP (Interface Segregation Principle)____________|");
            Console.WriteLine("| 5. DIP (Dependency Inversion Principle)_____________|");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine();
        }
        public static void Process()
        {
            Menu();
            Console.Write("Type your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        ProcessOCP.Process();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            } while (choice > 9);                
        }
    }
}
