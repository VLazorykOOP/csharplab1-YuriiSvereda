﻿// See https://aka.ms/new-console-template for more 

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
    Console.WriteLine("Enter 3-values number");
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
        Console.WriteLine(sequenceYearNumber switch
        {
            0 => "Monkey",
            1 => "Rooster",
            2 => "Dog",
            3 => "Pig",
            4 => "Rat",
            5 => "Ox",
            6 => "Tiger",
            7 => "Hare",
            8 => "Dragon",
            9 => "Snake",
            10 => "Horse",
            11 => "Ram",

        });
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


//solve the equation by the formula
static void Task6()
{
    Console.WriteLine("Task6!");
    Console.WriteLine("enter a:");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("enter b:");
    double b = double.Parse(Console.ReadLine());
    double result = 1 / (Math.Pow(a, 2) + a * b + 1) - 1 / (Math.Pow(b, 2) + a * b + 1);
    Console.WriteLine("Result = {0}", result);
}


//Menu of tasks
static void ShowMenu()
{
    string[] menuStrings =
    {
                "1. Task 1!",
                "2. Task 2!",
                "3. Task 3!",
                "4. Task 4!",
                "5. Task 5!",
                "6. Task 6!"
    };
    int currentOprtion = 0;
    ConsoleKeyInfo keyInfo;
    int choice = 0;
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Lab1!");
        PrintMenu(menuStrings, currentOprtion);


        keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.DownArrow)
        {
            currentOprtion = currentOprtion + 1 <= menuStrings.Length - 1 ? currentOprtion + 1 : 0;
        }
        else if (keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.UpArrow)
        {
            currentOprtion = currentOprtion - 1 >= 0 ? currentOprtion - 1 : menuStrings.Length - 1;
        }
        else if (keyInfo.Key == ConsoleKey.Enter)
        {
            choice = currentOprtion;
            break;
        }
    }
    switch (choice)
    {
        case 0:
            Task1();
            break;

        case 1:
            Task2();
            break;
        case 2:
            Task3();
            break;
        case 3:
            Task4();
            break;
        case 4:
            Task5();
            break;
        case 5:
            Task6();
            break;
        default:
            break;
    }
}
static void PrintMenu(string[] menuString, int choosenString)
{
    for (int i = 0; i < menuString.Length; i++)
    {
        if (i == choosenString)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        Console.WriteLine(menuString[i]);
        if (i == choosenString)
        {
            Console.ResetColor();
        }
    }
}


//Main
while (true)
{
    Console.Clear();
    ShowMenu();
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
// continue ...
