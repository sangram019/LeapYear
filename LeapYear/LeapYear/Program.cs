using System;
public class Program
{
    public static void Main()
    {
        int year;
        Console.Write("\n\n");
        Console.Write("Check whether a given year is leap year or not:\n");
        Console.Write("Input an year : ");
        year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4) == 0)
            Console.WriteLine(" is a leap year.", year);
        else
            Console.WriteLine(" is not a leap year.", year);
    }
}