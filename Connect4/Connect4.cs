using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;

namespace Connect4
{
    public partial class Connect4 : Form
    {
        private Slot[,,] _slots;
        private Computer _computer;
        private Player _player;
        public Connect4()
        {
            InitializeComponent();
            InitialiseBoard();
        }

        private void InitialiseBoard()
        // Initialise the board
        {
            _slots = new Slot[7, 6, 1];
            _player = new Player();
            _computer = new Computer();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    _slots[i, j, 0] = new Slot();
                }
            }
        }

        private void Draw(Graphics paper)
        // Draw the slots
        {
            if (_slots == null)
            {
                return;
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (_slots[i, j, 0] != null)
                    {
                        _slots[i, j, 0].X = i * 80 + 20;
                        _slots[i, j, 0].Y = j * 80 + 20;
                        _slots[i, j, 0].Row = j;
                        _slots[i, j, 0].Column = i;
                        _slots[i, j, 0].Draw(paper, i * 80 + 20, j * 80 + 20, 80, 80);
                    }
                }
            }
        }

        private void TheBoard_Paint(object sender, PaintEventArgs e)
        // Draw the board
        {
            Graphics paper = e.Graphics;
            Draw(paper);
        }
        public int FindColumn(int x, int y)
        // Find the column of the slot
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Slot slot = _slots[i, j, 0];
                    if (slot.IsSlotClicked(x, y))
                    {
                        return slot.Column;
                    }
                }
            }
            return -1;
        }
        public int FindRow(int column, int playerMove)
        // Find the row of the slot
        {
            try
            {
                for (int i = 5; i >= 0; i--)
                {
                    Slot slot = _slots[column, i, 0];
                    if (!slot.SlotTaken)
                    {
                        slot.SlotTaken = true;
                        if (playerMove == 1)
                        {
                            slot.Player = 1;
                        }
                        else
                        {
                            slot.Player = 2;
                        }
                        return slot.Row;
                    }
                }
                return -1;
            }
            catch (Exception e)
            {
                return -1;
            }

        }

        public int CheckPoints(int column, int row, int player)
        // Check the points of the user and AI
        {
            int points = 0;

            // Check Horizontal
            points += CheckDirection(row, column, 0, 1, player); //Right
            points += CheckDirection(row, column, 0, -1, player); //Left

            //Check Horizontal Middle
            points += CheckDirection(row, column + 1, 0, -1, player); // Right middle to Left
            points += CheckDirection(row, column - 1, 0, 1, player); // Left middle to Right

            // Check Vertical
            points += CheckDirection(row, column, 1, 0, player); //Down
            points += CheckDirection(row, column, -1, 0, player); //Up

            // Check Diagonal(Bottom-Right to Top-Left)
            points += CheckDirection(row, column, 1, 1, player); //Bottom-Right
            points += CheckDirection(row, column, -1, -1, player); //Top-Left

            // Check Diagonal(Bottom-Left to Top-Right)
            points += CheckDirection(row, column, 1, -1, player); //Bottom-Left
            points += CheckDirection(row, column, -1, 1, player); //Top-Right

            // Check Middle Bottom Left to Right Top
            points += CheckDirection(row + 1, column - 1, -1, 1, player);

            // Check Middle Bottom Right to Left Top
            points += CheckDirection(row + 1, column + 1, -1, -1, player);

            // Check Middle Top Left to Right Bottom
            points += CheckDirection(row - 1, column - 1, 1, 1, player);

            // Check Middle Top Right to Left Bottom
            points += CheckDirection(row - 1, column + 1, 1, -1, player);

            return points;
        }

        public int CheckDirection(int row, int column, int rowStep, int columnStep, int player)
        // Check the slots in a direction on the board
        {
            int count = 0;
            int consecutive = 0;

            for (int i = 0; i < 4; i++)
            {
                int newColumn = column + i * columnStep;
                int newRow = row + i * rowStep;

                if (newColumn >= 0 && newColumn < 7 && newRow >= 0 && newRow < 6)
                {
                    if (_slots[newColumn, newRow, 0].Player == player)
                    {
                        consecutive++;
                        if (consecutive == 4)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return count;
        }
        public void ComputerMove()
        // The computer will make a move
        {
            Random rnd = new Random();
            int column = rnd.Next(7);
            int row = FindRow(column, 2);
            while (row == -1)
            {
                column = rnd.Next(7);
                row = FindRow(column, 2);
            }
            Fall(column, row, 2);
            int points = CheckPoints(column, row, 2);
            _computer.PlayerScore += points;
            TheBoard.Refresh();
        }

        public bool CheckWinner()
        // Check if there is a winner
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Slot slot = _slots[i, j, 0];
                    if (slot.SlotTaken == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void Fall(int column, int row, int player)
        //Creates an animation of the slot falling along the board
        {
            if (player == 1)
            {
                for (int i = 0; i < row; i++)
                {
                    _slots[column, i, 0].SlotColor = Color.Red;
                    TheBoard.Refresh();
                    Thread.Sleep(500);
                    _slots[column, i, 0].SlotColor = Color.LightCyan;
                    TheBoard.Refresh();
                }
                _slots[column, row, 0].SlotColor = Color.Red;
                TheBoard.Refresh();
            }
            else
            {
                for (int i = 0; i < row; i++)
                {
                    _slots[column, i, 0].SlotColor = Color.Yellow;
                    TheBoard.Refresh();
                    Thread.Sleep(500);
                    _slots[column, i, 0].SlotColor = Color.LightCyan;
                    TheBoard.Refresh();
                }
                _slots[column, row, 0].SlotColor = Color.Yellow;
                TheBoard.Refresh();
            }
            
        }

        private void TheBoard_MouseClick(object sender, MouseEventArgs e)
        // When the user clicks on the board the slot will change color
        {
            int x = e.X;
            int y = e.Y;
            int column = FindColumn(x, y);
            int row = FindRow(column, 1);
            if (column != -1 && row != -1)
            //Checks if the column and row are valid numbers
            {
                Fall(column, row, 1);
                int points = CheckPoints(column, row, 1);
                _player.PlayerScore += points;
                TheBoard.Refresh();

                Random random = new Random();
                Thread.Sleep(random.Next(500, 1000));

                ComputerMove();
                // Computer will make a move

                if (CheckWinner())
                // Check if there is a winner
                {
                    if (_player.PlayerScore > _computer.PlayerScore)
                    {
                        _player.Winner();
                    }
                    else if (_player.PlayerScore < _computer.PlayerScore)
                    {
                        _computer.Winner();
                    }
                    else
                    {
                        MessageBox.Show("It's a draw!", "Game Over", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Slot is already taken. Choose another slot.", "Invalid move", MessageBoxButtons.OK);
            }
        }

        private void pointsTimer_Tick(object sender, EventArgs e)
        // Update the points of the user and AI
        {
            if (_computer != null)
            {
                AIPoints.Text = "AI : " + _computer.PlayerScore;
            }
            else
            {
                AIPoints.Text = "AI : 0";
            }

            if (_player != null)
            {
                UserPoints.Text = _player.PlayerName + " : " + _player.PlayerScore;
            }
            else
            {
                UserPoints.Text = "User : 0";
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        // Start a new game
        {
            InitialiseBoard();
            TheBoard.Refresh();
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        // Set the player name
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.None)
            // When "Enter" key is pressed the property name of the Player class is updated to the text in the nameBox
            {
                _player.PlayerName = nameBox.Text;
                nameBox.Text = "";
            }
        }
    }
}
