using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe.Properties;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        stGameStatus GameStatus;
        enPlayer playerTurn = enPlayer.player1;
       enum enPlayer
        {
            player1,player2
        }
        enum enWinner
        {
            player1,player2,Draw,GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        public bool ChecksValues(Button btn1,Button btn2,Button btn3)
        {
            if (btn1.Tag.ToString()!="?"&&btn1.Tag.ToString()==btn2.Tag.ToString()&&btn1.Tag.ToString()== btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString()=="X")
                {
                    GameStatus.Winner = enWinner.player1;
                    GameStatus.GameOver = true;

                    EndGame();
                    return true;
                }

                else
                {
                    GameStatus.Winner = enWinner.player2;
                    GameStatus.GameOver = true;

                    EndGame();
                    return true;
                }
            }
            GameStatus.GameOver = false;
            return false;
        }
        void EndGame()
        {
            lb_Turn.Text = "Game Over";
            switch(GameStatus.Winner)
            {
                case  enWinner.player1: 
                    lb_Winner.Text = "Player1";
                    break;
                case enWinner.player2:
                    lb_Winner.Text = "Player2";
                    break;
                default:
                    lb_Winner.Text = "Draw";
                    break;
            }
            MessageBox.Show("GameOver", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CheckWinner()
        {
            if (ChecksValues(button1, button2, button3))
                return;
            if (ChecksValues(button4, button5, button6))
                return;
            if (ChecksValues(button7, button8, button9))
                return;
            if(ChecksValues(button1, button4,button7))
                return;
            if(ChecksValues(button2,button5,button8))
                return;
            

            if (ChecksValues(button3, button6, button9))
                return;
         
            if (ChecksValues(button1, button5, button9))
                return;

            //check Diagonal2
            if (ChecksValues(button3, button5, button7))
                return;
        }
        void ChangePhoto(Button buttonName)
        {
            if (buttonName.Tag.ToString()=="?")
            {
                switch(playerTurn)
                {
                    case enPlayer.player1:
                        buttonName.Image = Resources.X1;
                        playerTurn= enPlayer.player2;
                        lb_Turn.Text = "Player2";
                        GameStatus.PlayCount++;
                        buttonName.Tag = "X";
                        CheckWinner();
                        break;


                    case  enPlayer.player2:
                        buttonName.Image = Resources.O1;
                        playerTurn = enPlayer.player1;
                        lb_Turn.Text = "Player1";
                        GameStatus.PlayCount++;
                        buttonName.Tag = "O";
                        CheckWinner();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (GameStatus.PlayCount==9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }
        private void RestButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }
      private void RestartGame()
        {
            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);
            playerTurn = enPlayer.player1;
            lb_Turn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lb_Winner.Text = "In Progress";

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.Black;
            Pen pen = new Pen(Black);
            pen.Width = 14;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 120, 180, 510, 180);
            e.Graphics.DrawLine(pen, 120, 300, 510, 300);
            e.Graphics.DrawLine(pen, 240, 390, 240, 100);
            e.Graphics.DrawLine(pen, 400, 390, 400, 100);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pb_Background;
            label1.BackColor = Color.Transparent;

            label10.Parent=pb_Background;
            label10.BackColor = Color.Transparent;


            label11.Parent = pb_Background;
            label11.BackColor = Color.Transparent;

            lb_Winner.Parent = pb_Background;
            lb_Winner.BackColor = Color.Transparent;

            lb_Turn.Parent = pb_Background;
            lb_Turn.BackColor = Color.Transparent;
        }

       
        private void button_Click(object sender, EventArgs e)
        {
            ChangePhoto((Button)sender);
        }

        

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }


    }
}
