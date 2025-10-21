namespace PracticingCSharp
{
    internal class StockControl
    {
        int itemA = 0;
        int itemB = 0;
        int itemC = 0;

        void ShowMenu()
        {
            Console.WriteLine("Welcome to the Inventory System!");
            Console.WriteLine("Here, you can add itens to your inventory and check their quantity.");
            Console.WriteLine("We have 3 products, each identified by a letter. (A, B, C)");
            Console.WriteLine("Let's get Started!");
        }

        void ShowMainMenu()
        {
            Console.WriteLine("\n-------Main Menu-------");
            Console.WriteLine("1 - Choose an item to Add." +
                                  "\n2 - Choose an item to check." +
                                  "\n3 - Exit.");
        }

        void MenuAddItem()
        {
            Console.WriteLine("\n-----Menu Add Products-----");
            Console.WriteLine("1 - Add 'A' products." +
                                  "\n2 - Add 'B' products." +
                                  "\n3 - Add 'C' produtcs." +
                                  "\n4 - Back.");
        }

        void MenuCheckItem()
        {
            Console.WriteLine("\n----Menu Check Products----");
            Console.WriteLine("1 - Check quantity of products 'A'." +
                                  "\n2 - Check quantity of products 'B'." +
                                  "\n3 - Check quantity of products 'C'." +
                                  "\n4 - Back.");
        }

        public void Play()
        {
            ShowMenu();
            while (true)
            {
                ShowMainMenu();
                int choose = GetUserChoose(3);
                switch (choose)
                {
                    case 1:
                        bool check = true;
                        while (check)
                        {
                            MenuAddItem();
                            choose = GetUserChoose(4);
                            int quantity = 0;
                            if (choose > 0 && choose < 4)
                            {
                                Console.WriteLine("Enter the quantity of products to be added.");
                                _ = int.TryParse(Console.ReadLine(), out quantity);
                            }
                            switch (choose)
                            {
                                case 1: AddItem("A", quantity); Console.WriteLine("\nProducts added."); break;
                                case 2: AddItem("B", quantity); Console.WriteLine("\nProducts added."); break;
                                case 3: AddItem("C", quantity); Console.WriteLine("\nProducts added."); break;
                                case 4: check = false; break;
                            }
                        }
                        break;
                    case 2:
                        bool check1 = true;
                        while (check1)
                        {
                            MenuCheckItem();
                            int checkItem = GetUserChoose(4);
                            switch (checkItem)
                            {
                                case 1: CheckItem("A"); break;
                                case 2: CheckItem("B"); break;
                                case 3: CheckItem("C"); break;
                                case 4: check1 = false; break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Thank You, see you next time!");
                        return;
                }
            }
        }
        private void CheckItem(string item)
        {
            if (item == null) return;
            if (item == "A") { Console.WriteLine($"\nYou have {itemA} units in stock."); }
            if (item == "B") { Console.WriteLine($"\nYou have {itemB} units in stock."); }
            if (item == "C") { Console.WriteLine($"\nYou have {itemC} units in stock."); }
        }

        private void AddItem(string item, int qtd)
        {
            if (item == null) return;
            if (item == "A") { itemA += qtd; }
            ;
            if (item == "B") { itemB += qtd; }
            ;
            if (item == "C") { itemC += qtd; }
            ;
        }

        public int GetUserChoose(int maxOption)
        {
            int choose;
            while (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > maxOption)
            {
                Console.WriteLine($"Invalid enter. Please, choose one option between 1 and {maxOption}.");
            }
            return choose;
        }
    }
}
