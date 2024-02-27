//No:1


    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"Division: {num1 / num2}");
            Console.WriteLine($"Modulus: {num1 % num2}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
}

//No:2

{
    Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("First number is greater than the second number.");
        }
        else if (num1 < num2)
        {
            Console.WriteLine("First number is less than the second number.");
        }
        else
        {
            Console.WriteLine("Both numbers are equal.");
        }
    }


//No:3

{
    Console.WriteLine("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }

//No:4
{
    for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
//No:5


{
    int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine($"Sum of even numbers between 1 and 100: {sum}");
}
//No:7


    {
        for (int i = 2; i <= 100; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
     Console.WriteLine(i);
            }
        }
    }

