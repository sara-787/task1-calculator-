using System;
 class task1
{
    float Add(float a, float b)
    {
        return a + b;
    }
    float subtract(float a, float b)
    {
        return a - b;
    }
    float mult(float a, float b)
    {
        return a * b;
    }
    float Division(float a, float b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error! Division by zero.");
            return 0;
        }
        return a / b;
    }

    static void Main() {
        task1 calc = new task1();

        float number_1, number_2, result;
        result = 0;
        char op;
        string choice=null;
        do
        {
            Console.Write("Enter 1st number: ");
            number_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            number_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an operator ( +, -, *, / ):");
            op = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (op == '+')
            {
                result = calc.Add(number_1, number_2);
            }
            else if (op == '-')
            {
                result = calc.subtract(number_1, number_2);
            }
            else if(op=='*'){

                result = calc.mult(number_1, number_2);
            }
            else if (op == '/')
            {
                result = calc.Division(number_1, number_2);
            }
            else
            {
                Console.WriteLine("Invalid operator!");
                continue;
            }
            Console.WriteLine($"Result: {result}");

            Console.Write("Do you want to perform another calculation? (yes/no): ");
            choice = Console.ReadLine().Trim().ToLower();

        } while (choice == "yes");

        Console.WriteLine("Calculator exited. Thank you!");
    }
}

