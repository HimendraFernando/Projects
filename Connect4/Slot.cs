using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Connect4
{
    internal class Slot
    {
        private SolidBrush _slotColor;
        private bool _slotTaken;
        private int _player;
        private float _x;
        private float _y;
        private int _row;
        private int _column;

        public const int SlotWidth = 80; 
        public const int SlotHeight = 80; 
        public Slot()
        {
            _slotColor = new SolidBrush(Color.LightCyan);
            _slotTaken = false;
            _player = 0;
        }
        public float X
        // Get and set the x coordinate of the slot
        {
            get { return _x; }
            set { _x = value; }
        }
        public float Y
        // Get and set the y coordinate of the slot
        {
            get { return _y; }
            set { _y = value; }
        }
        public bool SlotTaken
        // Get and set the slotTaken value
        {
            get { return _slotTaken; }
            set { _slotTaken = value; }
        }
        public int Player
        // Get and set the player value
        {
            get { return _player; }
            set { _player = value; }
        }
        public Color SlotColor
        // Set the color of the slot
        {
            set { _slotColor.Color = value; }
        }
        public int Row
        // Get and set the row value
        {
            get { return _row; }
            set { _row = value; }
        }
        public int Column
        // Get and set the column value
        {
            get { return _column; }
            set { _column = value; }
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        //Draws the slot object in the picture box
        {
            g.FillEllipse(_slotColor, x, y, width, height);
            g.ResetTransform();
        }

        public bool IsSlotClicked(int x, int y)
        //Checks if the slot is clicked
        {
            return y >= _y && y <= _y + SlotHeight && x >= _x && x <= _x + SlotWidth;
        }
    }
}
