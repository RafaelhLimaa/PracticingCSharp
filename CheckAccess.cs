namespace PracticingCSharp
{
    internal class CheckAccess
    {
        public void Check()
        {
            Console.WriteLine("Welcome to the chemistry laboratory!");
            Console.WriteLine("To access you need to enter your password and enter your access level!");
            Console.WriteLine("First, enter your password:");
            _ = int.TryParse(Console.ReadLine(), out int password);
            if (password == 42)
            {
                Console.WriteLine("Your password is correct. Now enter your access level:");
                _ = int.TryParse(Console.ReadLine(), out int level);
                if (level > 5)
                {
                    Console.WriteLine("Your access level allows you to enter the laboraty. WELCOME!!");
                }
                else
                {
                    Console.WriteLine("Your access level does not allows you to enter the laboratory. I'm Sorry!");
                }
            }
            else
            {
                Console.WriteLine("Your password is wrong, try again!");
            }
        }
    }
}
