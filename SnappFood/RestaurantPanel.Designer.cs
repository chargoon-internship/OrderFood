﻿namespace SnappFood
{
    partial class RestaurantPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegisterMenu = new Button();
            btnEditMenu = new Button();
            btnViewInvoices = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRegisterMenu
            // 
            btnRegisterMenu.Font = new Font("IRANSansWeb(FaNum)", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisterMenu.Location = new Point(549, 141);
            btnRegisterMenu.Margin = new Padding(3, 4, 3, 4);
            btnRegisterMenu.Name = "btnRegisterMenu";
            btnRegisterMenu.Size = new Size(300, 130);
            btnRegisterMenu.TabIndex = 0;
            btnRegisterMenu.Text = "ثبت منوی جدید";
            btnRegisterMenu.UseVisualStyleBackColor = true;
            btnRegisterMenu.Click += btnRegisterMenu_Click;
            // 
            // btnEditMenu
            // 
            btnEditMenu.Font = new Font("IRANSansWeb(FaNum)", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditMenu.Location = new Point(549, 321);
            btnEditMenu.Name = "btnEditMenu";
            btnEditMenu.Size = new Size(300, 130);
            btnEditMenu.TabIndex = 1;
            btnEditMenu.Text = "ویرایش منو";
            btnEditMenu.UseVisualStyleBackColor = true;
            btnEditMenu.Click += btnEditMenu_Click;
            // 
            // btnViewInvoices
            // 
            btnViewInvoices.Font = new Font("IRANSansWeb(FaNum)", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewInvoices.Location = new Point(549, 502);
            btnViewInvoices.Name = "btnViewInvoices";
            btnViewInvoices.Size = new Size(300, 130);
            btnViewInvoices.TabIndex = 2;
            btnViewInvoices.Text = "مشاهده فاکتورها";
            btnViewInvoices.UseVisualStyleBackColor = true;
            btnViewInvoices.Click += btnViewInvoices_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("IRANSansWeb(FaNum)", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(29, 24);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(153, 45);
            button1.TabIndex = 3;
            button1.Text = "مشاهده پروفایل";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RestaurantPanel
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(1370, 749);
            Controls.Add(button1);
            Controls.Add(btnViewInvoices);
            Controls.Add(btnEditMenu);
            Controls.Add(btnRegisterMenu);
            Font = new Font("IRANSansWeb(FaNum)", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RestaurantPanel";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پنل رستوران";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisterMenu;
        private Button btnEditMenu;
        private Button btnViewInvoices;
        private Button button1;
    }
}