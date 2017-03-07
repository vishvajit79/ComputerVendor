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
    class Kher_Computer
    {

        // Declaring Constants For Laptop and Desktop Computer
        const double PRICE_OF_LAPTOP_COMPUTER = 1000;  
        const double PRICE_OF_DESKTOP_COMPUTER = 500;

        //Creating Variables
        private string vendorName;
        private string typeOfComputer;
        private int quantity;
        private double totalSales;

        //Creating Properties
        public string VendorName { get; set; }  
        public string TypeOFComputer { get; set; } 
        public int Quantity { get; set; }
        public double TotalSales { get; set; }


        //Default constructor
        public Kher_Computer()
        {

        }

        //Overloaded Constructor
        public Kher_Computer(string _VendorName, string _TypeOfComputer, int _Quantity)
        {
            VendorName = _VendorName;
            TypeOFComputer = _TypeOfComputer;
            Quantity = _Quantity;
        }

        
        //Method to calculate total sales using If statements
        public void CalculateTotalSales() 
        {
            if (TypeOFComputer == "L" || TypeOFComputer == "l")
            {
                 TotalSales = Quantity * PRICE_OF_LAPTOP_COMPUTER;   
            }
            if(TypeOFComputer == "D" || TypeOFComputer == "d")
            {
                 TotalSales = Quantity * PRICE_OF_DESKTOP_COMPUTER;
            }
        }


        public override string ToString()
        {
            string output = "";
            if (TypeOFComputer == "L" || TypeOFComputer == "l")
            {
                output = "\nVendor Name: " + VendorName + "\n" + "Type Of Computer: Laptop Computer \n" + "Price: $" + PRICE_OF_LAPTOP_COMPUTER + "\n" + "Quantity: " + Quantity + "\n" + "Total Sales: $" + TotalSales;

            }
            else
            {
                output = "\nVendor Name: " + VendorName + "\n" + "Type Of Computer: Desktop Computer \n" + "Price: $" + PRICE_OF_DESKTOP_COMPUTER  + "\n" +"Quantity: " + Quantity + "\n" + "Total Sales: $" + TotalSales;
            }
            return output;
        }

    }
}
