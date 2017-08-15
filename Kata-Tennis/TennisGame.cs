namespace Kata_Tennis
{
    public class TennisGame
    {
        private int _player1Score;

        public string Score()
        {
            return _player1Score == 1 ? "Fifteen - Love" : "Love - Love";
        }

        public void AddPointForPlayer1()
        {
            _player1Score++;
        }
    }
}