// Functions for Modes. Need difficulty in param for generate numbers depending on the chosen difficulty by player

namespace ConsoleMathGame
{
    internal class GameEngine
    {
        internal void DivisionMode(GameDifficulty difficulty)
        {
            int result = 0;
            int answer = 0;
            int[] numbers = Helpers.NumberGenerator(difficulty);

            while (true) //Find numbers for integer division result 
            {
                if (numbers[0] % numbers[1] == 0)
                {
                    break;
                }
                numbers = Helpers.NumberGenerator(difficulty);
            }

            result = numbers[0] / numbers[1];
            while (true)
            {
                Console.WriteLine($"{numbers[0]} / {numbers[1]} = ");
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

        internal void MultiplicationMode(GameDifficulty difficulty)
        {
            int result = 0;
            int answer = 0;
            int[] numbers = Helpers.NumberGenerator(difficulty);

            result = numbers[0] * numbers[1];
            while (true)
            {
                Console.WriteLine($"{numbers[0]} * {numbers[1]} = ");
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

        internal void SubtractionMode(GameDifficulty difficulty)
        {
            int result = 0;
            int answer = 0;
            int[] numbers = Helpers.NumberGenerator(difficulty);

            result = numbers[0] - numbers[1];
            while (true)
            {
                Console.WriteLine($"{numbers[0]} - {numbers[1]} = ");
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

        internal void AdditionMode(GameDifficulty difficulty)
        {
            int result = 0;
            int answer = 0;
            int[] numbers = Helpers.NumberGenerator(difficulty);

            result = numbers[0] + numbers[1];
            while (true)
            {
                Console.WriteLine($"{numbers[0]} + {numbers[1]} = ");
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
}
