namespace Kata_Tennis
{
    public class TennisGame
    {
        private int _player1Points;
        private int _player2Points;

        public string Score()
        {
            if (Player1HasWon())
                return "Player 1 Wins";

            if (IsDeuce())
                return "Deuce";

            return $"{FormatPointsAsTennisScore(_player1Points)} - {FormatPointsAsTennisScore(_player2Points)}";
        }

        private bool IsDeuce() => _player1Points == 3 && _player2Points == 3;
        private bool Player1HasWon() => _player1Points == 4 && _player2Points <= 2;

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
            switch (points)
            {
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
                default:
                    return "Love";
            }
        }
    }
}