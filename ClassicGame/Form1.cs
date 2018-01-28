using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool play { get; set; } = true;
        private void btn9_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (play == true)
            {
                writeName(btn.Name, "O");
                bool result = checkCondition("O");
                if(result == true)
                {
                    MessageBox.Show(label1.Text + " Win!!!!");
                    DialogResult dg = MessageBox.Show("Do you want to play Again?","Game Over!", MessageBoxButtons.YesNo);
                    if(dg == DialogResult.Yes)
                    {
                        foreach (Control x in this.Controls)
                        {
                            if (x is Button)
                            {
                                x.Enabled = true;
                                x.Text = "";
                            }
                        }

                        button1.Text = "New Game";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    play = false;
                    label1.Text = "Player 2";
                }
            }
            else
            {
                writeName(btn.Name, "X");
                bool result = checkCondition("X");
                if(result == true)
                {
                    MessageBox.Show(label1.Text + " Win!!!!");
                    DialogResult dg = MessageBox.Show("Do you want to play Again?", "Game Over!", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        foreach(Control x in this.Controls)
                        {
                            if(x is Button)
                            {
                                x.Enabled = true;
                                x.Text = "";
                            }
                        }
                        button1.Text = "New Game";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    play = true;
                    label1.Text = "Player 1";
                }
            }
        }

        public bool checkCondition(string text)
        {
            bool check = false;
            
                if ((btn1.Text == text && btn2.Text == text && btn3.Text == text) || (btn4.Text == text && btn5.Text == text && btn6.Text == text) || (btn7.Text == text && btn8.Text == text && btn9.Text == text))
                {
                    check = true;
                    //MessageBox.Show(label1.Text + " Win!!!!");
                }
                if ((btn1.Text == text && btn4.Text == text && btn7.Text == text) || (btn2.Text == text && btn5.Text == text && btn8.Text == text) || (btn3.Text == text && btn6.Text == text && btn9.Text == text))
                {
                    check = true;
                    //MessageBox.Show(label1.Text + " Win!!!!");
                }
                if ((btn1.Text == text && btn5.Text == text && btn9.Text == text) || (btn3.Text == text && btn5.Text == text && btn7.Text == text))
                {
                    check = true;
                    //MessageBox.Show(label1.Text + " Win!!!!");
                }                   

            return check;
        }

        public void writeName(string name, string text)
        {
            switch (name)
            {
                case "btn1":
                    btn1.Text = text;
                    btn1.Enabled = false;
                    break;
                case "btn2":
                    btn2.Text = text;
                    btn2.Enabled = false;
                    break;
                case "btn3":
                    btn3.Text = text;
                    btn3.Enabled = false;
                    break;
                case "btn4":
                    btn4.Text = text;
                    btn4.Enabled = false;
                    break;
                case "btn5":
                    btn5.Text = text;
                    btn5.Enabled = false;
                    break;
                case "btn6":
                    btn6.Text = text;
                    btn6.Enabled = false;
                    break;
                case "btn7":
                    btn7.Text = text;
                    btn7.Enabled = false;
                    break;
                case "btn8":
                    btn8.Text = text;
                    btn8.Enabled = false;
                    break;
                case "btn9":
                    btn9.Text = text;
                    btn9.Enabled = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to play Again?", "Game Over!", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is Button)
                    {
                        x.Enabled = true;
                        x.Text = "";
                    }
                }
                button1.Text = "New Game";
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 1100;
            this.Width = 1200;
        }
    }
}
