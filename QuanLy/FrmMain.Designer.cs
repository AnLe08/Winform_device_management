namespace QuanLy
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnThietBi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMuon = new System.Windows.Forms.Button();
            this.btnQLMuonTra = new System.Windows.Forms.Button();
            this.btnBaoTri = new System.Windows.Forms.Button();
            this.cbTaikhoan = new System.Windows.Forms.ComboBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThietBi
            // 
            this.btnThietBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThietBi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietBi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThietBi.Location = new System.Drawing.Point(0, 177);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(228, 45);
            this.btnThietBi.TabIndex = 0;
            this.btnThietBi.Text = "Quản lý thiết bị";
            this.btnThietBi.UseVisualStyleBackColor = false;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(136)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnMuon);
            this.panel1.Controls.Add(this.btnQLMuonTra);
            this.panel1.Controls.Add(this.btnBaoTri);
            this.panel1.Controls.Add(this.btnThietBi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbTaikhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 608);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMuon
            // 
            this.btnMuon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMuon.Location = new System.Drawing.Point(44, 517);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(122, 30);
            this.btnMuon.TabIndex = 8;
            this.btnMuon.Text = "Mượn/trả thiết bị";
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnQLMuonTra
            // 
            this.btnQLMuonTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnQLMuonTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLMuonTra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnQLMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLMuonTra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQLMuonTra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLMuonTra.Location = new System.Drawing.Point(0, 267);
            this.btnQLMuonTra.Name = "btnQLMuonTra";
            this.btnQLMuonTra.Size = new System.Drawing.Size(228, 45);
            this.btnQLMuonTra.TabIndex = 7;
            this.btnQLMuonTra.Text = "Quản lý thiết bị mượn/trả";
            this.btnQLMuonTra.UseVisualStyleBackColor = false;
            this.btnQLMuonTra.Click += new System.EventHandler(this.btnQLMuonTra_Click);
            // 
            // btnBaoTri
            // 
            this.btnBaoTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnBaoTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoTri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnBaoTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoTri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBaoTri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoTri.Location = new System.Drawing.Point(0, 222);
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.Size = new System.Drawing.Size(228, 45);
            this.btnBaoTri.TabIndex = 1;
            this.btnBaoTri.Text = "Quản lý bảo trì";
            this.btnBaoTri.UseVisualStyleBackColor = false;
            this.btnBaoTri.Click += new System.EventHandler(this.btnBaoTri_Click);
            // 
            // cbTaikhoan
            // 
            this.cbTaikhoan.FormattingEnabled = true;
            this.cbTaikhoan.Location = new System.Drawing.Point(1053, 13);
            this.cbTaikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.cbTaikhoan.Name = "cbTaikhoan";
            this.cbTaikhoan.Size = new System.Drawing.Size(92, 21);
            this.cbTaikhoan.TabIndex = 5;
            this.cbTaikhoan.Text = "Tài khoản";
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.White;
            this.pnlControl.Location = new System.Drawing.Point(234, 116);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(930, 492);
            this.pnlControl.TabIndex = 6;
            this.pnlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControl_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1053, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Tài khoản";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(136)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.labName);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(228, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 110);
            this.panel2.TabIndex = 7;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(355, 37);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(210, 31);
            this.labName.TabIndex = 6;
            this.labName.Text = "Quản lý thiết bị";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::QuanLy.Properties.Resources.IconBK;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(44, 557);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 30);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1164, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Quản lý";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThietBi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBaoTri;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.ComboBox cbTaikhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQLMuonTra;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnThoat;
    }
}