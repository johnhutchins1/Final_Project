using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_chap_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name.");

            }


            else
            {
                Form3 f3 = new Form3();
                f3.Show();
                Visible = false;

                f3.receiveData(txtName.Text);
            }
            
        }
















        private void btnRed_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
