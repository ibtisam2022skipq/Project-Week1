Console.Write("\nPlease specify your application (Residential or Commercial) = ");
string status = Console.ReadLine();
Console.Write("\nEnter the consumed unit = ");
int units = Convert.ToInt32(Console.ReadLine());

if (status == "Residential")
{
    if (units <= 100)
    {
        Residential1 residential1 = new Residential1();
        residential1.consumedUnit = units;
        residential1.BillwithTax();
    }
    else if (units >100 || units < 200)
    {
        Residential2 residential2 = new Residential2();
        residential2.consumedUnit = units;
        residential2.BillwithTax();
    }
    else if (units >= 200 || units <= 500)
    {
        Residential3 residential3 = new Residential3();
        residential3.consumedUnit = units;
        residential3.BillwithTax();
    }
    else if (units > 500)
    {
        Residential4 residential4 = new Residential4();
        residential4.consumedUnit = units;
        residential4.BillwithTax();
    }
}
else if (status == "Commercial")
{
    if (units <= 100)
    {
        Commercial1 commercial1 = new Commercial1();
        commercial1.consumedUnit = units;
        commercial1.BillwithTax();
    }
    else if (units > 100 || units < 200)
    {
        Commercial2 commercial2 = new Commercial2();
        commercial2.consumedUnit = units;
        commercial2.BillwithTax();
    }
    else if (units >= 200 || units <= 500)
    {
        Commercial3 commercial3 = new Commercial3();
        commercial3.consumedUnit = units;
        commercial3.BillwithTax();
    }
    else if (units > 500)
    {
        Commercial4 commercial4 = new Commercial4();
        commercial4.consumedUnit = units;
        commercial4.BillwithTax();
    }

}
class ElectricityBill
{
    public int consumedUnit;
}
class Residential1 : ElectricityBill
{
    public  void BillwithTax()
    {
        double bill = consumedUnit * 5;
        double billwithTax = bill * 1.13;
        
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
class Residential2 : ElectricityBill
{
    public void BillwithTax()
    {
        double bill = 500 + ((consumedUnit - 100)*17);
        double billwithTax = bill * 1.13;
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
class Residential3 : ElectricityBill
{
    public void BillwithTax()
    {
        double bill = 500 + 1700 + ((consumedUnit - 200) * 23);
        double billwithTax = bill * 1.13;
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
class Residential4 : ElectricityBill
{
    public void BillwithTax()
    {
        double bill = 500 + 1700 + 6900 + ((consumedUnit - 500) * 69);
        double billwithTax = bill * 1.13;
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
class Commercial1 : ElectricityBill
{
    public void BillwithTax()
    {
        double bill = consumedUnit * 8;
        double billwithTax = bill * 1.17;

        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
class Commercial2 : ElectricityBill
{
    public void BillwithTax()
    {
        double bill = 800 + ((consumedUnit - 100) * 21);
        double billwithTax = bill * 1.17;
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
class Commercial3 : ElectricityBill
{
    public void BillwithTax()
    {
        double bill = 800 + 2100 + ((consumedUnit - 200) * 23);
        double billwithTax = bill * 1.17;
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}
class Commercial4 : ElectricityBill
{
    public void BillwithTax()
    {
        double bill = 800 + 2100 + 6900 + ((consumedUnit - 500) * 79);
        double billwithTax = bill * 1.17;
        Console.WriteLine("Electricity Bill with Tax = {0}", billwithTax);
    }
}