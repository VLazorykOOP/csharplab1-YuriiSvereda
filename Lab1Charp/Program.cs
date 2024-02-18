// See https://aka.ms/new-console-template for more 

//1.14. радіус кола, площа круга якої дорівнює s
static void Task1()
{
    Console.WriteLine("Task1 !");
    Console.Write("s = ");
    double s;
    if (double.TryParse(Console.ReadLine(), out s))
    {
        Console.WriteLine("r = {0}", Math.Sqrt(s / Math.PI));
    }
    else
    {
        Console.WriteLine("invalid input:(");
    }

}

//2.14. яка з цифр тризначного числа більше: перша чи друга;
static void Task2()
{
    Console.WriteLine("Task2!");
    Console.WriteLine("Enter c number");
    short num;
    if (short.TryParse(Console.ReadLine(), out num))
    {
        if (num >= 100 && num <= 999)
        {
            byte firstDigit = (byte)(num / 100);
            byte secondDigit = (byte)((num - firstDigit * 100) / 10);
            if (firstDigit > secondDigit)
            {
                Console.WriteLine("First digit is bigger");
            }
            else if (secondDigit > firstDigit)
            {
                Console.WriteLine("Second digit is bigger");
            }
            else if (firstDigit == secondDigit)
            {
                Console.WriteLine("First and second digits are equal");
            }
        }
        else
        {
            Console.WriteLine("number must be 3-values");
        }
    }
    else
    {
        Console.WriteLine("invalid input:(");
    }

}
Console.WriteLine("Lab 1 !");
Task2();
// continue ...
