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

namespace MegaDesk_Watson
{
    public partial class AddQuote : Form
    {
        private int widthInput;
        private int depthInput;
        private int drawersInput;

        public AddQuote()
        {
            InitializeComponent();
        }

        private void closeAddQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Hide();
        }

        private void GetQuote_Click(object sender, EventArgs e)
        {
            Desk newDesk = new Desk();

            DeskQuote newQuote = new DeskQuote(newDesk);
            newQuote.Name = ($"{FirstName.Text} {LastName.Text}");
            newQuote.RushDays = Convert.ToInt32(RushInput.Text);

            // Assign validated inputs to the Desk object
            newDesk.Width = widthInput;
            newDesk.Depth = depthInput;

            newDesk.DrawerCount = drawersInput;


            if (Enum.TryParse(MaterialBox.Text, true, out DesktopMaterial material))
            {
                newDesk.DeskMaterial = material; // Set the material if valid
            }
            else
            {
                MessageBox.Show("Invalid material. Please enter a valid material name (e.g., Laminate, Oak, Rosewood, Veneer, Pine).");
            }

            // When creating the DisplayQuote form
            DisplayQuote displayQuote = new DisplayQuote(newQuote);
            displayQuote.Tag = this.Tag; // Assuming 'this' is the MainMenu instance
            displayQuote.Show();
            this.Hide();

        }
        private void Width_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Width.Text) || !int.TryParse(Width.Text, out widthInput) || widthInput < Desk.MINWIDTH || widthInput > Desk.MAXWIDTH)
            {
                Width.BackColor = Color.Red; // Change border color to red
                MessageBox.Show("Please choose a width between 24 and 96.");
                e.Cancel = true; // Prevent focus loss
            }
            else
            {
                Width.BackColor = Color.White; // Reset color on valid input
            }
        }

        private void Drawer_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Drawers.Text) || !int.TryParse(Drawers.Text, out drawersInput) || drawersInput < Desk.MINDRAWERS || drawersInput > Desk.MAXDRAWERS)
                {
                    Drawers.BackColor = Color.Red; // Change border color to red
                    MessageBox.Show("Please choose a number of drawers between 0 and 7.");
                    e.Cancel = true; // Prevent focus loss
                }
                else
                {
                    Drawers.BackColor = Color.White; // Reset color on valid input
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during validation: {ex.Message}");
                e.Cancel = true; // Prevent focus loss
            }
        }

        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is a control character or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress invalid input
            }
        }

        private void Depth_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Depth.Text) || !int.TryParse(Depth.Text, out depthInput) || depthInput < Desk.MINDEPTH || depthInput > Desk.MAXDEPTH)
            {
                Depth.BackColor = Color.Red; // Change border color to red
                MessageBox.Show("Please choose a depth between 12 and 48."); // Adjust as needed
                e.Cancel = true; // Prevent focus loss
            }
            else
            {
                Depth.BackColor = Color.White; // Reset color on valid input
            }
        }

    }
}