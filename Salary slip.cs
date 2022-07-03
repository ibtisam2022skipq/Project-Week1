Console.WriteLine("\n----------------Salary Slip ---------------");
Console.Write("\n\nEnter Your Designation : ");
string designation = Console.ReadLine(); 

if (designation == "Engineer" || designation == "engineer")
{
    Engineer employee = new Engineer();
    employee.GrossSalary();

}
else if (designation == "Manager" || designation == "manager")
{
    Manager employee = new Manager();
    employee.GrossSalary();


}
else if (designation == "Analyst" || designation == "analyst")
{
    Analayst employee = new Analayst();
    employee.GrossSalary();
}


class Employee
{
    public int baseSalary;
    public int fuelAllowance;
    public int medAllowance;

    public int SalarySlip()
    {
        baseSalary = 1500;
        return baseSalary;
    }
}
class Engineer : Employee
{
    public void GrossSalary()
    {
        Engineer engineer = new Engineer();
        int basic = engineer.SalarySlip();
        fuelAllowance = 100;
        medAllowance = 500;
        int grossSalary = basic + fuelAllowance + medAllowance;
        Console.WriteLine("\nYour Gross Salary = $ {0}", grossSalary);

    }
}
class Manager : Employee
{
    public void GrossSalary()
    {
        Manager manager = new Manager();
        int basic = manager.SalarySlip();
        fuelAllowance = 250;
        medAllowance = 1000;
        int grossSalary = basic + fuelAllowance + medAllowance;
        Console.WriteLine("\nYour Gross Salary = $ {0}", grossSalary);
    }
}
class Analayst : Employee
{
    public void GrossSalary()
    {
        Analayst analayst = new Analayst();
        int basic = analayst.SalarySlip();
        fuelAllowance = 150;
        medAllowance = 800;
        int grossSalary = basic + fuelAllowance + medAllowance;
        Console.WriteLine("\nYour Gross Salary = $ {0}", grossSalary);
    }
}


-------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("Enter the consumed unit = ");
int units = Convert.ToInt32 (Console.ReadLine());
ElectricityBill electricityBill = new ElectricityBill();
electricityBill.consumedUnit = units;
//Residential1 residential1 = new Residential1 ();
Residential1.BillwithTax();

class ElectricityBill
{
    public int consumedUnit;
    public double CalculateBill(int chrg1, int chrg2, double tax)
    {
        double billAmount1 = (consumedUnit * chrg1) ;
        double billAmount2 = (consumedUnit) * chrg2;
        double billAmount3 = billAmount1 + billAmount2;
        double billAmount = billAmount1 * tax;
        return billAmount;
        //Console.WriteLine("Your Electricity Bill =  {0}", billAmount);

    }
}
class Residential1 : ElectricityBill
{
    public static void BillwithTax()
    {
        Residential1 res = new Residential1();
        double billwithTax = res.CalculateBill(5, 10, 1.13);
        //double billwithTax = (consumedUnit * 8) * 1.17;
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}

------------------------------------------------------------------------------------
Console.WriteLine("Enter the consumed unit = ");
int units = Convert.ToInt32(Console.ReadLine());

Residential1 residential1 = new Residential1 ();
residential1.consumedUnit=units;
residential1.BillwithTax();

class ElectricityBill
{
    public int consumedUnit;
    public double CalculateBill(int chrg1, int chrg2, double tax)
    {
        double billAmount1 = (consumedUnit * chrg1);
        double billAmount2 = (consumedUnit-100) * chrg2;
        double billAmount3 = billAmount1 + billAmount2;
        double billAmount = billAmount1 * tax;
        return billAmount;

    }
}
class Residential1 : ElectricityBill
{
    public  void BillwithTax()
    {
        double billwithTax = this.CalculateBill(5, 0, 1.13);
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
class Residential2 : ElectricityBill
{
    public void BillwithTax()
    {
        double billwithTax = this.CalculateBill(5, 0, 1.13);
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
class Residential3 : ElectricityBill
{
    public void BillwithTax()
    {
        double billwithTax = this.CalculateBill(5, 0, 1.13);
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
class Residential4 : ElectricityBill
{
    public void BillwithTax()
    {
        double billwithTax = this.CalculateBill(5, 0, 1.13);
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
---------------------------------------------------------------------------------------------
