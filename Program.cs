public class Program
{
    public static void Main(string[] args)
    {

        Write1ThroughN_While(5);
        Write1ThroughN_While(-1);
        Write1ThroughN_While(0);
        Write1ThroughN_For(5);
        Write1ThroughN_For(-1);
        Write1ThroughN_For(0);

        WriteNThrough1_While(5);
        WriteNThrough1_While(-1);
        WriteNThrough1_While(0);
        WriteNThrough1_For(5);
        WriteNThrough1_For(-1);
        WriteNThrough1_For(0);

        WriteEvensThrough100();

        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);

        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);

        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);

        OutputRightTriangle(4);
        OutputRightTriangle(6);
        OutputRightTriangle(-4);
        OutputRightTriangle(-6);
        //OutofRangeMessage();


    }

    public static void Write1ThroughN_While(int n)
    {

        int counter = 1;

        if (n < 1)
        {
            Console.WriteLine(n + " is out of range.");
        }

        else
        {


            while (counter <= n)
            {
                Console.WriteLine(counter);
                Thread.Sleep(100);
                counter++;
            }

        }
    }

    public static void Write1ThroughN_For(int n)
    {
        if (n > 0)
        {
            for (int counter = 1; counter <= n; counter++)
            {
                Console.WriteLine(counter);
            }

        }

        else
        {
            Console.WriteLine(n + " is out of range.");
        }

    }

    public static void WriteNThrough1_While(int n)
    {
        if (n > 0)
        {
            for (int counter = n; counter > 0; counter--)
            {
                Console.WriteLine(counter);
            }
        }

        else
        {
            Console.WriteLine(n + " is out of range.");
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        if (n > 0)
        {
            for (int counter = n; counter > 0; counter--)
            {
                Console.WriteLine(counter);
            }
        }

        else
        {
            Console.WriteLine(n + " is out of range.");
        }
    }

    public static void FindSum(int n)
    {
        int sum = 0;

        if (n > 0)
        {
            for (int counter = 1; counter <= n; counter++)
            {
                sum = sum + counter;
            }
            Console.WriteLine(sum);
        }

        else if (n < 0)
        {
            for (int counter = 1; counter >= n; counter--)
            {
                sum = sum + counter;

            }
            Console.WriteLine(sum);
        }
    }

    public static void FindSumOfEvenNumbers(int n)
    {

        int sum = 0;

        if (n > 0)
        {
            for (int counter = 0; counter <= n; counter += 2)
            {
                sum = sum + counter;

            }

        }

        else if (n < 0)

        {
            for (int counter = 0; counter >= n; counter -= 2)
            {
                sum = sum + counter;
            }
        }
        Console.WriteLine(sum);
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int sum = 0;

        if (n > 0)
        {
            for (int counter = 1; counter <= n; counter += 2)
            {
                sum = sum + counter;
            }
        }

        else if (n < 0)
        {
            for (int counter = 1; counter >= n; counter -= 2)
            {
                sum = sum + counter;
            }
        }
        Console.WriteLine(sum);
    }
    public static void WriteEvensThrough100()
    {
        for (int counter = 2; counter < 102; counter += 2)
            Console.Write(counter + " ");
        Console.WriteLine();
    }

    public static void OutputRightTriangle(int _base)
    {

        if (_base > 0)

            for (int counter = 0; counter < _base; counter++)
            {
                for (int j = 0; j < counter + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

        else

            for (int j = _base; j < 0; j++)
            {
                for (int counter = j; counter < 0; counter++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
    }


    public static void OutofRangeMessage(int n)
    {
        Console.WriteLine(n + " is out of range where " + n + " is the integer parameter.");
    }

}

