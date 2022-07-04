using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBillCalculator
{
    public class ElectricityBill
    {
        public int units;
        private int billAmount;
        private double totalAmount;
        public virtual int PriceBelowHundred { get; }
        public virtual int PriceAboveHundred { get; }
        public virtual int PriceFiveHundred { get; }
        public virtual double Tax { get; }

        protected int CalculateAmount()
        {
            if (units <= 100)
            {
                billAmount = units * PriceBelowHundred;
            }
            else if (units > 100 && units <= 200)
            {
                billAmount = (100 * PriceBelowHundred) + ((units - 100) * PriceAboveHundred);
            }
            else if (units > 200 && units <= 500)
            {
                billAmount = (100 * PriceBelowHundred) + (100 * PriceAboveHundred) + ((units - 200) * 23);
            }
            else
            {
                billAmount = (100 * PriceBelowHundred) + (100 * PriceAboveHundred) + (300 * 23) + ((units - 500) * PriceFiveHundred);
            }
            return billAmount;
        }
        public int TotalBill()
        {
            totalAmount = CalculateAmount() + CalculateAmount() * Tax;
            return Convert.ToInt32(Math.Round(totalAmount));
        }
    }
    public class Residential : ElectricityBill
    {
        public override int PriceBelowHundred { get { return 5; } }
        public override int PriceAboveHundred { get { return 17; } }
        public override int PriceFiveHundred { get { return 69; } }
        public override double Tax { get { return 0.13; } }
        public Residential(int units)
        {
            this.units = units;
        }
    }

    public class Commercial : ElectricityBill
    {
        public override int PriceBelowHundred { get { return 8; } }
        public override int PriceAboveHundred { get { return 21; } }
        public override int PriceFiveHundred { get { return 79; } }
        public override double Tax { get { return 0.17; } }
        public Commercial(int units)
        {
            this.units = units;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter Your units:");
                int units = Convert.ToInt32(Console.ReadLine());
                Console.Write("Plesae Speify You are Commercial/Residential Consumer : ");
                String meter = Console.ReadLine();
                if (meter == "Commercial" || meter == "commercial")
                {
                    ElectricityBill first = new Commercial(units);
                    Console.WriteLine("\nYour Total Electricity bill is " + first.TotalBill());
                    Console.Write("Press c to continue the program or any other key to terminate:");
                }
                else if (meter == "Residential" || meter == "residential")
                {
                    ElectricityBill first = new Residential(units);
                    Console.WriteLine("\nYour Total  Electricity bill is " + first.TotalBill());
                    Console.Write("Press c to continue the program or any other key to terminate:");

                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Select Commercial/Residential");
                    Console.Write("Press c to continue the program :");
                }
            } while (Console.ReadLine() == "c");
        }
    }
}
