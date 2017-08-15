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
        [TestCase(2, 0, "Thirty - Love")]
        [TestCase(3, 0, "Forty - Love")]
        [TestCase(0, 1, "Love - Fifteen")]
        [TestCase(0, 2, "Love - Thirty")]
        [TestCase(0, 3, "Love - Forty")]
        [TestCase(1, 1, "Fifteen - Fifteen")]
        [TestCase(2, 2, "Thirty - Thirty")]
        [TestCase(3, 3, "Deuce")]
        [TestCase(4, 2, "Player 1 Wins")]
        [TestCase(2, 4, "Player 2 Wins")]
        [TestCase(4, 3, "Advantage Player 1")]
        [TestCase(5, 4, "Advantage Player 1")]
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
