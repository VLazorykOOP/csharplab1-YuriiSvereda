// See https://aka.ms/new-console-template for more 

//1.14. радіус кола, площа круга якої дорівнює s
using static System.Runtime.InteropServices.JavaScript.JSType;

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

//потрапити крапкою в трикутник ([0;0],[-23;0][-23;-23])
static void Task3()
{
    Console.WriteLine("Task3!");
    Console.WriteLine("Enter point (format: x;y):");
    string input = Console.ReadLine();
    string[] splited = input.Split(';');
    float x, y;
    if (splited.Length == 2 &&
        float.TryParse(splited[0], out x) &&
        float.TryParse(splited[1], out y))
    {
        if (y == 0 && x <= 0 && x >= -23 ||
            x == -23 && y <= 0 && y >= -23 ||
            x == y && x <= 0 && x >= -23)
        {
            Console.WriteLine("On the edge");
        }
        else if (x < y && y > -23 && y < 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    else
    {
        Console.WriteLine("invalid format of input");
    }
}

//4.14. Дано рік. Вивести на екран назву тварини, що символізує заданий рік за східним календарем.
static void Task4()
{
    Console.WriteLine("Task4!");
    Console.WriteLine("Enter year:");
    int year;
    if (int.TryParse(Console.ReadLine(), out year))
    {
        Console.WriteLine("The name of an animal that symbolizes a given year in the Eastern calendar:");
        int sequenceYearNumber = year % 12;
        switch (sequenceYearNumber)
        {
            case 0:
                Console.WriteLine("Monkey");
                break;
            case 1:
                Console.WriteLine("Rooster");
                break;
            case 2:
                Console.WriteLine("Dog");
                break;
            case 3:
                Console.WriteLine("Pig");
                break;
            case 4:
                Console.WriteLine("Rat");
                break;
            case 5:
                Console.WriteLine("Ox");
                break;
            case 6:
                Console.WriteLine("Tiger");
                break;
            case 7:
                Console.WriteLine("Hare");
                break;
            case 8:
                Console.WriteLine("Dragon");
                break;
            case 9:
                Console.WriteLine("Snake");
                break;
            case 10:
                Console.WriteLine("Horse");
                break;
            case 11:
                Console.WriteLine("Ram");
                break;
        }
    }
    else
    {
        Console.WriteLine("invalid input :(");
    }
}

//5.14. Реалізувати функцію піднесення у квадрат різниці двох дійсних чисел
static void Task5()
{
    Console.WriteLine("Task5!");
    Console.WriteLine("enter first number:");
    double firstNum = double.Parse(Console.ReadLine());
    Console.WriteLine("enter second number:");
    double secondNum = double.Parse(Console.ReadLine());
    Console.WriteLine("result of function: {0}", SquaringDifferenceOfTwoRealNumbers(firstNum, secondNum));


}
static double SquaringDifferenceOfTwoRealNumbers(double firstNum, double secondNum)
{
    return Math.Pow(firstNum - secondNum, 2);
}

Console.WriteLine("Lab 1!");
Task5();
// continue ...
