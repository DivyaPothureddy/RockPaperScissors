using NUnit.Framework;
using Symfos.RockPaperScissors.Code;
using Symfos.RockPaperScissors.Enums;

namespace Symfos.RockPaperScissors.Tests
{
    public class ResultsCounterTests
    {
        private ResultsCounter _resultsCounter;

        [SetUp]
        public void SetUp()
        {
            _resultsCounter = new ResultsCounter();
        }

        [Test]
        public void ResultCounterReturnsPlayerVsComputerWinsCountTest()
        {
            //Arrage
            var gameResult = Result.Win;

            //Act
            var result = _resultsCounter.PlayerVsComputerResultsCounter(gameResult);

            //Assert
            Assert.AreEqual(1, result.Wins);
        }

        [Test]
        public void ResultCounterReturnsPlayerVsComputerLosesCountTest()
        {
            //Arrage
            var gameResult = Result.Lose;

            //Act
            var result = _resultsCounter.PlayerVsComputerResultsCounter(gameResult);

            //Assert
            Assert.AreEqual(1, result.Loses);
        }


        [Test]
        public void ResultCounterReturnsPlayerVsComputerDrawsCountTest()
        {
            //Arrage
            var gameResult = Result.Draw;

            //Act
            var result = _resultsCounter.PlayerVsComputerResultsCounter(gameResult);

            //Assert
            Assert.AreEqual(1, result.Draws);
        }

        [Test]
        public void ResultCounterDontIncrementCountForInvalidResultTest()
        {
            //Arrage
            var gameResult = Result.Invalid;

            //Act
            var result =  _resultsCounter.PlayerVsComputerResultsCounter(gameResult);

            //Assert
            Assert.AreEqual(0, result.Draws);
        }

        [Test]
        public void ResultCounterReturnsComputerVsComputerWinsCountTest()
        {
            //Arrage
            var gameResult = Result.Win;

            //Act
            var result = _resultsCounter.ComputerVsComputerResultsCounter(gameResult);

            //Assert
            Assert.AreEqual(1, result.Wins);
        }

        [Test]
        public void ResultCounterReturnsComputerVsComputerLosesCountTest()
        {
            //Arrage
            var gameResult = Result.Lose;

            //Act
            var result = _resultsCounter.ComputerVsComputerResultsCounter(gameResult);

            //Assert
            Assert.AreEqual(1, result.Loses);
        }


        [Test]
        public void ResultCounterReturnsComputerVsComputerDrawsCountTest()
        {
            //Arrage
            var gameResult = Result.Draw;

            //Act
            var result = _resultsCounter.ComputerVsComputerResultsCounter(gameResult);

            //Assert
            Assert.AreEqual(1, result.Draws);
        }
      
    }
}
