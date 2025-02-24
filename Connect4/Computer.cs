using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    internal class Computer
    {
        private int _playerNumber;
        private int _playerScore;
        public Computer()
        {
            _playerNumber = 2;
            _playerScore = 0;
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
        // Display a message box when the computer wins
        {
            MessageBox.Show("Computer wins!", "Game Over", MessageBoxButtons.OK);
        }
    }
}
