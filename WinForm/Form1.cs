using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Number;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NewGame();

        }
        GNumber v;
        int number;

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (v.Attempt(number))
                {
                    if (textBox1.Text != "")
                    {
                        number = int.Parse(textBox1.Text);

                        if (v.NumberEquals(number))
                        {
                            BeginGame("You won. ");
                        }
                        else

                        if (v.Correct(number))
                        {
                            if (v.Evaluation(number))
                            {
                                label1.Text = "More " + number + ". We have " + v.K + " attempt";
                            }

                            else
                            {
                                label1.Text = "Less " + number + ". We have  " + v.K + " attempt";
                            }
                        }
                        else
                        {
                            label1.Text = "You entered an incorrect number. enter from 1 to 100";
                        }
                    }
                }

                if (!v.Attempt(number))
                {
                    BeginGame("You lose. Number is " + v.Number);
                }
                
                textBox1.Clear();

            }
        }

        public void BeginGame(string s)
        {
            DialogResult result = MessageBox.Show(s + " Begin new Game?", "" , MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                NewGame();
            }
            else
            {
                Close();
            }
        }
        
        public void NewGame()
        {
            v = new GNumber();
            label1.Text = " Game: Guess the number. Guess a number between 1 and 100 and press Enter";
        }

        private void NewGamebutton(object sender, EventArgs e)
        {
         BeginGame("You don't finish the game.");
        }
    }
}
