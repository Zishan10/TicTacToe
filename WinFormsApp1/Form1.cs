namespace WinFormsApp1
{
    public partial class TicTacToe : Form
    {


        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;

        List<Button> buttons; 
        public TicTacToe()
        {
            InitializeComponent();
            RestartGame();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            turnTextBox.Text = "Player 2 [O]";
            var button  = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Aqua;
            buttons.Remove(button);
            CheckGame();
            CPUTimer.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            
            if(   button1.Text== "X" && button2.Text == "X" && button3.Text == "X" 
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
               )
            {
                CPUTimer.Stop();
                MessageBox.Show("Player 1 Wins");
                playerWinCount++;
                playerWinTextBox.Text = playerWinCount.ToString();
                RestartGame();
            }

            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
               || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
               || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
               || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
               || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
               || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
               || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
               || button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
               )
            {
                CPUTimer.Stop();
                MessageBox.Show("Player 2 Wins");
                CPUWinCount++;
                cpuWinTextBox.Text = CPUWinCount.ToString();
                RestartGame();
            }
            
        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor;
            }

            cpuWinTextBox.Text = CPUWinCount.ToString();
            playerWinTextBox.Text = playerWinCount.ToString();
        }

        private void CPUmove(object sender, EventArgs e)
        {
            if(buttons.Count >0)
            {
                turnTextBox.Text = "Player 1 [X]";
                int index =random.Next(buttons.Count);  
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Beige;
                buttons.RemoveAt(index);
                CheckGame();
                CPUTimer.Stop();

            }
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor; 
            }
         playerWinCount = 0;
         CPUWinCount = 0;
            cpuWinTextBox.Text = CPUWinCount.ToString();
            playerWinTextBox.Text = playerWinCount.ToString();
        }
    }
}