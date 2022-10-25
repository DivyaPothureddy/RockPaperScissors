using Symfos.RockPaperScissors.Enums;

namespace Symfos.RockPaperScissors.Code
{
    public interface IRockPaperScissorsResultEvaluator
    {
        Result Evaluate(Choice playerChoice, Choice computerChoice);
    }
}