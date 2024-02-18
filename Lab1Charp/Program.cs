// See https://aka.ms/new-console-template for more 
 static void task1()
{
    Console.WriteLine("Task1 !");
    Console.Write("s = ");
    double s;
    if(double.TryParse(Console.ReadLine(), out s))
    {
        Console.WriteLine("r = {0}", Math.Sqrt(s / Math.PI));
    }
    else
    {
        Console.WriteLine("invalid input:(");
    }

}
Console.WriteLine("Lab 1 !");
task1();
// continue ...
