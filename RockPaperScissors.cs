namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            
            string playerMove;
            
            while (true)
            {
                Console.WriteLine("Choose [r]rock, [p]paper, [s]scissors: ");
                playerMove = Console.ReadLine();
                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = rock;
                    break;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = paper;
                    break;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = scissors;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid option");
                    continue;
                }
            }
            Console.WriteLine($"You chose {playerMove}");
            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";
            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = rock;
                    break;
                case 2:
                    computerMove = paper;
                    break;
                case 3:
                    computerMove = scissors;
                    break;
            }
            Console.WriteLine($"The compuputer choose {computerMove}");

            if (playerMove == rock && computerMove == scissors || 
                playerMove == paper && computerMove == rock || 
                playerMove == scissors && computerMove == paper)
            {
                Console.WriteLine("You win.");
            }
            else if (playerMove == rock && computerMove == paper ||
                     playerMove == paper && computerMove == scissors ||
                     playerMove == scissors && computerMove == rock)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game was a draw.");
            }
        }
    }
}
