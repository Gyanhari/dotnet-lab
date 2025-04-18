using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Enter Value of a");
        a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Value of b");
        //b = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Value of b");
        //c = Convert.ToInt32(Console.ReadLine());
        //if (a > b && a > c)
        //{
        //    Console.WriteLine("THe Largest Number is: a = " + a);
        //}
        //else if (b > a && b > c)
        //{
        //    Console.WriteLine("THe Largest Number is: b = " + b);
        //}
        //else
        //{
        //    Console.WriteLine("THe Largest Number is: c = " + c);

        //}

        //if(a%2 == 0 && a>0)
        //{
        //    Console.WriteLine("The number is even");
        //}
        //else
        //{
        //    Console.WriteLine("The number is odd");
        //}

        //if (a%4 ==0)
        //{
        //    Console.WriteLine("THe Year is a leap year");
        //}
        //int sum = 0;
        //int[] arr = { 1, 2, 3, 4, 5 };
        //foreach (int i in arr)
        //{
        //    sum += i;
        //}
        //Console.WriteLine(sum);

        //NumberGame fact = new NumberGame();
        //int v = fact.factorial(a);
        //Console.WriteLine("The factorial is: " + v);


        NumberGame prime = new NumberGame();
        bool v = prime.CheckPrime(a);
        string message = v ? "The Given Number "+ a +" is prime" : "The Given Number "+ a +" is Not Prime";
        Console.WriteLine(message);
        }
    }