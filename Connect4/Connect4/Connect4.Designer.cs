namespace Connect4
{
    partial class Connect4
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TheBoard = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            UserPoints = new Label();
            AIPoints = new Label();
            pointsTimer = new System.Windows.Forms.Timer(components);
            NewGameButton = new Button();
            nameBox = new TextBox();
            nameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)TheBoard).BeginInit();
            SuspendLayout();
            // 
            // TheBoard
            // 
            TheBoard.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TheBoard.BackColor = Color.RoyalBlue;
            TheBoard.Location = new Point(217, 118);
            TheBoard.Name = "TheBoard";
            TheBoard.Size = new Size(597, 522);
            TheBoard.TabIndex = 0;
            TheBoard.TabStop = false;
            TheBoard.Paint += TheBoard_Paint;
            TheBoard.MouseClick += TheBoard_MouseClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(349, 31);
            label1.Name = "label1";
            label1.Size = new Size(338, 39);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Connect4";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(833, 191);
            label2.Name = "label2";
            label2.Size = new Size(195, 39);
            label2.TabIndex = 2;
            label2.Text = "You are Red";
            // 
            // UserPoints
            // 
            UserPoints.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserPoints.AutoSize = true;
            UserPoints.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserPoints.ForeColor = Color.Red;
            UserPoints.Location = new Point(12, 234);
            UserPoints.Name = "UserPoints";
            UserPoints.Size = new Size(80, 30);
            UserPoints.TabIndex = 3;
            UserPoints.Text = "User :";
            // 
            // AIPoints
            // 
            AIPoints.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AIPoints.AutoSize = true;
            AIPoints.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AIPoints.ForeColor = Color.Yellow;
            AIPoints.Location = new Point(34, 299);
            AIPoints.Name = "AIPoints";
            AIPoints.Size = new Size(50, 30);
            AIPoints.TabIndex = 4;
            AIPoints.Text = "AI :";
            // 
            // pointsTimer
            // 
            pointsTimer.Enabled = true;
            pointsTimer.Interval = 1;
            pointsTimer.Tick += pointsTimer_Tick;
            // 
            // NewGameButton
            // 
            NewGameButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NewGameButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewGameButton.ForeColor = Color.FromArgb(128, 128, 255);
            NewGameButton.Location = new Point(457, 646);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(94, 29);
            NewGameButton.TabIndex = 5;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nameBox.BackColor = SystemColors.GradientActiveCaption;
            nameBox.ForeColor = SystemColors.ActiveCaptionText;
            nameBox.Location = new Point(868, 489);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(125, 27);
            nameBox.TabIndex = 6;
            nameBox.KeyDown += nameBox_KeyDown;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.Highlight;
            nameLabel.Location = new Point(833, 447);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(180, 26);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Enter your name:";
            // 
            // Connect4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1050, 687);
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            Controls.Add(NewGameButton);
            Controls.Add(AIPoints);
            Controls.Add(UserPoints);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TheBoard);
            Name = "Connect4";
            Text = "Connect4Board";
            ((System.ComponentModel.ISupportInitialize)TheBoard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox TheBoard;
        private Label label1;
        private Label label2;
        private Label UserPoints;
        private Label AIPoints;
        private System.Windows.Forms.Timer pointsTimer;
        private Button NewGameButton;
        private TextBox nameBox;
        private Label nameLabel;
    }
}
