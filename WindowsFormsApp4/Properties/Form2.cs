using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Properties
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e, Form3 form3)
        {
            
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string first2 = textBox2.Text;

            string correct = "moiz";
            string correct1 = "111";
            string message = "error";
            string topic = "choose";

            if (first == correct && first2 == correct1)
            {


                this.Hide();
                Form3 formshow = new Form3();
                formshow.ShowDialog();

            }
            else
            {
                MessageBox.Show(message, topic, MessageBoxButtons.OK);
            }
        }
    }
}
