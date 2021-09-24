using System;

namespace Alqoritm_kod_1
{
    class Program
    {
        //static void Main(string[] args)
        //{

        //    #region Task 1
        //    int mark;
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Write("Enter students score:");
        //            mark = Convert.ToInt32(Console.ReadLine());

        //            if (mark >= 91 && mark <= 100)
        //            {
        //                Console.WriteLine("A");
        //            }
        //            if (mark >= 81 && mark <= 90)
        //            {
        //                Console.WriteLine("B");
        //            }
        //            if (mark >= 71 && mark <= 80)
        //            {
        //                Console.WriteLine("C");
        //            }
        //            if (mark >= 61 && mark <= 70)
        //            {
        //                Console.WriteLine("D");
        //            }
        //            if (mark >= 51 && mark <= 60)
        //            {
        //                Console.WriteLine("E");
        //            }
        //            if (mark >= 0 && mark <= 50)
        //            {
        //                Console.WriteLine("Fail :(");
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine("Invalid Score. Please, try again.");
        //        }
        //    }

        //    #endregion
        //}
        //static void Main(string[] args)
        //{
        //    #region Task 2
        //    int number;
        //    int divider = 1;

        //    Console.Write("Enter a number:");
        //    number = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 1; i <= number; i++, divider++)
        //    {

        //        if (number % divider == 0)
        //        {
        //            Console.WriteLine(divider);
        //        }
        //    }
        //    #endregion
        //}
        //static void Main(string[] args)
        //{
        //    #region Task 3
        //    int number;
        //    int i = 0;
        //    Console.Write("Enter a number:");
        //    number = Convert.ToInt32(Console.ReadLine());
        //    while (number >= 1)
        //    {
        //        number /= 10; i++;
        //    }
        //    Console.WriteLine(i);
        //    #endregion
        //}
        //static void Main(string[] args)
        //{
        //    #region Task 4
        //    int number;
        //    int result = 0;
        //    Console.Write("Enter a number:");
        //    number = Convert.ToInt32(Console.ReadLine());
        //    while (number >= 1)
        //    {
        //        result += number % 10;
        //        number = (number - (number % 10)) / 10;

        //    }
        //    Console.WriteLine(result);
        //    #endregion

        //}
        //static void Main(string[] args)
        //{
        //    #region Task 5

        //}
        //static void Main(string[] args)
        //{
        //    #region Task 6
        //    int i, fact = 1, number;
        //    Console.WriteLine("Enter any Number:");
        //    number = int.Parse(Console.ReadLine());
        //    for (i = 1; i <= number; i++)
        //    {
        //        fact = fact * i;

        //    }
        //    Console.Write("Factorial of " + number + "is:" + fact);
        //    #endregion

        //}
        //static void Main(string[] args)
        //{
        //    #region Task 7
        //    int[] arry = { 10, 15, 18, 20 };

        //    int max = arry[0];
        //    int min = arry[0];
        //    for (int i = 0; i< arry.Length; i++)
        //    {
        //        if (max < arry[i])

        //        {
        //            max = arry[i];

        //        }
        //        if (min>arry[i])
        //        {
        //            min = arry[i];
        //        }
        //    }
        //    Console.WriteLine(max + min);
        //    #endregion
        //}
        //static void Main(string[] args)
        //{
        //    #region Task 8
        //    string[] seasonOfTheYear = { "Spring", "Summer", "Winter", "Autumn" };
        //    int number;
        //    Console.Write("Enter a number between 1 and 4: ");
        //    number = Convert.ToInt32(Console.ReadLine());
        //    if (number >= 1 && number <= 4)
        //    {
        //        switch(number)
        //        {
        //            case 1:
        //                Console.WriteLine(seasonOfTheYear[0]);
        //                break;
        //            case 2:
        //                Console.WriteLine(seasonOfTheYear[1]);
        //                break;
        //            case 3:
        //                Console.WriteLine(seasonOfTheYear[2]);
        //                break;
        //            case 4:
        //                Console.WriteLine(seasonOfTheYear[3]);
        //                break;

        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Number is not correct");
        //    }
        //    #endregion
        //}
        //static void Main(string[] args)
        //{
        //    #region Task 9

        //    string[] names = { "Ali", "Kamran", "Kamal", "Mohammed" };
        //    Console.WriteLine(GetMaxString(names));

        //    static string GetMaxString(string[] arr)
        //    {

        //        string result = "";
        //        for (int i = 0; i < arr.Length; i++)

        //        {
        //            if (arr[i].Length > result.Length)
        //            {
        //                result = arr[i];

        //            }

        //        }
        //        return result;
        //    }
        //    #endregion
            //static void Main(string[] args)
            
                //    #region Task 10

                //    int a, b;

                //    Console.WriteLine("\b\b");
                //    Console.WriteLine("Display the multiplication table:\b");
                //    Console.WriteLine("-----------------");
                //    Console.WriteLine("\b\b");

                //    Console.WriteLine("Input the number (Table to be calculated) : ");
                //    b = Convert.ToInt32(Console.ReadLine());
                //    Console.Write("\n");
                //    for (a = 1; a <= 10; a++)

                //    {
                //        Console.Write("{0} x {1} = {2} \b", b, a, b * a);
                //    }
                //}
                //#endregion







            }




}