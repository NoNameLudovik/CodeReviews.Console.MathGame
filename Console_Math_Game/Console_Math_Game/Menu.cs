namespace ConsoleMathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new GameEngine();
        internal void ShowMenu() // Show menu to player where he can choose a mode
        {
            GameDifficulty difficulty;

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine
                    ("1. Additional game\n" +
                     "2. Subtraction game\n" +
                     "3. Multiplication game\n" +
                     "4. Division game\n" +
                     "5. Show session history\n" +
                     "6. Quit");

                string playerInput;
                playerInput = Console.ReadLine();

                Console.Clear();

                switch (playerInput)//Launch gamemode based on player's input
                {
                    case "1":
                        difficulty = Helpers.ChooseDifficulty();
                        for (int round = 0; round < 5; round++)
                        {
                            gameEngine.AdditionMode(difficulty);
                        }
                        Helpers.RecordGameToHistory("Addition", Helpers.score, difficulty);
                        Helpers.ShowScore();
                        break;
                    case "2":
                        difficulty = Helpers.ChooseDifficulty();
                        for (int round = 0; round < 5; round++)
                        {
                            gameEngine.SubtractionMode(difficulty);
                        }
                        Helpers.RecordGameToHistory("Subtraction", Helpers.score, difficulty);
                        Helpers.ShowScore();
                        break;
                    case "3":
                        difficulty = Helpers.ChooseDifficulty();
                        for (int round = 0; round < 5; round++)
                        {
                            gameEngine.MultiplicationMode(difficulty);
                        }
                        Helpers.RecordGameToHistory("Multiplication", Helpers.score, difficulty);
                        Helpers.ShowScore();
                        break;
                    case "4":
                        difficulty = Helpers.ChooseDifficulty();
                        for (int round = 0; round < 5; round++)
                        {
                            gameEngine.DivisionMode(difficulty);
                        }
                        Helpers.RecordGameToHistory("Division", Helpers.score, difficulty);
                        Helpers.ShowScore();
                        break;
                    case "5":
                        Helpers.ShowHistory();
                        Console.ReadLine();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("The option does not exist. Please choose again");
                        break;
                }

                Console.Clear();
            }
        }
    }
}
