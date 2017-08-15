using NUnit.Framework;

namespace Kata_Tennis
{
    internal class TennisScoringTests
    {
        private TennisGame _game;

        [SetUp]
        public void SetUp()
        {
            _game = new TennisGame();
        }

        [TestCase(0, 0, "Love - Love")]
        [TestCase(1, 0, "Fifteen - Love")]
        [TestCase(0, 1, "Love - Fifteen")]
        public void Score_is_formatted_based_on_number_of_points(int player1Points, int player2Points, string expectedScore)
        {
            for (var i = 0; i < player1Points; i++)
                _game.AddPointForPlayer1();

            for (var i = 0; i < player2Points; i++)
                _game.AddPointForPlayer2();

            Assert.That(_game.Score(), Is.EqualTo(expectedScore));
        }
    }
}
