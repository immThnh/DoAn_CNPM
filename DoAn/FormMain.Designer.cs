using System.Drawing;
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
            this.btnBC = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBC
            // 
            this.btnBC.BackColor = System.Drawing.Color.Transparent;
            this.btnBC.FlatAppearance.BorderSize = 0;
            this.btnBC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnBC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBC.ForeColor = System.Drawing.Color.White;
            this.btnBC.Location = new System.Drawing.Point(979, 4);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(160, 60);
            this.btnBC.TabIndex = 3;
            this.btnBC.Text = "BÁO CÁO";
            this.btnBC.UseVisualStyleBackColor = false;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            this.btnBC.MouseEnter += new System.EventHandler(this.btnKM_MouseEnter);
            this.btnBC.MouseLeave += new System.EventHandler(this.btnKM_MouseLeave);
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Transparent;
            this.btnTK.FlatAppearance.BorderSize = 0;
            this.btnTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(813, 4);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(160, 60);
            this.btnTK.TabIndex = 2;
            this.btnTK.Text = "THỐNG KÊ";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.MouseEnter += new System.EventHandler(this.btnKM_MouseEnter);
            this.btnTK.MouseLeave += new System.EventHandler(this.btnKM_MouseLeave);
            // 
            // btnHD
            // 
            this.btnHD.BackColor = System.Drawing.Color.Transparent;
            this.btnHD.FlatAppearance.BorderSize = 0;
            this.btnHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.ForeColor = System.Drawing.Color.White;
            this.btnHD.Location = new System.Drawing.Point(661, 4);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(160, 60);
            this.btnHD.TabIndex = 1;
            this.btnHD.Text = "HÓA ĐƠN";
            this.btnHD.UseVisualStyleBackColor = false;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            this.btnHD.MouseEnter += new System.EventHandler(this.btnKM_MouseEnter);
            this.btnHD.MouseLeave += new System.EventHandler(this.btnKM_MouseLeave);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.BackColor = System.Drawing.Color.Transparent;
            this.btnGoiMon.FlatAppearance.BorderSize = 0;
            this.btnGoiMon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnGoiMon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnGoiMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiMon.ForeColor = System.Drawing.Color.White;
            this.btnGoiMon.Location = new System.Drawing.Point(279, 4);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(160, 60);
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
            this.pTop.Controls.Add(this.btnBC);
            this.pTop.Controls.Add(this.btnHD);
            this.pTop.Controls.Add(this.btnTK);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1589, 67);
            this.pTop.TabIndex = 2;
            // 
            // btnQLMA
            // 
            this.btnQLMA.BackColor = System.Drawing.Color.Transparent;
            this.btnQLMA.FlatAppearance.BorderSize = 0;
            this.btnQLMA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnQLMA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnQLMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMA.ForeColor = System.Drawing.Color.White;
            this.btnQLMA.Location = new System.Drawing.Point(451, 5);
            this.btnQLMA.Name = "btnQLMA";
            this.btnQLMA.Size = new System.Drawing.Size(204, 60);
            this.btnQLMA.TabIndex = 6;
            this.btnQLMA.Text = "QUẢN LÝ MÓN ĂN";
            this.btnQLMA.UseVisualStyleBackColor = false;
            this.btnQLMA.Click += new System.EventHandler(this.btnQLMA_Click);
            this.btnQLMA.MouseEnter += new System.EventHandler(this.btnKM_MouseEnter);
            this.btnQLMA.MouseLeave += new System.EventHandler(this.btnKM_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(117, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnKM
            // 
            this.btnKM.BackColor = System.Drawing.Color.Transparent;
            this.btnKM.FlatAppearance.BorderSize = 0;
            this.btnKM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnKM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.btnKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKM.ForeColor = System.Drawing.Color.White;
            this.btnKM.Location = new System.Drawing.Point(1145, 3);
            this.btnKM.Name = "btnKM";
            this.btnKM.Size = new System.Drawing.Size(160, 60);
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
            this.pMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMid.Location = new System.Drawing.Point(0, 67);
            this.pMid.Name = "pMid";
            this.pMid.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pMid.Size = new System.Drawing.Size(1589, 736);
            this.pMid.TabIndex = 3;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 803);
            this.Controls.Add(this.pMid);
            this.Controls.Add(this.pTop);
            this.Name = "FormMain";
            this.Text = "NHÀ HÀNG DOLA";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private Panel pTop;
        private Button btnGoiMon;
        private Button btnBC;
        private Button btnTK;
        private Button btnHD;
        private PictureBox pictureBox1;
        private Button btnKM;
        private Label label2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel pMid;
        private Button btnQLMA;
    }
}

