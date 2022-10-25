using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using Symfos.RockPaperScissors.Code;
using Symfos.RockPaperScissors.Controllers;
using Symfos.RockPaperScissors.Enums;
using Symfos.RockPaperScissors.Models;

namespace Symfos.RockPaperScissors.Tests
{
    public class HomeControllerTests
    {
        private HomeController _homeController;
        private Mock<IComputerChoiceGenerator> _computerChoiceGenerator;
        private Mock<IRockPaperScissorsResultEvaluator> _rockPaperScissorsResultEvaluator;
        private Mock<IResultsCounter> _resultsCounter;

        [SetUp]
        public void SetUp()
        {
            _computerChoiceGenerator = new Mock<IComputerChoiceGenerator>();
            _resultsCounter = new Mock<IResultsCounter>();
            _rockPaperScissorsResultEvaluator = new Mock<IRockPaperScissorsResultEvaluator>();
            _homeController = new HomeController(_computerChoiceGenerator.Object, _resultsCounter.Object, _rockPaperScissorsResultEvaluator.Object);
            
            var playerVsComputerResults = new PlayerVsComputerResults();
            playerVsComputerResults.Wins = 0;
            playerVsComputerResults.Loses = 0;
            playerVsComputerResults.Draws = 0;

            var cmputerVsComputerResults = new ComputerVsComputerResults();
            cmputerVsComputerResults.Wins = 0;
            cmputerVsComputerResults.Loses = 0;
            cmputerVsComputerResults.Draws = 0;
        }

        [Test]
        public void IndexActionRetunsViewResultTest()
        {
            // Act
            var result = _homeController.Index();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);

        }

        [Test]
        public void LevelActionRetunsViewResultTest()
        {
            // Act
            var result = _homeController.Level();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);

        } 
        
        [Test]
        public void PlayerVsComputerActionRetunsViewResultTest()
        {
            //Arrange
            var playerVsComputerViewModel = new PlayerVsComputerViewModel();

            // Act
            var result = (ViewResult)_homeController.PlayerVsComputer(playerVsComputerViewModel);
            var viewModel = (PlayerVsComputerViewModel)result.Model;

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.AreEqual(Choice.Invalid, viewModel.PlayerChoice);
            Assert.AreEqual(Choice.Invalid, viewModel.ComputerChoice);
            Assert.AreEqual(GameMode.Invalid, viewModel.Mode);
            Assert.AreEqual(Result.Invalid, viewModel.Result);
            Assert.AreEqual(0, viewModel.Results.Wins);
            Assert.AreEqual(0, viewModel.Results.Loses);
            Assert.AreEqual(0, viewModel.Results.Draws);

        } 
        
        [Test]
        public void PlayerVsComputerResultActionRetunsViewResultTest()
        {
            //Arrange
            var playerVsComputerViewModel = new PlayerVsComputerViewModel();
            _computerChoiceGenerator.Setup(x => x.ComputerChoice()).Returns(Choice.Invalid);
            _rockPaperScissorsResultEvaluator.Setup(x => x.Evaluate(Choice.Invalid, Choice.Invalid)).Returns(Result.Invalid);
            _resultsCounter.Setup(x => x.PlayerVsComputerResultsCounter(Result.Invalid)).Returns(new PlayerVsComputerResults());

            // Act
            var result = (RedirectToActionResult)_homeController.PlayerVsComputerResult(playerVsComputerViewModel);

            Assert.IsInstanceOf<RedirectToActionResult>(result);
            Assert.AreEqual("PlayerVsComputer", result.ActionName);

        }

        [Test]
        public void ComputerVsComputerActionRetunsViewResultTest()
        {
            //Arrange
            var computerVsComputerViewModel = new ComputerVsComputerViewModel();

            // Act
            var result = (ViewResult)_homeController.ComputerVsComputer(computerVsComputerViewModel);
            var viewModel = (ComputerVsComputerViewModel)result.Model;

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.AreEqual(Choice.Invalid, viewModel.PlayerChoice);
            Assert.AreEqual(Choice.Invalid, viewModel.ComputerChoice);
            Assert.AreEqual(GameMode.Invalid, viewModel.Mode);
            Assert.AreEqual(Result.Invalid, viewModel.Result);
            Assert.AreEqual(0, viewModel.Results.Wins);
            Assert.AreEqual(0, viewModel.Results.Loses);
            Assert.AreEqual(0, viewModel.Results.Draws);

        }

        [Test]
        public void ComputerVsComputerResultActionRetunsViewResultTest()
        {
            //Arrange
            var computerVsComputerViewModel = new ComputerVsComputerViewModel();
            _computerChoiceGenerator.Setup(x => x.ComputerChoice()).Returns(Choice.Invalid);
            _rockPaperScissorsResultEvaluator.Setup(x => x.Evaluate(Choice.Invalid, Choice.Invalid)).Returns(Result.Invalid);
            _resultsCounter.Setup(x => x.PlayerVsComputerResultsCounter(Result.Invalid)).Returns(new PlayerVsComputerResults());

            // Act
            var result = (RedirectToActionResult)_homeController.ComputerVsComputerResult(computerVsComputerViewModel);

            Assert.IsInstanceOf<RedirectToActionResult>(result);
            Assert.AreEqual("ComputerVsComputer", result.ActionName);

        }
    }
}
