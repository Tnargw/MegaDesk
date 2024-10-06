using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Watson
{
    public partial class DisplayQuote : Form
    {
        internal DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            DisplayQuoteDetails(quote);
        }

        private void DisplayQuoteDetails(DeskQuote quote)
        {
            lblQuoteDate.Text = quote.QuoteDate.ToString("d");
            lblCustomerName.Text = quote.Name;
            lblMaterial.Text = quote._desk.DeskMaterial.ToString();
            lblWidth.Text = quote._desk.Width.ToString();
            lblDepth.Text = quote._desk.Depth.ToString();
            lblDrawers.Text = quote._desk.DrawerCount.ToString();
            lblTotal.Text = $"${quote.CalculateTotal()}"; // Implement total calculation
        }

        private void closeDisplayQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show(this);
            this.Hide();
        }
    }
}
