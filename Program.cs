public class Program
{

    public static void Main(string[] args)
    {
         bool inputValues(bool ex1)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            try
            {
                Console.WriteLine("Введіть перше число: ");
                firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть друге число: ");
                secondNumber = int.Parse(Console.ReadLine());
                ex1 = true;
                return ex1;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Хибний варіант числа!");
                return false;
            }

        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int firstNumber = 0;
        int secondNumber = 0;
        bool entryValue = false;
        while (entryValue == false)
        {
            entryValue = inputValues(entryValue); 
        }

        do
        {
            Console.WriteLine("Виберіть тип математичної дії ( додавання(+); віднімання(-); множення(*); ділення(/) ): ");
            char typeOfMathActivity = char.Parse(Console.ReadLine());
            Console.WriteLine("Розрахунок: ");

            switch (typeOfMathActivity)
            {
                case '+':
                    int result1 = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result1}");
                    break;

                case '-':
                    int result2 = firstNumber - secondNumber;
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result2}");
                    break;

                case '*':
                    int result3 = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result3}");
                    break;

                case '/':
                        try
                        {
                            int result4 = firstNumber / secondNumber;
                            Console.WriteLine($"{firstNumber} / {secondNumber} = {result4}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Ділення на нуль неможливе!");
                        }
                    break;

                default:
                    Console.WriteLine("Неправильний тип математичної дії. Спробуйте ще раз.");
                    break;
            }
        } while (true);
    }
}