//Vishvajit Kher
//student id - 101015270
//comp 1202
//crn - 48628
//labtest 2
//31 March 2016



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1202W16LT2A_KHER_VISHVAJIT
{
    class Kher_ComputerApp
    {
        static void Main(string[] args)
        {
            string exit = "y"; //declaring a variable to stop the do while loop
            do
            {
                string vendorName, typeOfComputer, output = ""; //variable of computer
                int quantity;
                
                //changing text color for each data members
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

                Console.ForegroundColor = ConsoleColor.Red;
                vendorName = VendorName();         //taking input of vendor name of computer

                Console.ForegroundColor = ConsoleColor.Yellow;
                typeOfComputer = TypeOfComputer();       //taking input of type of computer

                Console.ForegroundColor = ConsoleColor.Green;
                quantity = QuantityOfComputers();   //taking input of quantity of computers

                Console.ForegroundColor = ConsoleColor.Magenta;
                Kher_Computer computer1 = new Kher_Computer(vendorName, typeOfComputer, quantity);  //creating new obejct computer

                computer1.CalculateTotalSales(); //calculating total sales
                output = computer1.ToString();
                Console.WriteLine(output);     //printing details about the computer from variable

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nDo You Wish To Continue Shooping?\nPress N to Exit Shooping: ");
                exit = Console.ReadLine();
            } while (exit != "N" && exit != "n");

            
        }

        //method to input vendor name
        public static string VendorName()  
        {
            Console.Write("Enter The Name Of The Computer Vendor: ");
            return Console.ReadLine();
        }

        //method to input computer type
        public static string TypeOfComputer()  
        {
            string type;
            do
            {
                Console.Write("Which Type Of Computer Do You Want -");
                Console.Write(" Press L for Laptop Computer & D for Desktop Computer: ");
                
                type = Console.ReadLine();
                if (type != "L" && type != "l" && type != "D" && type != "d")
                {
                    Console.WriteLine("\n\nPlease choose the  Valid Computer only !");
                }
            } while (type != "L" && type != "l" && type != "D" && type != "d");
            return type;
        }

        //method to input quantity of computers
        public static int QuantityOfComputers() 
        {
            int quantity;
            do
            {
                Console.Write("\nPlease Input Quantity Of Computer(s): ");
                string qty = Console.ReadLine();
                bool result = Int32.TryParse(qty, out quantity);
                if (result)
                {
                    if (quantity < 0)
                    {
                        quantity = 0;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter only positive integer values.");
                }
            } while (true);

            return quantity;
        }

    }
}
