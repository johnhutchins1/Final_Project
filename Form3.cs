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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int VoteCountBlue;
        int VoteCountRed;



       



        private void btnRed_Click(object sender, EventArgs e)
        {
            VoteCountRed += 1;
            txtRed.Text = VoteCountRed.ToString();

            if (VoteCountRed > VoteCountBlue)
            {
                lblLead2.Text = "Red is winning";
            }
            else if (VoteCountBlue > VoteCountRed)
            {
                lblLead2.Text = "Blue is winning";
            }
            else
            {
                lblLead2.Text = "It is tied.";
            }



            lblLead2.Visible = true;


            int NumVoters = Convert.ToInt32(txtNumVoters.Text);

            if (VoteCountRed + VoteCountBlue == NumVoters)
            {
                MessageBox.Show("You have reached the voter limit!");
            }


        }

        internal void receiveData(string name)
        {
            lblName.Text = "Welcome " + (name) + "!";
        }

        
    private void btnBlue_Click(object sender, EventArgs e)
        {
            VoteCountBlue += 1;
            txtBlue.Text = VoteCountBlue.ToString();


            if (VoteCountRed > VoteCountBlue)
            {
                lblLead2.Text = "Red is winning";
            }
            else if (VoteCountBlue > VoteCountRed)
            {
                lblLead2.Text = "Blue is winning";
            }
            else
            {
                lblLead2.Text = "It is tied.";
            }


            lblLead2.Visible = true;

            int NumVoters = Convert.ToInt32(txtNumVoters.Text);

            if (VoteCountRed + VoteCountBlue == NumVoters)
            {
                MessageBox.Show("You have reached the voter limit!");
            }


        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            if (VoteCountRed > VoteCountBlue)
            {
                txtResults.Text = "Red is the Winner!";
                btnResults.BackColor = Color.Crimson;
            }
            else if (VoteCountBlue > VoteCountRed)
            {
                txtResults.Text = "Blue is the Winner!";
                btnResults.BackColor = Color.Blue;
            }
            else
            {
                txtResults.Text = "The winner is undecided.";
            }
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        private void txtNumVoters_TextChanged(object sender, EventArgs e)
        {
            

        }



        private void btnNumVoters_Click(object sender, EventArgs e)
        {

        }













        


       

        private void lblLead2_Click(object sender, EventArgs e)
        {

        }

    }
}
