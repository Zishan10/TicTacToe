namespace WinFormsApp1
{
    partial class TicTacToe
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.turnTextBox = new System.Windows.Forms.RichTextBox();
            this.playerWinTextBox = new System.Windows.Forms.RichTextBox();
            this.cpuWinTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resetGameButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.CPUTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player1  Symbol = \"X\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player2  Symbol = \"O\"";
            // 
            // turnTextBox
            // 
            this.turnTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.turnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.turnTextBox.Enabled = false;
            this.turnTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.turnTextBox.Location = new System.Drawing.Point(329, 52);
            this.turnTextBox.Name = "turnTextBox";
            this.turnTextBox.ReadOnly = true;
            this.turnTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.turnTextBox.Size = new System.Drawing.Size(133, 44);
            this.turnTextBox.TabIndex = 2;
            this.turnTextBox.Text = "";
            // 
            // playerWinTextBox
            // 
            this.playerWinTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.playerWinTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.playerWinTextBox.Enabled = false;
            this.playerWinTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerWinTextBox.Location = new System.Drawing.Point(334, 137);
            this.playerWinTextBox.Name = "playerWinTextBox";
            this.playerWinTextBox.ReadOnly = true;
            this.playerWinTextBox.Size = new System.Drawing.Size(63, 61);
            this.playerWinTextBox.TabIndex = 3;
            this.playerWinTextBox.Text = "";
            // 
            // cpuWinTextBox
            // 
            this.cpuWinTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.cpuWinTextBox.Enabled = false;
            this.cpuWinTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuWinTextBox.Location = new System.Drawing.Point(394, 137);
            this.cpuWinTextBox.Name = "cpuWinTextBox";
            this.cpuWinTextBox.ReadOnly = true;
            this.cpuWinTextBox.Size = new System.Drawing.Size(63, 61);
            this.cpuWinTextBox.TabIndex = 4;
            this.cpuWinTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(367, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "TURN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(334, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.YellowGreen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(394, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Player 2";
            // 
            // resetGameButton
            // 
            this.resetGameButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resetGameButton.Location = new System.Drawing.Point(350, 204);
            this.resetGameButton.Name = "resetGameButton";
            this.resetGameButton.Size = new System.Drawing.Size(88, 30);
            this.resetGameButton.TabIndex = 8;
            this.resetGameButton.Text = "Reset Game";
            this.resetGameButton.UseVisualStyleBackColor = false;
            this.resetGameButton.Click += new System.EventHandler(this.RestartGame);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playAgainButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playAgainButton.Location = new System.Drawing.Point(334, 240);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(112, 53);
            this.playAgainButton.TabIndex = 9;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 68);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 68);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 68);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 68);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(109, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 68);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(181, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 68);
            this.button6.TabIndex = 13;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(37, 184);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 68);
            this.button7.TabIndex = 18;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(109, 184);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 68);
            this.button8.TabIndex = 17;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(181, 184);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 68);
            this.button9.TabIndex = 16;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // CPUTimer
            // 
            this.CPUTimer.Interval = 1000;
            this.CPUTimer.Tick += new System.EventHandler(this.CPUmove);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 364);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.resetGameButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cpuWinTextBox);
            this.Controls.Add(this.playerWinTextBox);
            this.Controls.Add(this.turnTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox turnTextBox;
        private RichTextBox playerWinTextBox;
        private RichTextBox cpuWinTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button resetGameButton;
        private Button playAgainButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private System.Windows.Forms.Timer CPUTimer;
    }
}