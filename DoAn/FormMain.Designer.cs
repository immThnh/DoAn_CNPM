﻿using System.Drawing;
using System.Windows.Forms;

namespace DoAn
{
    partial class FormMain
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.pTop = new System.Windows.Forms.Panel();
            this.btnQLMA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pMid = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHD
            // 
            this.btnHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHD.BackColor = System.Drawing.Color.Transparent;
            this.btnHD.FlatAppearance.BorderSize = 0;
            this.btnHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.ForeColor = System.Drawing.Color.White;
            this.btnHD.Location = new System.Drawing.Point(631, 2);
            this.btnHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(120, 49);
            this.btnHD.TabIndex = 1;
            this.btnHD.Text = "THỐNG KẾ";
            this.btnHD.UseVisualStyleBackColor = false;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            this.btnHD.MouseEnter += new System.EventHandler(this.btnKM_MouseEnter);
            this.btnHD.MouseLeave += new System.EventHandler(this.btnKM_MouseLeave);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoiMon.BackColor = System.Drawing.Color.Transparent;
            this.btnGoiMon.FlatAppearance.BorderSize = 0;
            this.btnGoiMon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnGoiMon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnGoiMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiMon.ForeColor = System.Drawing.Color.White;
            this.btnGoiMon.Location = new System.Drawing.Point(348, 2);
            this.btnGoiMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(120, 49);
            this.btnGoiMon.TabIndex = 0;
            this.btnGoiMon.Text = "GỌI MÓN";
            this.btnGoiMon.UseVisualStyleBackColor = false;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            this.btnGoiMon.MouseEnter += new System.EventHandler(this.btnKM_MouseEnter);
            this.btnGoiMon.MouseLeave += new System.EventHandler(this.btnKM_MouseLeave);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.pTop.Controls.Add(this.btnQLMA);
            this.pTop.Controls.Add(this.pictureBox1);
            this.pTop.Controls.Add(this.btnKM);
            this.pTop.Controls.Add(this.btnGoiMon);
            this.pTop.Controls.Add(this.btnHD);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1155, 54);
            this.pTop.TabIndex = 2;
            // 
            // btnQLMA
            // 
            this.btnQLMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQLMA.BackColor = System.Drawing.Color.Transparent;
            this.btnQLMA.FlatAppearance.BorderSize = 0;
            this.btnQLMA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnQLMA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnQLMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMA.ForeColor = System.Drawing.Color.White;
            this.btnQLMA.Location = new System.Drawing.Point(473, 3);
            this.btnQLMA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLMA.Name = "btnQLMA";
            this.btnQLMA.Size = new System.Drawing.Size(153, 49);
            this.btnQLMA.TabIndex = 6;
            this.btnQLMA.Text = "QUẢN LÝ MÓN ĂN";
            this.btnQLMA.UseVisualStyleBackColor = false;
            this.btnQLMA.Click += new System.EventHandler(this.btnQLMA_Click);
            this.btnQLMA.MouseEnter += new System.EventHandler(this.btnKM_MouseEnter);
            this.btnQLMA.MouseLeave += new System.EventHandler(this.btnKM_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DoAn.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(223, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnKM
            // 
            this.btnKM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKM.BackColor = System.Drawing.Color.Transparent;
            this.btnKM.FlatAppearance.BorderSize = 0;
            this.btnKM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnKM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKM.ForeColor = System.Drawing.Color.White;
            this.btnKM.Location = new System.Drawing.Point(744, 2);
            this.btnKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKM.Name = "btnKM";
            this.btnKM.Size = new System.Drawing.Size(120, 49);
            this.btnKM.TabIndex = 4;
            this.btnKM.Text = "KHUYẾN MÃI";
            this.btnKM.UseVisualStyleBackColor = false;
            this.btnKM.Click += new System.EventHandler(this.btnKM_Click);
            this.btnKM.MouseEnter += new System.EventHandler(this.btnKM_MouseEnter);
            this.btnKM.MouseLeave += new System.EventHandler(this.btnKM_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(26, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "200.000 VND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(58, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cá thịt";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(82)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.button1.Location = new System.Drawing.Point(30, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "CHỌN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pMid
            // 
            this.pMid.AutoScroll = true;
            this.pMid.AutoSize = true;
            this.pMid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(54)))));
            this.pMid.BackgroundImage = global::DoAn.Properties.Resources.backgournd;
            this.pMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMid.Controls.Add(this.label4);
            this.pMid.Controls.Add(this.label3);
            this.pMid.Controls.Add(this.btnXoaHoaDon);
            this.pMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMid.Location = new System.Drawing.Point(0, 54);
            this.pMid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pMid.Name = "pMid";
            this.pMid.Size = new System.Drawing.Size(1155, 598);
            this.pMid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(495, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 29);
            this.label4.TabIndex = 92;
            this.label4.Text = "Món ăn đa dạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(393, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 57);
            this.label3.TabIndex = 91;
            this.label3.Text = "4TL RESTUARANT";
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(82)))));
            this.btnXoaHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaHoaDon.FlatAppearance.BorderSize = 0;
            this.btnXoaHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXoaHoaDon.Location = new System.Drawing.Point(503, 292);
            this.btnXoaHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(169, 58);
            this.btnXoaHoaDon.TabIndex = 90;
            this.btnXoaHoaDon.Text = "ĐẶT MÓN MGAY";
            this.btnXoaHoaDon.UseVisualStyleBackColor = false;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::DoAn.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 652);
            this.Controls.Add(this.pMid);
            this.Controls.Add(this.pTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "NHÀ HÀNG DOLA";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pMid.ResumeLayout(false);
            this.pMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private Panel pTop;
        private Button btnGoiMon;
        private Button btnHD;
        private PictureBox pictureBox1;
        private Button btnKM;
        private Label label2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel pMid;
        private Button btnQLMA;
        private Button btnXoaHoaDon;
        private Label label3;
        private Label label4;
    }
}

