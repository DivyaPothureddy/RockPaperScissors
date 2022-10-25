using Symfos.RockPaperScissors.Enums;
using Symfos.RockPaperScissors.Models;

namespace Symfos.RockPaperScissors.Code
{
    public class ResultsCounter : IResultsCounter
    {
        public PlayerVsComputerResults PlayerVsComputerResultsCounter(Result gameResult)
        {
            var playerVsComputerResults = new PlayerVsComputerResults();
            if (gameResult == Result.Win)
            {
                playerVsComputerResults.Wins++;
                return playerVsComputerResults;
            }

            if (gameResult == Result.Lose)
            {
                playerVsComputerResults.Loses++;
                return playerVsComputerResults;
            }

            if (gameResult == Result.Draw)
            {
                playerVsComputerResults.Draws++;
                return playerVsComputerResults;
            }
            return playerVsComputerResults;
        }

        public ComputerVsComputerResults ComputerVsComputerResultsCounter(Result gameResult)
        {
            var computerVsComputerResults = new ComputerVsComputerResults();
            if (gameResult == Result.Win)
            {
                computerVsComputerResults.Wins++;
                return computerVsComputerResults;
            }

            if (gameResult == Result.Lose)
            {
                computerVsComputerResults.Loses++;
                return computerVsComputerResults;
            }

            if (gameResult == Result.Draw)
            {
                computerVsComputerResults.Draws++;
                return computerVsComputerResults;
            }
            return computerVsComputerResults;
        }
    }
}
