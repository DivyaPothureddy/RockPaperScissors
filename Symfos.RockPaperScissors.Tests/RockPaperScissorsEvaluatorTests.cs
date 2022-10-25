using NUnit.Framework;
using Symfos.RockPaperScissors.Code;
using Symfos.RockPaperScissors.Enums;

namespace Symfos.RockPaperScissors.Tests
{
    public class RockPaperScissorsEvaluatorTests
    {
        private RockPaperScissorsResultEvaluator _rockPaperScissorsResultEvaluator;

        [SetUp]
        public void Setup()
        {
            _rockPaperScissorsResultEvaluator = new RockPaperScissorsResultEvaluator();
        }

        [Test]
        public void PlayersChoiceAreSameReturnsDrawResultTests()
        {
            //Arrange
            var playerChoice = Choice.Rock;
            var computerChoice = Choice.Rock;
          
            //Act

            var result = _rockPaperScissorsResultEvaluator.Evaluate(playerChoice, computerChoice);

            //Assert
            Assert.AreEqual(Result.Draw, result);
        }

        [Test]
        public void PlayersChoiceInvalidReturnsInvalidResultTests()
        {
            //Arrange
            var playerChoice = Choice.Invalid;
            var computerChoice = Choice.Rock;

            //Act

            var result = _rockPaperScissorsResultEvaluator.Evaluate(playerChoice, computerChoice);

            //Assert
            Assert.AreEqual(Result.Invalid, result);
        }

        [Test]
        public void ComputerChoiceInvalidReturnsInvalidResultTests()
        {
            //Arrange
            var playerChoice = Choice.Rock;
            var computerChoice = Choice.Invalid;

            //Act
            var result = _rockPaperScissorsResultEvaluator.Evaluate(playerChoice, computerChoice);

            //Assert
            Assert.AreEqual(Result.Invalid, result);
        }

        [Test]
        public void RockAndPaperReturnsLoseResultTests()
        {
            //Arrange
            var playerChoice = Choice.Rock;
            var computerChoice = Choice.Paper;

            //Act

            var result = _rockPaperScissorsResultEvaluator.Evaluate(playerChoice, computerChoice);

            //Assert
            Assert.AreEqual(Result.Lose, result);
        }

        [Test]
        public void RockAndScissorsReturnsWinResultTests()
        {
            //Arrange
            var playerChoice = Choice.Rock;
            var computerChoice = Choice.Scissors;

            //Act

            var result = _rockPaperScissorsResultEvaluator.Evaluate(playerChoice, computerChoice);

            //Assert
            Assert.AreEqual(Result.Win, result);
        }

        [Test]
        public void PaperAndRockReturnsWinResultTests()
        {
            //Arrange
            var playerChoice = Choice.Paper;
            var computerChoice = Choice.Rock;

            //Act

            var result = _rockPaperScissorsResultEvaluator.Evaluate(playerChoice, computerChoice);

            //Assert
            Assert.AreEqual(Result.Win, result);
        }

        [Test]
        public void PaperAndScissorsReturnsLoseResultTests()
        {
            //Arrange
            var playerChoice = Choice.Paper;
            var computerChoice = Choice.Scissors;

            //Act

            var result = _rockPaperScissorsResultEvaluator.Evaluate(playerChoice, computerChoice);

            //Assert
            Assert.AreEqual(Result.Lose, result);
        }

        [Test]
        public void ScissorsAndRockReturnsLoseResultTests()
        {
            //Arrange
            var playerChoice = Choice.Scissors;
            var computerChoice = Choice.Rock;

            //Act

            var result = _rockPaperScissorsResultEvaluator.Evaluate(playerChoice, computerChoice);

            //Assert
            Assert.AreEqual(Result.Lose, result);
        }

        [Test]
        public void ScissorsAndPaperReturnsWinResultTests()
        {
            //Arrange
            var playerChoice = Choice.Scissors;
            var computerChoice = Choice.Paper;

            //Act

            var result = _rockPaperScissorsResultEvaluator.Evaluate(playerChoice, computerChoice);

            //Assert
            Assert.AreEqual(Result.Win, result);
        }
    }
}