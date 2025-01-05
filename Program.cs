public class Program
{
    public static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть перше число: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Введіть друге число: ");
        int secondNumber = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Виберіть тип математичної дії (+); (-); (*); (/): ");
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
                            Console.WriteLine("Ділення на нуль неможливе! ");
                        }
                    break;

                default:
                    Console.WriteLine("Неправильний тип математичної дії. Спробуйте ще раз.");
                    break;
            }
        } while (true);
    }
}