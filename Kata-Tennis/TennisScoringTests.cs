using NUnit.Framework;

namespace Kata_Tennis
{
    internal class TennisScoringTests
    {
        [Test]
        public void Start_of_game_score_is_love_love()
        {
            var game = new TennisGame();
            Assert.That(game.Score(), Is.EqualTo("Love - Love"));
        }
    }
}
