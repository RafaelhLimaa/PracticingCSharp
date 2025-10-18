namespace PracticingCSharp
{
    internal class BookOrganization
    {
        public void Organize()
        {
            Console.WriteLine("Welcome to the library. Let's organize the books in some references.");
            Console.WriteLine("We have the following category." +
                "\n\t 1: Science Fiction" +
                "\n\t 2: Classic Literature" +
                "\n\t 3: Fantasy" +
                "\n\t 4: Romance" +
                "\n\t 5: Suspense/Mystery" +
                "\n\t 6: Nonfiction" +
                "\n\t 7: Biographies/Memoirs" +
                "\n\t 8: Dystopia" +
                "\n\t 9: Young Adult");
            Console.WriteLine("\nTo organize, enter the code of the book.");

            bool check = true;
            string book = "";
            do
            {
                _ = int.TryParse(Console.ReadLine(), out int choose);
                switch (choose / 100)
                {
                    case 1: book = "1: Science Fiction"; check = false; break;
                    case 2: book = "2: Classic Literature"; check = false; break;
                    case 3: book = "3: Fantasy"; check = false; break;
                    case 4: book = "4: Romance"; check = false; break;
                    case 5: book = "5: Suspense/Mystery"; check = false; break;
                    case 6: book = "6: Nonfiction"; check = false; break;
                    case 7: book = "7: Biographies/Memories"; check = false; break;
                    case 8: book = "8: Dystopia"; check = false; break;
                    case 9: book = "9: Young Adult"; check = false; break;
                    default: Console.WriteLine("Enter not found. Try Again!!!"); check = true; break;
                }
            }while (check);
            Console.WriteLine($"\nThe category of your book is {book}.");
        }
    }
}
