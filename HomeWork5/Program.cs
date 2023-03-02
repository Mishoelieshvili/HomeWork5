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
        //UNDONE 
        {
            Console.Write("Enter the first number: ");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            var b = Convert.ToDouble(Console.ReadLine());

            var x = a;
            var y = b;

            Console.WriteLine(a + b);
            Console.WriteLine(b - a);
            Console.WriteLine(a * b);
            Console.WriteLine(b / a);

            switch (b / a)
            {
                case '/':
                    if (a == 0)
                    {
                        Console.WriteLine("Error 0 unbale to divide.");
                    }
                    else if (b == 0)
                    {
                        Console.WriteLine("Errpr 0 smallest number is 0.");
                    }
                    else
                    {
                        Console.WriteLine("Result: " + (a / b));
                    }
                    break;

            }
            #endregion

            #region Task3
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

    }
}







