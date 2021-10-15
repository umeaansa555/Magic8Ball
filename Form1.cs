using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer;
            answer = randGen.Next(1, 7);
           

            switch (answer)
            {
                case 1:
                    outputLabel.Text = "It is certain.";
                    break;
                case 2:
                    outputLabel.Text = "It is decidedly so.";
                    break;
                case 3:
                    outputLabel.Text = "Reply hazy, try again.";
                    break;
                case 4:
                    outputLabel.Text = "Ask again later.";
                    break;
                case 5:
                    outputLabel.Text = "Don't count on it.";
                    break;
                case 6:
                    outputLabel.Text = "Outlook not so good.";
                    break;
            }


        }   
    }
}
