//This is my own work
//Ivan Rivas
//This is In Class Assignment 3
//1/25/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_ClassAssignment3
{
    public partial class HumanWeightToCancri55e : Form
    {
        public HumanWeightToCancri55e()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            //Get weight from weight on earth text box
            string strWeightEarth = txtbox_WeightOnEarth.Text;

            //Convert weight to number
            int Weight = int.Parse(strWeightEarth);

            //Convert weight on Earth to weight on Cancri 55 e
            double WeightCancri55e = Weight * 8.75;

            //Display weight on Cancri 55 e
            txtbox_WeightOnCancri55e.Text = WeightCancri55e.ToString();

        }
    }
}
