using System;

class Program
{
    static void Main(string[] args)
    {
        string letter_grade = "";
        string message = "";

        Console.Write("Enter your grade percentage: ");
        string grade_percentage = Console.ReadLine();
        int grade = int.Parse(grade_percentage);

        if (grade >= 90)
        {
            letter_grade = "A";
        }
        else if (grade >= 80)
        {
            letter_grade = "B";
        }
        else if (grade >= 70)
        {
            letter_grade = "C";
        }
        else if (grade >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }

        if (grade >= 70)
        {
            message = "Congratulations! You passed.";
        }
        else
        {
            message = "Too bad! Better luck next time.";
        }

        Console.WriteLine($"Your grade is: {letter_grade}");
        Console.WriteLine($"{message}");
    }
}