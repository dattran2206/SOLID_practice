﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Project.OCP.Exercise2_Discount;
using SOLID_Project.OCP.Exercise1_Tax;
using SOLID_Project.OCP.Exercise3_SalaryCalculation;
using SOLID_Project.OCP.Exercise4_ShippingCosts;
using SOLID_Project.OCP.Exercise5_ExportReport;

namespace SOLID_Project
{
    public static class ProcessOCP
    {
        private static int _choice = 0;
        public static void Process()
        {
            Menu();
            do
            {
                switch (_choice)
                {
                    case 0:
                        MainProcess.Process();
                        break;
                    case 1:
                        OCP_Excute1Process.Process();
                        NextExercise();
                        break;
                    case 2:
                        OCP_Excute2Process.Process();
                        NextExercise();
                        break;
                    case 3:
                        OCP_Excute3Process.Process();
                        NextExercise();
                        break;
                    case 4:
                        OCP_Excute4_Process.Process();
                        NextExercise();
                        break;
                    case 5:
                        OCP_Excute5_Process.Process();
                        NextExercise();
                        break;
                    default:
                        MainProcess.Process();
                        break;
                }
            } while (_choice > 0);
        }
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("____________________Exercise OCP_____________________");
            Console.WriteLine("|1. Exercise 1: Tax_________________________________|");
            Console.WriteLine("|2. Exercise 2: Discount____________________________|");
            Console.WriteLine("|3. Exercise 3: Salary calculator___________________|");
            Console.WriteLine("|4. Exercise 4: Shipping costs______________________|");
            Console.WriteLine("|5. Exercise 5: Export report_______________________|");
            Console.WriteLine("|0. Back____________________________________________|");
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine();
            Console.Write("Type your choice: ");
            _choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        private static void NextExercise()
        {
            Console.Write("Do you want to continue with the next exercise in the OCP? (Y/N): ");
            string choiceStr = Console.ReadLine() + "";
            if (choiceStr.ToUpper() == "Y")
            {
                Menu();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
