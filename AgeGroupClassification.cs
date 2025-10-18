namespace PracticingCSharp
{
    internal class AgeGroupClassification
    {
        public void Classify()
        {
            Console.WriteLine("Let's Classify the people in age groups!");
            Console.WriteLine("The groups are:" +
                "\n Children (0 to 12 years)" +
                "\n Teenager (13 to 17 years)" +
                "\n Adult (18 to 59)" +
                "\n Senior (60 years or older)");
            Console.WriteLine("Please, enter your age:");
            _ = int.TryParse(Console.ReadLine(), out int year);

            if (year > 0 && year <= 12)
            {
                Console.WriteLine("You are classified like a Children");
            }
            else if (year > 12 && year <= 17)
            {
                Console.WriteLine("You are classified like a Teenager");
            }
            else if (year > 17 && year <= 59)
            {
                Console.WriteLine("You are classified like a Adult");
            }
            else
            {
                Console.WriteLine("You are classified like a Senior");
            }
        }
    }
}
