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

            if (Player2HasWon())
                return "Player 2 Wins";

            if (Player1HasAdvantage())
                return "Advantage Player 1";

            if (IsDeuce())
                return "Deuce";

            return $"{FormatPointsAsTennisScore(_player1Points)} - {FormatPointsAsTennisScore(_player2Points)}";
        }

        private bool IsDeuce() => _player1Points == 3 && _player2Points == 3;
        private bool Player1HasWon() => _player1Points == 4 && _player2Points <= 2;
        private bool Player2HasWon() => _player2Points == 4 && _player1Points <= 2;
        private bool Player1HasAdvantage() => _player1Points >= 4 && _player1Points - _player2Points == 1;

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