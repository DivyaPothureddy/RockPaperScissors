using Symfos.RockPaperScissors.Enums;
using System;

namespace Symfos.RockPaperScissors.Code
{
    public class ComputerChoiceGenerator : IComputerChoiceGenerator
    {
        public Choice ComputerChoice()
        {
            var max = Enum.GetNames(typeof(Choice)).Length;
            var choice = (Choice)new Random().Next(1, max);
            return choice;

        }
    }
}
