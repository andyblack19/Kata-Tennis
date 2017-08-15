namespace Kata_Tennis
{
    public class TennisGame
    {
        private int _player1Points;
        private int _player2Points;

        public string Score()
        {
            var player1Score = FormatPointsAsTennisScore(_player1Points);
            var player2Score = FormatPointsAsTennisScore(_player2Points);

            return $"{player1Score} - {player2Score}";
        }

        public void AddPointForPlayer1()
        {
            _player1Points++;
        }

        public void AddPointForPlayer2()
        {
            _player2Points++;
        }

        private static string FormatPointsAsTennisScore(int points)
        {
            return points == 1 ? "Fifteen" : "Love";
        }
    }
}