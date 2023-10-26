using System.Windows.Forms;

namespace DoAn
{
    partial class FormKhuyeMai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tNoiDung = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clbMonAn = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhatThem = new System.Windows.Forms.Button();
            this.tMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.tTenKhuyenMai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cDanhMuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cGiamGia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhuyenMai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(54)))));
            this.dgvKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colDanhMuc,
            this.colMonAn,
            this.colGiamGia,
            this.colNoiDung});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhuyenMai.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhuyenMai.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKhuyenMai.Location = new System.Drawing.Point(10, 382);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.ReadOnly = true;
            this.dgvKhuyenMai.RowHeadersWidth = 51;
            this.dgvKhuyenMai.RowTemplate.Height = 40;
            this.dgvKhuyenMai.RowTemplate.ReadOnly = true;
            this.dgvKhuyenMai.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhuyenMai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(1362, 145);
            this.dgvKhuyenMai.TabIndex = 2;
            this.dgvKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuyenMai_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 80;
            // 
            // colName
            // 
            this.colName.HeaderText = "Khuyến Mãi";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colDanhMuc
            // 
            this.colDanhMuc.HeaderText = "Danh Mục";
            this.colDanhMuc.MinimumWidth = 6;
            this.colDanhMuc.Name = "colDanhMuc";
            this.colDanhMuc.ReadOnly = true;
            this.colDanhMuc.Width = 160;
            // 
            // colMonAn
            // 
            this.colMonAn.HeaderText = "Món Ăn";
            this.colMonAn.MinimumWidth = 6;
            this.colMonAn.Name = "colMonAn";
            this.colMonAn.ReadOnly = true;
            this.colMonAn.Width = 200;
            // 
            // colGiamGia
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.colGiamGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colGiamGia.HeaderText = "Giảm Giá";
            this.colGiamGia.MinimumWidth = 6;
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.ReadOnly = true;
            this.colGiamGia.Width = 200;
            // 
            // colNoiDung
            // 
            this.colNoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNoiDung.HeaderText = "Nội Dung";
            this.colNoiDung.MinimumWidth = 6;
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 372);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.tNoiDung);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.clbMonAn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(618, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 343);
            this.panel1.TabIndex = 22;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(82)))));
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(386, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(186, 34);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // tNoiDung
            // 
            this.tNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tNoiDung.Location = new System.Drawing.Point(183, 154);
            this.tNoiDung.Name = "tNoiDung";
            this.tNoiDung.Size = new System.Drawing.Size(389, 80);
            this.tNoiDung.TabIndex = 8;
            this.tNoiDung.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nội dung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Món ăn";
            // 
            // clbMonAn
            // 
            this.clbMonAn.FormattingEnabled = true;
            this.clbMonAn.Location = new System.Drawing.Point(183, 15);
            this.clbMonAn.Name = "clbMonAn";
            this.clbMonAn.Size = new System.Drawing.Size(389, 104);
            this.clbMonAn.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnCapNhatThem);
            this.panel2.Controls.Add(this.tMaKhuyenMai);
            this.panel2.Controls.Add(this.tTenKhuyenMai);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cDanhMuc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cGiamGia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 343);
            this.panel2.TabIndex = 23;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(82)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(394, 272);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(186, 34);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhatThem
            // 
            this.btnCapNhatThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(82)))));
            this.btnCapNhatThem.FlatAppearance.BorderSize = 0;
            this.btnCapNhatThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatThem.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatThem.Location = new System.Drawing.Point(138, 272);
            this.btnCapNhatThem.Name = "btnCapNhatThem";
            this.btnCapNhatThem.Size = new System.Drawing.Size(186, 34);
            this.btnCapNhatThem.TabIndex = 4;
            this.btnCapNhatThem.Text = "Cập Nhật / Thêm";
            this.btnCapNhatThem.UseVisualStyleBackColor = false;
            this.btnCapNhatThem.Click += new System.EventHandler(this.btnCapNhatThem_Click);
            // 
            // tMaKhuyenMai
            // 
            this.tMaKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tMaKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMaKhuyenMai.Location = new System.Drawing.Point(295, 19);
            this.tMaKhuyenMai.Name = "tMaKhuyenMai";
            this.tMaKhuyenMai.Size = new System.Drawing.Size(285, 27);
            this.tMaKhuyenMai.TabIndex = 20;
            this.tMaKhuyenMai.TextChanged += new System.EventHandler(this.tMaKhuyenMai_TextChanged);
            // 
            // tTenKhuyenMai
            // 
            this.tTenKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tTenKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTenKhuyenMai.Location = new System.Drawing.Point(295, 81);
            this.tTenKhuyenMai.Name = "tTenKhuyenMai";
            this.tTenKhuyenMai.Size = new System.Drawing.Size(285, 27);
            this.tTenKhuyenMai.TabIndex = 9;
            this.tTenKhuyenMai.TextChanged += new System.EventHandler(this.tTenKhuyenMai_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã khuyến mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khuyến mãi";
            // 
            // cDanhMuc
            // 
            this.cDanhMuc.BackColor = System.Drawing.Color.LightGray;
            this.cDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDanhMuc.FormattingEnabled = true;
            this.cDanhMuc.Location = new System.Drawing.Point(295, 210);
            this.cDanhMuc.Name = "cDanhMuc";
            this.cDanhMuc.Size = new System.Drawing.Size(285, 28);
            this.cDanhMuc.TabIndex = 18;
            this.cDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cDanhMuc_SelectedIndexChanged);
            this.cDanhMuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tGiamGia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giảm giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Danh Mục";
            // 
            // cGiamGia
            // 
            this.cGiamGia.BackColor = System.Drawing.Color.LightGray;
            this.cGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cGiamGia.FormattingEnabled = true;
            this.cGiamGia.Location = new System.Drawing.Point(295, 144);
            this.cGiamGia.Name = "cGiamGia";
            this.cGiamGia.Size = new System.Drawing.Size(285, 28);
            this.cGiamGia.TabIndex = 16;
            this.cGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tGiamGia_KeyPress);
            // 
            // FormKhuyeMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1382, 537);
            this.Controls.Add(this.dgvKhuyenMai);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKhuyeMai";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "QUẢN LÝ KHUYỂN MÃI";
            this.Load += new System.EventHandler(this.FormKhuyeMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKhuyenMai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhatThem;
        private System.Windows.Forms.CheckedListBox clbMonAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tTenKhuyenMai;
        private System.Windows.Forms.RichTextBox tNoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cDanhMuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cGiamGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tMaKhuyenMai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDanhMuc;
        private DataGridViewTextBoxColumn colMonAn;
        private DataGridViewTextBoxColumn colGiamGia;
        private DataGridViewTextBoxColumn colNoiDung;
    }
}