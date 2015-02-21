using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KineticEnergy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // declare variables
                double mass;
                double velocity;
                double kineticenergy;
                // get variable values from text boxes
                mass = double.Parse(massBox.Text);
                velocity = double.Parse(velocityBox.Text);
                // calculate kinetic energy
                kineticenergy = 0.5 * (mass * Math.Pow(velocity,2));
                // output to outputLabel
                outputLabel.Text = kineticenergy.ToString("n2"); 
            }
            
            catch (Exception ex)
            {
                // show messagebox on exception
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear all text
            outputLabel.Text = String.Empty;
            massBox.Text = String.Empty;
            velocityBox.Text = String.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
