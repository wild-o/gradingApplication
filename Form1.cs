using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradingapplicationproject
{
    public partial class Form1 : Form
    {
        int absencePoints = 0;
        string letterGrade = "";
        int projgrade = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtProjectgrade.Text.Trim() == "")
            {
                lblProjectgrade.ForeColor = Color.Red;
            }
            else
            {
                projgrade = Convert.ToInt16(txtProjectgrade.Text);
            }


            int assign1 = Convert.ToInt16(txtAssignment1.Text);
            int assign2 = Convert.ToInt16(txtAssignment2.Text);
            int assign3 = Convert.ToInt16(txtAssignment3.Text);
            int assign4 = Convert.ToInt16(txtAssignment4.Text);
            int exam1 = Convert.ToInt16(txtExam1.Text);
            int exam2 = Convert.ToInt16(txtExam2.Text);
            int absence = Convert.ToInt16(txtAbscenses.Text);

            if (absence <= 2)
            {
                absencePoints = 10;
            }
            else if (absence == 3)
            {
                absencePoints = 5;
            }

            double numGrade = (projgrade * .2) + (assign1 * .1) + (assign2 * .1) + (assign3 * .1) + (assign4 * .1) + (exam1 * .15) + (exam2 * .15) + absencePoints;
            txtFinalgrade.Text = numGrade.ToString();

            if (numGrade >= 90 && numGrade <= 100)
            {
                letterGrade = "A";
            }
            else if (numGrade >= 80 && numGrade < 90)
            {
                letterGrade = "B";
            }
            else if (numGrade >= 70 && numGrade < 80)
            {
                letterGrade = "C";
            }
            else if (numGrade >= 60 && numGrade < 70)
            {
                letterGrade = "D";
            }
            else if (numGrade < 60)
            {
                letterGrade = "You need help.";
            }
            txtLettergrade.Text = letterGrade;
        }

        private void txtAssignment1_TextChanged(object sender, EventArgs e)
        {
            if (txtAssignment1.Text == String.Empty)
            {
                txtAssignment1.Focus();
                txtAssignment1.BackColor = Color.Red;
            }
            else if (txtAssignment2.Text == String.Empty)
            {
                txtAssignment2.Focus();
                txtAssignment2.BackColor = Color.Red;

            }
            else if (txtAssignment3.Text == String.Empty)
            {
                txtAssignment3.Focus();
                txtAssignment3.BackColor = Color.Red;


            }
            else if (txtAssignment4.Text == String.Empty)
            {
                txtAssignment4.Focus();
                txtAssignment4.BackColor = Color.Red;

            }
            else if (txtExam1.Text == String.Empty)
            {
                txtExam1.Focus();
                txtExam1.BackColor = Color.Red;
            }
            else if (txtExam2.Text == String.Empty)
            {
                txtExam2.Focus();
                txtExam2.BackColor = Color.Red;
            }
            else if (txtAbscenses.Text == String.Empty)
            {
                txtAbscenses.Focus();
                txtAbscenses.BackColor = Color.Red;
            }
            else if (txtFinalgrade.Text == String.Empty)
            {
                txtFinalgrade.Focus();
                txtFinalgrade.BackColor = Color.Red;
            }
            else if (txtLettergrade.Text == String.Empty)
            {
                txtLettergrade.Focus();
                txtLettergrade.BackColor = Color.Red;
            }






        }
    }
}
