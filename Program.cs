 class Program
{
    private static void Main(string[] args)
    {
        Random dice = new Random();
        int roll;
        bool again = true;
        string choice;

        void rollDice()
        {
            roll = dice.Next(0, 9);
            Console.WriteLine($"You rolled {roll}");

        }

        void play()
        {
            Console.WriteLine("Do you want to roll again? Y/N ");
            choice = Console.ReadLine();
            choice.ToLower();
        }

        do
        {

            rollDice();
            play();
            if (choice.Equals("n"))
            {
                again = false;
                Console.WriteLine("Thanks for Playing");
            }


        } while (again == true);
    }
}