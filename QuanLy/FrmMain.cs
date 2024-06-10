using QuanLy.QL_CongViec;
using QuanLy.QL_NhanVien;
using QuanLy.QL_ThongBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{   
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            FrmQLThietBi newFrm = new FrmQLThietBi();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            newFrm.TopLevel = false;
            pnlControl.Controls.Add(newFrm);
            newFrm.BringToFront();
            newFrm.Show();
        }

        private void pnlControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            labName.Text = "Quản lý thiết bị";
            FrmQLThietBi newFrm = new FrmQLThietBi();
            newFrm.TopLevel = false;
            pnlControl.Controls.Add(newFrm);
            newFrm.BringToFront();
            newFrm.Show();
        }

        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            labName.Text = "Quản lý bảo trì";
            FrmBaoTri newFrm = new FrmBaoTri();
            newFrm.TopLevel = false;
            pnlControl.Controls.Add(newFrm);
            newFrm.BringToFront();
            newFrm.Show();
        }

        private void btnQLMuonTra_Click(object sender, EventArgs e)
        {
            labName.Text = "Quản lý thiết bị mượn/trả";
            FrmTBMuonTra newFrm = new FrmTBMuonTra();
            newFrm.TopLevel = false;
            pnlControl.Controls.Add(newFrm);
            newFrm.BringToFront();
            newFrm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            FrmMuonTra newFrm = new FrmMuonTra();
            newFrm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
