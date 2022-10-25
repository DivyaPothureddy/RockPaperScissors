using Symfos.RockPaperScissors.Enums;

namespace Symfos.RockPaperScissors.Code
{
    public class RockPaperScissorsResultEvaluator : IRockPaperScissorsResultEvaluator
    {
        public Result Evaluate(Choice playerChoice, Choice computerChoice)
        {
            if (playerChoice == computerChoice)
            {
                return Result.Draw;
            }

            if (playerChoice == Choice.Rock)
            {
                return RockResultEvaluator(computerChoice);
            }

            if (playerChoice == Choice.Paper)
            {
                return PaperResultEvaluator(computerChoice);
            }

            if (playerChoice == Choice.Scissors)
            {
                return ScissorsResultEvaluator(computerChoice);
            }

            return Result.Invalid;
        }

        private Result RockResultEvaluator(Choice computerChoice)
        {
            if (computerChoice == Choice.Paper)
            {
                return Result.Lose;
            }

            if (computerChoice == Choice.Scissors)
            {
                return Result.Win;
            }
            return Result.Invalid;
        }

        private Result PaperResultEvaluator(Choice computerChoice)
        {
            if (computerChoice == Choice.Rock)
            {
                return Result.Win;
            }

            if (computerChoice == Choice.Scissors)
            {
                return Result.Lose;
            }
            return Result.Invalid;
        }

        private Result ScissorsResultEvaluator(Choice computerChoice)
        {
            if (computerChoice == Choice.Rock)
            {
                return Result.Lose;
            }
            if (computerChoice == Choice.Paper)
            {
                return Result.Win;
            }
            return Result.Invalid;
        }
    }
}