using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGUI
{
    public partial class Form1 : Form
    {
        Random randomGenerator = new Random();
        int number;
        int remain = 7;
        
        public Form1()
        {
            InitializeComponent();
            number = randomGenerator.Next(1, 100);
            remainLabel.Text = Convert.ToString(remain);
            
        }

        private void geussButton_Click(object sender, EventArgs e)
        {
            resultLabel.ForeColor = Color.Black;
            remain--;
            remainLabel.Text = Convert.ToString(remain);
            if (remain != 0)
            {
                int input = int.Parse(textBox1.Text);
                if (input == number)
                {
                    resultLabel.Text = "You Win";
                    resultLabel.ForeColor = Color.Red;
                    remain = 7;
                }
                else if (input > number)
                {
                    resultLabel.Text = "You picked too High! Pick lower !";
                }
                else if (input < number)
                {
                    resultLabel.Text = "You picked too Low! Pick Higher ";
                }
            }
            else
            {
                resultLabel.Text = "Game Over, try again !!! ";
                resultLabel.ForeColor = Color.Red;
                remain = 7;
                
                // return;
            }
            textBox1.Text = string.Empty;
            textBox1.Focus();
            
        }
    }
}
