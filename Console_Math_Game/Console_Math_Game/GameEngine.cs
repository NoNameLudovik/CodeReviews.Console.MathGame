// Functions for Modes. Need difficulty in param for generate numbers depending on the chosen difficulty by player

namespace ConsoleMathGame
{
    internal class GameEngine
    {
        internal void DivisionMode(GameDifficulty difficulty)
        {
            int result = 0;
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

            Console.WriteLine($"{numbers[0]} / {numbers[1]} = ");

            Helpers.ResultCheck(result);
        }

        internal void MultiplicationMode(GameDifficulty difficulty)
        {
            int result = 0;
            int[] numbers = Helpers.NumberGenerator(difficulty);

            result = numbers[0] * numbers[1];

            Console.WriteLine($"{numbers[0]} * {numbers[1]} = ");

            Helpers.ResultCheck(result);
        }

        internal void SubtractionMode(GameDifficulty difficulty)
        {
            int result = 0;
            int[] numbers = Helpers.NumberGenerator(difficulty);

            result = numbers[0] - numbers[1];

            Console.WriteLine($"{numbers[0]} - {numbers[1]} = ");

            Helpers.ResultCheck(result);
        }

        internal void AdditionMode(GameDifficulty difficulty)
        {
            int result = 0;
            int[] numbers = Helpers.NumberGenerator(difficulty);

            result = numbers[0] + numbers[1];

            Console.WriteLine($"{numbers[0]} + {numbers[1]} = ");

            Helpers.ResultCheck(result);
        }
    }
}
