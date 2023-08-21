using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc_Toe
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private string finalresult()
        {

            if((btn1.Text == "0" && btn2.Text == "0" && btn3.Text == "0") || (btn4.Text == "0" && btn5.Text == "0" && btn6.Text == "0") || (btn7.Text == "0" && btn8.Text == "0" && btn9.Text == "0") || (btn1.Text == "0" && btn4.Text == "0" && btn7.Text == "0") || (btn2.Text == "0" && btn5.Text == "0" && btn8.Text == "0") || (btn3.Text == "0" && btn6.Text == "0" && btn9.Text == "0") || (btn1.Text == "0" && btn5.Text == "0" && btn9.Text == "0") ||
              (btn3.Text == "0" && btn5.Text == "0" && btn7.Text == "0"))
            {
                return "Player 1 Won";
            }
            else if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X") || (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X") || (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X") || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") ||
              (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
            {
                return "Player 2 won";
            }
            return "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(btn1.Text == "" && result.Text=="")
            {
                btn1.Text = player1.Checked?"0":"X";
                if (player1.Checked)
                {
                    player1.Checked = false;
                    player2.Checked = true;
                }
                else
                {
                    player1.Checked = true;
                    player2.Checked = false;
                }
                result.Text = finalresult();
            }
        }

        private void player2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "" && result.Text == "")
            {
                btn2.Text = player1.Checked ? "0" : "X";
                if (player1.Checked)
                {
                    player1.Checked = false;
                    player2.Checked = true;
                }
                else
                {
                    player1.Checked = true;
                    player2.Checked = false;
                }
            }
            result.Text = finalresult();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "" && result.Text == "")
            {
                btn3.Text = player1.Checked ? "0" : "X";
                if (player1.Checked)
                {
                    player1.Checked = false;
                    player2.Checked = true;
                }
                else
                {
                    player1.Checked = true;
                    player2.Checked = false;
                }
                result.Text = finalresult();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "" && result.Text == "")
            {
                btn4.Text = player1.Checked ? "0" : "X";
                if (player1.Checked)
                {
                    player1.Checked = false;
                    player2.Checked = true;
                }
                else
                {
                    player1.Checked = true;
                    player2.Checked = false;
                }
                result.Text = finalresult();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "" && result.Text == "")
            {
                btn5.Text = player1.Checked ? "0" : "X";
                if (player1.Checked)
                {
                    player1.Checked = false;
                    player2.Checked = true;
                }
                else
                {
                    player1.Checked = true;
                    player2.Checked = false;
                }
                result.Text = finalresult();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "" && result.Text == "")
            {
                btn6.Text = player1.Checked ? "0" : "X";
                if (player1.Checked)
                {
                    player1.Checked = false;
                    player2.Checked = true;
                }
                else
                {
                    player1.Checked = true;
                    player2.Checked = false;
                }
                result.Text = finalresult();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "" && result.Text == "")
            {
                btn7.Text = player1.Checked ? "0" : "X";
                if (player1.Checked)
                {
                    player1.Checked = false;
                    player2.Checked = true;
                }
                else
                {
                    player1.Checked = true;
                    player2.Checked = false;
                }
                result.Text = finalresult();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "" && result.Text == "")
            {
                btn8.Text = player1.Checked ? "0" : "X";
                if (player1.Checked)
                {
                    player1.Checked = false;
                    player2.Checked = true;
                }
                else
                {
                    player1.Checked = true;
                    player2.Checked = false;
                }
                result.Text = finalresult();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "" && result.Text == "")
            {
                btn9.Text = player1.Checked ? "0" : "X";
                if (player1.Checked)
                {
                    player1.Checked = false;
                    player2.Checked = true;
                }
                else
                {
                    player1.Checked = true;
                    player2.Checked = false;
                }
                result.Text = finalresult();
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
