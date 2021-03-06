﻿using NUnit.Framework;

namespace Kata_Tennis
{
    internal class TennisScoringTests
    {
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
        [TestCase(3, 4, "Advantage Player 2")]
        [TestCase(4, 5, "Advantage Player 2")]
        [TestCase(6, 4, "Player 1 Wins")]
        [TestCase(4, 6, "Player 2 Wins")]
        public void Score_is_formatted_based_on_number_of_points(int player1Points, int player2Points, string expectedScore)
        {
            var game = new TennisGame();

            for (var i = 0; i < player1Points; i++)
                game.AddPointForPlayer1();

            for (var i = 0; i < player2Points; i++)
                game.AddPointForPlayer2();

            Assert.That(game.Score(), Is.EqualTo(expectedScore));
        }
    }
}
