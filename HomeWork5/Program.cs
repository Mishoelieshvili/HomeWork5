using System;

public class Program
{
    public static void Main(string[] args)

    #region Task1

    {
        Console.Write("Enter a number: ");
        var num = Convert.ToInt32(Console.ReadLine());

        if (num % 5 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        #endregion

        #region Task2
        {
            Console.WriteLine("Enter two numbers:");
            var z = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap:");
            Console.WriteLine("z = " + z);
            Console.WriteLine("c = " + c);

            var swap = z;
            z = c;
            c = swap;

            Console.WriteLine("After swap:");
            Console.WriteLine("z = " + z);
            Console.WriteLine("c = " + c);

            Console.ReadLine();
        }
        #endregion


        #region task3
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Multiplication table for " + num1);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num1 + " x " + i + " = " + (num1 * i));
            }
        }
        #endregion

        #region task4
        {   //მიბეჭდავს თვითონ რიცხვს დასაწყისში და ბოლოში თავისივე კვადრატს
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++) {
                int square = i * i;
                Console.WriteLine(square);
            }

        }
        #endregion

        #region task5 
        {
            Console.WriteLine("Enter two numbers:");
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Not Allowed To Divide By Zero");
            }
        }
        #endregion
    }
}

