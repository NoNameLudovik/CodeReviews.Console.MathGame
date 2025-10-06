namespace ConsoleMathGame
{
    internal class Helpers
    {
        static internal int score;
        static List<Game> gamesHistory = new List<Game>();//List of games played in actual session

        static internal void ShowScore() //Showing score in the end of game.
        {
            Console.WriteLine($"Your score: {score}");
            Console.WriteLine("Press enter to continue");
            score = 0;
            Console.ReadLine();
        }

        static internal GameDifficulty ChooseDifficulty()
        {
            Console.WriteLine("Choose difficulty:");
            Console.WriteLine
                    ("1. Easy\n" +
                     "2. Normal\n" +
                     "3. Hard");

            while (true)
            {
                string answer = Console.ReadLine();

                switch (Int32.Parse(answer))
                {
                    case 1:
                        Console.Clear();
                        return GameDifficulty.Easy;
                    case 2:
                        Console.Clear();
                        return GameDifficulty.Normal;
                    case 3:
                        Console.Clear();
                        return GameDifficulty.Hard;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
        }

        static internal int[] NumberGenerator(GameDifficulty difficulty) // Generate numbers based on chosen difficulty by player for mades
        {
            Random randomNumber = new Random();
            int[] numbers = new int[2];

            switch (difficulty)
            {
                case GameDifficulty.Easy:
                    numbers[0] = randomNumber.Next(1, 10);
                    numbers[1] = randomNumber.Next(1, 10);
                    break;
                case GameDifficulty.Normal:
                    numbers[0] = randomNumber.Next(1, 100);
                    numbers[1] = randomNumber.Next(1, 100);
                    break;
                case GameDifficulty.Hard:
                    numbers[0] = randomNumber.Next(1, 1000);
                    numbers[1] = randomNumber.Next(1, 1000);
                    break;
            }

            return numbers;
        }

        static internal void RecordGameToHistory(string mode, int score, GameDifficulty difficulty)
        {
            Game game = new Game(mode, score, difficulty);
            gamesHistory.Add(game);
        }

        static internal void ShowHistory()
        {
            foreach (var game in gamesHistory)
            {
                game.ShowGameDetail();
            }
        }

        static internal void ResultCheck(int result)
        {
            while (true)
            {
                int answer = 0;
                string playerInput = Console.ReadLine();

                if (Int32.TryParse(playerInput, out answer))
                {
                    if (answer == result)
                    {
                        Console.WriteLine("Good!");
                        Helpers.score++;// Add 1 score to player scores
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bad!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                    continue;
                }
            }
        }
    }

    internal enum GameDifficulty
    {
        Easy = 1,
        Normal,
        Hard
    }

    internal class Game(string mode, int score, GameDifficulty difficulty) //Class witch define games played by player in one session of program working.
    {
        DateTime time = DateTime.Now;
        string gameMode = mode;
        int gameScore = score;
        GameDifficulty gameDifficulty = difficulty;

        public void ShowGameDetail()//method for showing details about this game
        {
            Console.WriteLine($"{time}|{gameMode}|{gameDifficulty}|Score:{gameScore}");
        }
    }
}
