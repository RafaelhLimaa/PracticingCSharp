namespace PracticingCSharp
{
    internal class UserAutentication
    {
        string user = "";
        public void ShowWelcome()
        {
            Console.WriteLine("Welcome to the User Autentication.");
            Console.Write("Please, enter your username: ");
            user = Console.ReadLine().ToUpper();

            if (user == "ADMIN")
            {
                Console.WriteLine($"Welcome {user}. You are admin of the system.");
            }
            else
            {
                Console.WriteLine($"\nUser not founded. Please select one of following options.");
                ShowRegisterMenu();
                bool check = true;
                do
                {
                    _ = int.TryParse(Console.ReadLine(), out int choose);
                    switch (choose)
                    {
                        case 1: RegisterUser(); check = false; break;
                        case 2: GuestAccess(); check = false; break;
                        case 3: Console.WriteLine("Exit the system."); check = false; break;
                        default: Console.WriteLine("Enter not found. Try again."); check = true; break;
                    }
                }while (check);
            }
        }

        public void ShowRegisterMenu()
        {
            Console.WriteLine("Register Menu");
            Console.WriteLine("-------------");
            Console.WriteLine("[1] - Register new user.");
            Console.WriteLine("[2] - Access as guest");
            Console.WriteLine("[3] - Exit");
        }

        public void RegisterUser()
        {
            Console.WriteLine($"{user}, your register  is successful.");
        }

        public void GuestAccess()
        {
            Console.WriteLine($"{user}, your access is allowed as guest!");
        }
    }
}
