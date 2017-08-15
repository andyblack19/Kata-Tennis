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

        [Test]
        public void Start_of_game_score_is_love_love()
        {
            Assert.That(_game.Score(), Is.EqualTo("Love - Love"));
        }

        [Test]
        public void Player1_has_single_point_is_fifteen_love()
        {
            _game.AddPointForPlayer1();
            Assert.That(_game.Score(), Is.EqualTo("Fifteen - Love"));
        }
    }
}
