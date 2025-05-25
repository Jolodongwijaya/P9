﻿namespace SistemManajemenTokoEmas
{
    partial class Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProNameCb = new System.Windows.Forms.ComboBox();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProQuanTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logoutlbl = new System.Windows.Forms.Label();
            this.Billlbl = new System.Windows.Forms.Label();
            this.Productlbl = new System.Windows.Forms.Label();
            this.Customerlbl = new System.Windows.Forms.Label();
            this.CusIdCb = new System.Windows.Forms.ComboBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BillDgv = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BillIdTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UPTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductDgv = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ProNameCb
            // 
            this.ProNameCb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProNameCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNameCb.FormattingEnabled = true;
            this.ProNameCb.Items.AddRange(new object[] {
            "Cincin",
            "Kalung",
            "Anting",
            "Gelang",
            "Lionton",
            "Bross ",
            "Aksesoris lainnya"});
            this.ProNameCb.Location = new System.Drawing.Point(48, 309);
            this.ProNameCb.Name = "ProNameCb";
            this.ProNameCb.Size = new System.Drawing.Size(279, 28);
            this.ProNameCb.TabIndex = 27;
            // 
            // PriceTb
            // 
            this.PriceTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTb.Location = new System.Drawing.Point(47, 652);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(279, 28);
            this.PriceTb.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total Harga";
            // 
            // ProQuanTb
            // 
            this.ProQuanTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProQuanTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProQuanTb.Location = new System.Drawing.Point(48, 520);
            this.ProQuanTb.Name = "ProQuanTb";
            this.ProQuanTb.Size = new System.Drawing.Size(279, 28);
            this.ProQuanTb.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Jumlah (gram)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Logoutlbl);
            this.panel2.Controls.Add(this.Billlbl);
            this.panel2.Controls.Add(this.Productlbl);
            this.panel2.Controls.Add(this.Customerlbl);
            this.panel2.Location = new System.Drawing.Point(438, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 72);
            this.panel2.TabIndex = 27;
            // 
            // Logoutlbl
            // 
            this.Logoutlbl.AutoSize = true;
            this.Logoutlbl.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutlbl.ForeColor = System.Drawing.Color.White;
            this.Logoutlbl.Location = new System.Drawing.Point(574, 11);
            this.Logoutlbl.Name = "Logoutlbl";
            this.Logoutlbl.Size = new System.Drawing.Size(108, 38);
            this.Logoutlbl.TabIndex = 15;
            this.Logoutlbl.Text = "Logout";
            this.Logoutlbl.Click += new System.EventHandler(this.Logoutlbl_Click);
            // 
            // Billlbl
            // 
            this.Billlbl.AutoSize = true;
            this.Billlbl.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billlbl.ForeColor = System.Drawing.Color.White;
            this.Billlbl.Location = new System.Drawing.Point(388, 11);
            this.Billlbl.Name = "Billlbl";
            this.Billlbl.Size = new System.Drawing.Size(115, 38);
            this.Billlbl.TabIndex = 14;
            this.Billlbl.Text = "Tagihan";
            // 
            // Productlbl
            // 
            this.Productlbl.AutoSize = true;
            this.Productlbl.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productlbl.ForeColor = System.Drawing.Color.White;
            this.Productlbl.Location = new System.Drawing.Point(203, 11);
            this.Productlbl.Name = "Productlbl";
            this.Productlbl.Size = new System.Drawing.Size(108, 38);
            this.Productlbl.TabIndex = 13;
            this.Productlbl.Text = "Produk";
            this.Productlbl.Click += new System.EventHandler(this.Productlbl_Click);
            // 
            // Customerlbl
            // 
            this.Customerlbl.AutoSize = true;
            this.Customerlbl.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerlbl.ForeColor = System.Drawing.Color.White;
            this.Customerlbl.Location = new System.Drawing.Point(3, 11);
            this.Customerlbl.Name = "Customerlbl";
            this.Customerlbl.Size = new System.Drawing.Size(150, 38);
            this.Customerlbl.TabIndex = 12;
            this.Customerlbl.Text = "Pelanggan";
            this.Customerlbl.Click += new System.EventHandler(this.Customerlbl_Click);
            // 
            // CusIdCb
            // 
            this.CusIdCb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CusIdCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusIdCb.FormattingEnabled = true;
            this.CusIdCb.Location = new System.Drawing.Point(48, 377);
            this.CusIdCb.Name = "CusIdCb";
            this.CusIdCb.Size = new System.Drawing.Size(279, 28);
            this.CusIdCb.TabIndex = 28;
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(651, 635);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(110, 40);
            this.ResetBtn.TabIndex = 32;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(450, 635);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 40);
            this.AddBtn.TabIndex = 29;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BillDgv
            // 
            this.BillDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BillDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDgv.EnableHeadersVisualStyles = false;
            this.BillDgv.Location = new System.Drawing.Point(403, 454);
            this.BillDgv.Name = "BillDgv";
            this.BillDgv.RowHeadersWidth = 62;
            this.BillDgv.RowTemplate.Height = 28;
            this.BillDgv.Size = new System.Drawing.Size(812, 159);
            this.BillDgv.TabIndex = 28;
            this.BillDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillDgv_CellContentClick);
            this.BillDgv.DoubleClick += new System.EventHandler(this.BillDgv_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(43, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 32);
            this.label9.TabIndex = 21;
            this.label9.Text = "Id Pelanggan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(43, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Produk";
            // 
            // BillIdTb
            // 
            this.BillIdTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIdTb.Location = new System.Drawing.Point(49, 243);
            this.BillIdTb.Name = "BillIdTb";
            this.BillIdTb.Size = new System.Drawing.Size(279, 28);
            this.BillIdTb.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id Tagihan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(133, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 38);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tagihan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.UPTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CustNameTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CusIdCb);
            this.panel1.Controls.Add(this.ProNameCb);
            this.panel1.Controls.Add(this.PriceTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProQuanTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BillIdTb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 741);
            this.panel1.TabIndex = 25;
            // 
            // UPTb
            // 
            this.UPTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UPTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPTb.Location = new System.Drawing.Point(47, 586);
            this.UPTb.Name = "UPTb";
            this.UPTb.Size = new System.Drawing.Size(279, 28);
            this.UPTb.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 32);
            this.label5.TabIndex = 34;
            this.label5.Text = "Harga per unit";
            // 
            // CustNameTb
            // 
            this.CustNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.Location = new System.Drawing.Point(47, 454);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(279, 28);
            this.CustNameTb.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 32);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nama Pelanggan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(718, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tagihan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(725, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 32);
            this.label11.TabIndex = 34;
            this.label11.Text = "Produk";
            // 
            // ProductDgv
            // 
            this.ProductDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDgv.EnableHeadersVisualStyles = false;
            this.ProductDgv.Location = new System.Drawing.Point(403, 242);
            this.ProductDgv.Name = "ProductDgv";
            this.ProductDgv.RowHeadersWidth = 62;
            this.ProductDgv.RowTemplate.Height = 28;
            this.ProductDgv.Size = new System.Drawing.Size(812, 153);
            this.ProductDgv.TabIndex = 35;
            this.ProductDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDgv_CellContentClick);
            this.ProductDgv.DoubleClick += new System.EventHandler(this.ProductDgv_DoubleClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Red;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(846, 635);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(110, 40);
            this.UpdateBtn.TabIndex = 36;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(1049, 635);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(110, 40);
            this.DelBtn.TabIndex = 37;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1515, 741);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ProductDgv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.BillDgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ProNameCb;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProQuanTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Logoutlbl;
        private System.Windows.Forms.Label Billlbl;
        private System.Windows.Forms.Label Productlbl;
        private System.Windows.Forms.Label Customerlbl;
        private System.Windows.Forms.ComboBox CusIdCb;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView BillDgv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BillIdTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UPTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView ProductDgv;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}