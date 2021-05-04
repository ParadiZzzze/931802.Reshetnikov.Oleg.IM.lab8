using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double a = rnd.NextDouble();
            if (a<0.5)
            {
                label1.Text = "Yes";
            }
            else
            {
                label1.Text = "No";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] answer_list = {"Yes", "No", "I don't know", "It is certain", "You may rely on it", "Outlook not so good", "Very doubtful", "Ask again later" };
            double p = 1.0/8.0;

            Random rnd = new Random();
            double A = rnd.NextDouble();
            int ans_id = 0;
            A -= p;

            while (A>0)
            {
                A -= p;               
                ans_id++;
            };

            label1.Text = answer_list[ans_id];
        }
    }
}
