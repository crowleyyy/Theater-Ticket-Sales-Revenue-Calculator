using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declare Variables to store the user input 
            int orchestraTickets = 0 , grandTierTickets = 0 , balconyTickets = 0;
            decimal orchestraRevenue = 0, grandTierRevenue = 0, balconyRevenue = 0, totalRevenue = 0;

            // Validate and user input
            if (int.TryParse(textBoxOrchestraTickets.Text, out orchestraTickets) &&
                int.TryParse(textBoxGrandTierTickets.Text, out grandTierTickets) &&
                int.TryParse(textBoxBalconyTickets.Text, out balconyTickets))

                // Calculate revenues based on ticket prices
                orchestraRevenue = orchestraTickets * 100.00m;  // Orchestra: $100
                grandTierRevenue = grandTierTickets * 75.00m; // Grand Tier: $75
                balconyRevenue = balconyTickets * 50.00m; // Balcony: $50
                totalRevenue = orchestraRevenue + grandTierRevenue + balconyRevenue;

            // Display results
            labelOrchestraRevenue.Text = orchestraRevenue.ToString("C");
            labelGrandTierRevenue.Text = grandTierRevenue.ToString("C");
            labelBalconyRevenue.Text = balconyRevenue.ToString("C");
            labelTotalRevenue.Text = totalRevenue.ToString("C");

            // Handle invalid input
            MessageBox.Show("Please enter valid numbers for all ticket quantities.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Clear all input TextBoxes
            textBoxOrchestraTickets.Clear();
            textBoxGrandTierTickets.Clear();
            textBoxBalconyTickets.Clear();

            // Clear all output Labels
            labelOrchestraRevenue.Text = string.Empty;
            labelGrandTierRevenue.Text = string.Empty;
            labelBalconyRevenue.Text = string.Empty;
            labelTotalRevenue.Text = string.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
