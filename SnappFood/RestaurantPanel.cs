﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnappTest
{
    public partial class RestaurantPanel : Form
    {
        public RestaurantPanel()
        {
            InitializeComponent();
        }

        private void RestaurantPanel_Load(object sender, EventArgs e)
        {

        }

        private void ViewInvoices_Click(object sender, EventArgs e)
        {
            RestaurantInvoice f = new RestaurantInvoice();
            f.ShowDialog(); // Shows RestaurantInvoice form
        }
    }
}
