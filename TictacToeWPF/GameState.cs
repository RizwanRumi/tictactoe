using System;

namespace TicTacToeWPF
{
    public class GameState
    {
        public Player[,] GameGrid {  get; private set; }
        public Player CurrentPlayer { get; private set; }
        public int TurnsPassed { get; private set; }
        public bool GameOver { get; private set; }

        public event Action<int, int> MoveMade;
        public event Action<GameResult> GameEnded;
        public event Action GameRestarted;
    }
}
