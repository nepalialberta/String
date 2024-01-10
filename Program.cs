using System;

class Program
{
    static void Main(String[] args)
    {
        string str = "";
        string reverse="";
        int Length = 0;

        Console.WriteLine("Enter the string here to reverse");
        str = Console.ReadLine();
        Length = str.Length - 1;
        while (Length >=0)
        {
            reverse = reverse + str[Length];
            Length--;
        }

        Console.WriteLine("Your reverse string is "+reverse);
        Console.ReadLine();

          


    }
}
