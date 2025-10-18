namespace PracticingCSharp
{
    internal class RewardSystem
    {
        public void ShowReward()
        {
            Console.WriteLine("Welcome to the Reward System.");
            Console.WriteLine("Your Mission is complete, take your reward by the reference number:" +
                "\n\t1 - DOUBLE" +
                "\n\t2 - HEAL" +
                "\n\t3 - GOLD" +
                "\n\t4 - SPECIAL");

            bool check = true;
            string reward = "";
            int enterData = 0;
            do
            {
                _ = int.TryParse(Console.ReadLine(), out int choose);
                switch (choose)
                {
                    case 1: reward = "DOUBLE - Gain double EXP for 1 hour"; check = false; enterData = choose; break;
                    case 2: reward = "HEAL - Healing potion"; check = false; enterData = choose; break;
                    case 3: reward = "GOLD - 100 gold coins"; check = false; enterData = choose; break;
                    case 4: reward = "SPECIAL - Legendary Item"; check = false; enterData = choose; break;
                    default: Console.WriteLine("Invalid Enter. Try Again!"); check = true; break;
                }
            }while (check);
            Console.WriteLine($"Your choose is {enterData} and your reward is {reward}!");
        }
    }
}
