namespace PracticingCSharp
{
    internal class PersonalizedGreeting
    {
        public void Data()
        {
            Console.WriteLine("Hello user, What's the period of the day? (Enter the reference number)" +
                "\n\t1 - Morning" +
                "\n\t2 - Afternoon" +
                "\n\t3 - Night");
            
            bool check = true;
            string period = "";
            do
            {
                _ = int.TryParse(Console.ReadLine(), out int enterData);
                switch (enterData)
                {
                    case 1: period = "Morning"; check = false; break; 
                    case 2: period = "Afternoon"; check = false; break;
                    case 3: period = "Night"; check = false; break;
                    default: Console.WriteLine("Invalid enter. Try again."); check = true; break;
                }
            }while (check);

            Console.WriteLine("Now, Enter your name!");
            string name = Console.ReadLine();

            Console.WriteLine($"Good {period}, {name}");
        }
    }
}
