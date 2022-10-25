using Symfos.RockPaperScissors.Enums;
using Symfos.RockPaperScissors.Models;

namespace Symfos.RockPaperScissors.Code
{
    public interface IResultsCounter
    {
       public PlayerVsComputerResults PlayerVsComputerResultsCounter(Result gameResult);
       public ComputerVsComputerResults ComputerVsComputerResultsCounter(Result gameResult);
    }
}