using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FolayanLab2 : Form
    {
        public FolayanLab2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();

        }

        private void picAby_Click(object sender, EventArgs e)
        {
            //comment 
            MessageBox.Show("I am not a picture freak person!\n\n I rarely take pictures. I am mostly reminded to snap. Laugh!!", "Abiodun Folayan");
            




        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //hide label and picbox
            lblText.Visible = false;
            picAby.Hide();
            //reset label to blank
            lblText.ResetText();
        }

        private void lblTopic_Click(object sender, EventArgs e)
        {
            
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //put answer in label and display
            lblText.Text = "I am Abiodun Folayan\n\n" + "The sixth child of my parents\n\n"
                + "I hail from Nigeria in West Africa\n\n" + "My favorite food is an african food called Pounded yam with egusi soup\n\n" + "I am 37 years old" +
                + "I am a loving and caring person with a possibility mindset";
            lblText.Visible = true;
            picAby.Hide();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //Show picture box
            picAby.Show();
            lblText.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare 2 local variables - ints
            int operand1, operand2;

            //declare answer as double
            double answer;

            //read from txtboxes, put into 2 ints - conversion required
            operand1 = Convert.ToInt32(txtNum.Text);
            operand2 = Convert.ToInt32(txtMultiplier.Text);

            //put operator in the label
            lblAnswer.Text = btnCalculate.Text;

            //do the math - must cast one of the operands
            answer = operand1 * (double)operand2;

            //display the answers - conversion required - formatting
            // format string: 1st character letter, second number
            lblAnswer.Text = answer.ToString("f1");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
          
            //reset label to blank
            lblAnswer.ResetText();
            txtNum.ResetText();
            txtMultiplier.ResetText();

            //put cursor in textbox and display
            txtNum.AcceptsReturn = true;
            

        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            //accept cursor
            txtNum.AcceptsReturn = true;
        }

        private void txtMultiplier_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
