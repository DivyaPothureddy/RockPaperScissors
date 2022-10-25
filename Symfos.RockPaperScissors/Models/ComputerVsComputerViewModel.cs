using Symfos.RockPaperScissors.Enums;

namespace Symfos.RockPaperScissors.Models
{
    public class ComputerVsComputerViewModel
    {
        public GameMode Mode { get; set; }
        public Choice PlayerChoice { get; set; }
        public Choice ComputerChoice { get; set; }
        public Result Result { get; set; }
        public ComputerVsComputerResults Results { get; set; }
    }
}