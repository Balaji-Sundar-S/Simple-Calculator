using System.Linq.Expressions;

public class Program
{
    public static void Main(string[] args)
    {
        bool isRunning = true;
        bool noChoice = true;
        while (isRunning)
        {
            Console.WriteLine("choose your operation.\n");

            Console.WriteLine("1. Add\n2. Sub\n3. Multiply\n4. Divide\n");
            int choice = Convert.ToInt32(Console.ReadLine());

            int[] choices = { 1, 2, 3, 4 };

            if (!choices.Contains(choice))
            {
                Console.WriteLine("Enter Proper Value.");
                noChoice = false;
            }

            if (noChoice)
            {
                Console.WriteLine("Enter First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                SwitchCase(choice, num1, num2);
            }

            Console.Write("\nContinue?(y/n)\t");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'y')
            {
                isRunning = true;
            }
            else
            {
                isRunning = false;
            }
        }
    }

    private static void SwitchCase(int choice, int num1, int num2)
    {
        switch (choice)
        {
            case 1:
                var resAdd = Addnum(num1, num2);
                Console.WriteLine($"sum of {num1} and {num2} is {resAdd}");
                break;
            case 2:
                var resSub = SubNum(num1, num2);
                Console.WriteLine($"difference of {num1} and {num2} is {resSub}");
                break;
            case 3:
                var resMul = MultiNum(num1, num2);
                Console.WriteLine($"product of {num1} and {num2} is {resMul}");
                break;
            case 4:
                var resDiv = DivNum(num1, num2);
                Console.WriteLine($"division of {num1} and {num2} is {resDiv}");
                break;
        }
    }
    private static int Addnum(int num1, int num2)
    {
        return num1 + num2;
    }

    private static int SubNum(int num1, int num2)
    {
        return num1 - num2;
    }

    private static int MultiNum(int num1, int num2)
    {
        return num1 * num2;
    }

    private static int DivNum(int num1, int num2)
    {
        return num1 / num2;
    }
}