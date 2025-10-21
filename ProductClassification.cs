namespace PracticingCSharp
{
    internal class ProductClassification
    {
        public void Classify()
        {
            Console.WriteLine("Please, Enter the number of the product between (1 and 2).");
            _ = int.TryParse(Console.ReadLine(), out int enter);

            if (enter == 1)
            {
                Console.WriteLine("Your product is Perishable!");
            }
            else if (enter == 2)
            {
                Console.WriteLine("Your product is not Perishable!");
            }
            else
            {
                Console.WriteLine("The number entered is invalid!.");
            }
        }
    }
}
