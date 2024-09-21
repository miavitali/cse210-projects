using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int lastDigit = percent % 10;
        if (percent >= 90 && lastDigit >= 7)
        {
            sign = "";
        }
        else if (percent < 60 && lastDigit >= 7 || lastDigit < 3)
        {
            sign = "";
        }
        else if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else{
            sign = "";
        }

        Console.WriteLine($"Your grade is: {sign}{letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}