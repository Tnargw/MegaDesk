﻿using System;
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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void closeSearchQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
    }
}
