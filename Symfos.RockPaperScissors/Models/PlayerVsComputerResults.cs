namespace Symfos.RockPaperScissors.Models
{
    public class PlayerVsComputerResults
    {
        private static int _wins = 0;
        private static int _loses = 0;
        private static int _draws = 0;
        public int Wins
        {
            get { return _wins; }
            set { _wins = value; }

        }
        public int Loses
        {
            get { return _loses; }
            set { _loses = value; }

        }
        public int Draws
        {
            get { return _draws; }
            set { _draws = value; }

        }

    }
}
