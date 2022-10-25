using Microsoft.AspNetCore.Mvc;
using Symfos.RockPaperScissors.Code;
using Symfos.RockPaperScissors.Models;

namespace Symfos.RockPaperScissors.Controllers
{
    public class HomeController : Controller
    {
        private readonly IComputerChoiceGenerator _computerChoiceGenerator;
        private readonly IResultsCounter _resultsCounter;
        private readonly IRockPaperScissorsResultEvaluator _rockPaperScissorsResultEvaluator;

        public HomeController(IComputerChoiceGenerator computerChoiceGenerator, IResultsCounter resultsCounter, IRockPaperScissorsResultEvaluator rockPaperScissorsResultEvaluator)
        {
            _computerChoiceGenerator = computerChoiceGenerator;
            _resultsCounter = resultsCounter;
            _rockPaperScissorsResultEvaluator = rockPaperScissorsResultEvaluator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Level()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PlayerVsComputer(PlayerVsComputerViewModel playerModel)
        {
            var player = new PlayerVsComputerViewModel
            {
                PlayerChoice = playerModel.PlayerChoice,
                ComputerChoice = playerModel.ComputerChoice,
                Mode = playerModel.Mode,
                Result = playerModel.Result,
                Results = new PlayerVsComputerResults()
            };
            return View(player);
        }

        [HttpPost]
        public IActionResult PlayerVsComputerResult(PlayerVsComputerViewModel player)
        {
            var computerChoice = _computerChoiceGenerator.ComputerChoice();
            var result = _rockPaperScissorsResultEvaluator.Evaluate(player.PlayerChoice, computerChoice);
            var playerVsComputerResults = _resultsCounter.PlayerVsComputerResultsCounter(result);
            var playerResult = new PlayerVsComputerViewModel
            {
                PlayerChoice = player.PlayerChoice,
                ComputerChoice = computerChoice,
                Mode = player.Mode,
                Result = result,
                Results = playerVsComputerResults
            };

            return RedirectToAction("PlayerVsComputer", playerResult);
        }

        [HttpGet]
        public IActionResult ComputerVsComputer(ComputerVsComputerViewModel computerViewModel)
        {
            var player = new ComputerVsComputerViewModel
            {
                PlayerChoice = computerViewModel.PlayerChoice,
                ComputerChoice = computerViewModel.ComputerChoice,
                Mode = computerViewModel.Mode,
                Result = computerViewModel.Result,
                Results = new ComputerVsComputerResults()
            };
            return View(player);
        }

        [HttpPost]
        public IActionResult ComputerVsComputerResult(ComputerVsComputerViewModel player)
        {
            var playerChoice = _computerChoiceGenerator.ComputerChoice();
            var computerChoice = _computerChoiceGenerator.ComputerChoice();
            var result = _rockPaperScissorsResultEvaluator.Evaluate(playerChoice, computerChoice);
            var computerVsComputerResults = _resultsCounter.ComputerVsComputerResultsCounter(result);
            var computerVsComputerViewModel = new ComputerVsComputerViewModel
            {
                PlayerChoice = playerChoice,
                ComputerChoice = computerChoice,
                Mode = player.Mode,
                Result = result,
                Results = computerVsComputerResults
            };

            return RedirectToAction("ComputerVsComputer", computerVsComputerViewModel);
        }
    }
}
