using DevExpress.Xpo.DB.Helpers;
using QuanLyChungCu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy.QL_CongViec
{
    public partial class FrmBaoTri : Form
    {
        
        public FrmBaoTri()
        {
            InitializeComponent();
            FillTable("select * from ThietBi where TinhTrang = N'Bị hỏng'");
        }
        public void FillTable(string query)
        {
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
                dtgvBt.Columns["Id"].DataPropertyName = "Id";
                dtgvBt.Columns["Ten"].DataPropertyName = "Ten";
                dtgvBt.Columns["NgayCap"].DataPropertyName = "NgayCap";
                dtgvBt.Columns["ViTri"].DataPropertyName = "ViTri";

                //dtgvBt.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgvBt.Columns["MaTB"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgvBt.Columns["NgayBT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgvBt.Columns["NgayKT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgvBt.AutoGenerateColumns = false;
                dtgvBt.DataSource = null;
                dtgvBt.DefaultCellStyle.ForeColor = Color.Black;
                dtgvBt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgvBt.MultiSelect = false;
                dtgvBt.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Tab_DanhSach_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            FillTable("select * from BaoTri where Id = '"+txtTimKiem.Text+"'");
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
