using System;

public class leapYear
{
    public static void Main(string[] args)
    {
        int year = 2020;
        int loopNo = 0;

        while (loopNo < 21)
        {
            year += 4;
            Console.WriteLine(year);
            loopNo++;
        }
    }
}