﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayes;
using Entities;

namespace SnappFood
{
    public partial class RestaurantInvoice : Form
    {
        ViewInvoice v = new ViewInvoice();

        public RestaurantInvoice()
        {
            InitializeComponent();
        }

        private void RestaurantInvoice_Load(object sender, EventArgs e)
        {
            var orders = v.PrintInvoices(2);
            resInvoiceDataGridView.DataSource = orders;

            var totalAmount = v.PrintInvoices(2).Sum(o => o.FinalPrice);
            lblAmountsSum2.Text = totalAmount.ToString();

            resInvoiceDataGridView.Columns["Id"].Visible = false;

            resInvoiceDataGridView.Columns["Customer_Id"].Visible = false;
            resInvoiceDataGridView.Columns["CartItem_Id"].Visible = false;
            resInvoiceDataGridView.Columns["Restaurant_Id"].Visible = false;

            resInvoiceDataGridView.Columns["Customer"].Visible = false;
            resInvoiceDataGridView.Columns["CartItem"].Visible = false;
            resInvoiceDataGridView.Columns["Restaurant"].Visible = false;
        }

        private void lblAmountsSum1_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RestaurantPanel f = new RestaurantPanel();
            f.FormClosed += (s, args) => this.Close();
            f.Show();
            this.Hide();
        }
    }
}
