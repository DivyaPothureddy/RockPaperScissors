using NUnit.Framework;
using Symfos.RockPaperScissors.Code;
using Symfos.RockPaperScissors.Enums;

namespace Symfos.RockPaperScissors.Tests
{
    public class ComputerChoiceGeneratorTests
    {
        private ComputerChoiceGenerator _computerChoiceGenerator;

        [SetUp]
        public void Setup()
        {
            _computerChoiceGenerator = new ComputerChoiceGenerator();
        }

        [Test]
        public void ComputerChoiceGeneratorReturnsValidChoiceTests()
        {
           
            //Act
            var result = _computerChoiceGenerator.ComputerChoice();

            //Assert
            Assert.AreNotEqual(Choice.Invalid, result);
        }
    }
}
