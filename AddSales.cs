namespace PracticingCSharp
{
    internal class AddSales
    {
        public void Calculate()
        {
            Console.WriteLine("Let's calculate your purchase's total.");
            Console.WriteLine("\nFor this, we need to enter the purchase's value.");

            bool condition = true;
            int valueFinal = 0;
            while (condition)
            {
                Console.WriteLine("\nEnter the purchase's value for this or enter '0' to exit.");
                _ = int.TryParse(Console.ReadLine(), out int value);
                valueFinal += value;

                if (value == 0) { condition = false; break; }
            }
            Console.WriteLine($"\nYour purchase's total is R${valueFinal}.");
        }
    }
}
