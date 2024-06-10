using DevExpress.Xpo.DB.Helpers;
using QuanLyChungCu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLy
{
    public partial class FrmMuonTra : Form
    {
        public FrmMuonTra()
        {
            InitializeComponent();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                using (SqlConnection sqlConnection = ConnectDb.GetConnection())
                {
                    sqlConnection.Open();
                    adapter = new SqlDataAdapter("select * from ThietBi", sqlConnection);
                    adapter.Fill(table);
                    sqlConnection.Close();
                }
                cbbTenTB.DataSource = table;
                cbbTenTB.DisplayMember = "Ten";
                cbbTenTB.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMuonTra_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == null || txtNguoiMuon.Text == null || cbbTenTB.Text == null || rtxtGhiChu.Text == null)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin khi thêm");
            }
            else
            {
                string query = "INSERT INTO ThietBiMuonTra (Id, IdTB, TenNguoiMuon, NgayMuon, NgayTra, SoLuong, GhiChu, TrangThai) VALUES ( NEWID(), '"+cbbTenTB.SelectedValue+"',  N'" + txtNguoiMuon.Text + "', '" + (DateTime.Now).ToString("yyyy-MM-dd") + "', NULL, " + txtSoLuong.Text + ", N'" + rtxtGhiChu.Text + "', N'Đang mượn');";
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    using (SqlConnection sqlConnection = ConnectDb.GetConnection())
                    {
                        sqlConnection.Open();
                        adapter = new SqlDataAdapter(query, sqlConnection);
                        adapter.Fill(table);
                        sqlConnection.Close();
                    }
                    MessageBox.Show("Mượn thành công!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
