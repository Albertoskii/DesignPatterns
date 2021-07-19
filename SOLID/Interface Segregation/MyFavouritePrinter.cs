class MyFavouritePrinter : IMachine
{
    public void Fax(string d)
    {
        System.Console.WriteLine("Fax completed");
    }

    public void Print(string d)
    {
        System.Console.WriteLine("Print completed");
    }

    public void Scan(string d)
    {
        System.Console.WriteLine("Scan completed");
        
    }
}