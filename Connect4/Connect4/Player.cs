using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    internal class Player
    {
        private string _playerName;
        private int _playerNumber;
        private int _playerScore;
        public Player()
        {
            _playerName = "User";
            _playerNumber = 1;
            _playerScore = 0;
        }
        public string PlayerName 
        {
            get { return _playerName; }
            set { _playerName = value; } 
        }
        public int PlayerNumber
        // Get and set the player number
        {
            get { return _playerNumber; }
        }
        public int PlayerScore
        // Get and set the player score
        {
            get { return _playerScore; }
            set { _playerScore = value; }
        }

        public void Winner()
        // Display a message box when the player wins
        {
            MessageBox.Show(_playerName + " wins!", "Game Over", MessageBoxButtons.OK);
        }
    }
}
