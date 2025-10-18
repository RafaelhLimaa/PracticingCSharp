namespace PracticingCSharp
{
    internal class BasicOperationsCalculator
    {
        public void Calculate()
        {
            Console.WriteLine("Let's do one base operation calculation.");
            Console.WriteLine("For this, we need 2 numbers and 1 symbol of the basic operation (+, -, *, /).");
            Console.WriteLine("To start, enter the first number.");

            _ = decimal.TryParse(Console.ReadLine(), out decimal firstNumber);

            Console.WriteLine("Now, enter the second number.");

            _ = decimal.TryParse(Console.ReadLine(), out decimal secondNumber);

            bool option = true;
            do
            {
                Console.WriteLine("To follow, enter the symbol of the operation you need.");
                string symbol = Console.ReadLine();
                if (symbol != "")
                {
                    switch (symbol)
                    {
                        case "+":
                            Console.WriteLine($"Result: {firstNumber} {symbol} {secondNumber} = {firstNumber + secondNumber:F2}");
                            option = false;
                            break;
                        case "-":
                            Console.WriteLine($"Result: {firstNumber} {symbol} {secondNumber} = {firstNumber - secondNumber:F2}");
                            option = false;
                            break;
                        case "*":
                            Console.WriteLine($"Result: {firstNumber} {symbol} {secondNumber} = {firstNumber * secondNumber:F2}");
                            option = false;
                            break;
                        case "/":
                            Console.WriteLine($"Result: {firstNumber} {symbol} {secondNumber} = {firstNumber / secondNumber:F2}");
                            option = false;
                            break;
                        default:
                            Console.WriteLine("Symbol invalid! Try Again.");
                            option = true;
                            break;
                    }
                }
            } while (option);
                
        }
    }
}
