using System.ComponentModel;
try
{
    Console.WriteLine("Hello! Please choose task by entering number 1 or 2");
    int task = Convert.ToInt32(Console.ReadLine());
    if (task == 1)
    {
        Console.WriteLine("You chose task number 1");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int number3 = number1;
        int number4 = number2;
        while (number1 >= number2)
        {
            int a = number2;
            Console.Write($"{a}\t");
            number2 += 1;

        }
        Console.WriteLine("");
        number1 = number3;
        number2 = number4;
        while (number2 >= number1)
        {
            int a = number1;
            Console.Write($"{a}\t");
            number1 += 1;

        }
        Console.WriteLine("");
        number1 = number3;
        number2 = number4;
        while (number1 >= number2)
        {
            int a = number1;
            Console.Write($"{a}\t");
            number1 -= 1;

        }
        number1 = number3;
        number2 = number4;
        Console.WriteLine("");
        while (number2 >= number1)
        {
            int a = number2;
            Console.Write($"{a}\t");
            number2 -= 1;

        }
        number1 = number3;
        number2 = number4;
        Console.WriteLine("");
        while (number1 >= number2)
        {
            int a = number2;
            if (a % 7 == 0)
            {
                Console.Write($"{a}\t");
            }
            number2 += 1;
        }
        number1 = number3;
        number2 = number4;
        Console.WriteLine("");

        while (number2 >= number1)
        {
            int a = number1;
            if (a % 7 == 0)
            {
                Console.Write($"{a}\t\n");

            }
            number1 += 1;
        }
        number1 = number3;
        number2 = number4;

        int five = 0;
        int f = number2;
        while (number1 >= number2)
        {
            number2++;
            if (number2 % 5 == 0)
            {
                five++;

            }
        }
        while (number2 >= number1)
        {
            number1++;
            if (number1 % 5 == 0)
            {
                five++;

            }
        }
        Console.WriteLine($"\n{five}");
    }
    else if (task == 2)
    {
        Console.WriteLine("You chose task number 2");
        int number5 = Convert.ToInt32(Console.ReadLine());
        int number6 = Convert.ToInt32(Console.ReadLine());
        int t = 0;
        int p = 0;
        int n = 0;
        int i = 0;
        int amount1 = 0;
        int amount2 = 0;
        int amount3 = 0;
        i = number6;
        for (; number5 >= i; i++)
        {

            if (i % 2 == 0)
            {

                t += i;
                amount1++;

            }
            else if (i % 2 != 0)
            {
                p += i;
                amount2++;
            }
            if (i % 9 == 0)
            {
                n += i;
                amount3++;
            }
            else { }
        }
        i = number5;
        for (; number6 >= i; i++)
        {

            if (i % 2 == 0)
            {

                t += i;
                amount1++;

            }
            else if (i % 2 != 0)
            {
                p += i;
                amount2++;
            }
            if (i % 9 == 0)
            {
                n += i;
                amount3++;
            }
            else { }
        }
        Console.WriteLine($"Sum of even numbers: {t}");
        Console.WriteLine($"Sum of odd numbers: {p}");
        Console.WriteLine($"Sum of numbers that can be divided by 9: {n}");
        Console.WriteLine($"Average of even numbers: {t / amount1}");
        Console.WriteLine($"Average of odd numbers: {p / amount2}");
        Console.WriteLine($"Average of numbers that can be divided by 9: {n / amount3}");

    }
    if ((task != 1) && (task != 2))
    {
        throw new FileNotFoundException($"There is no such task as {task}");
    }
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("You can't divide by zero");
    Console.WriteLine(ex.Message);

}
catch (FormatException ex)
{
    Console.WriteLine("This is wrong type of data");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("We don`t do that here");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
