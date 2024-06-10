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

namespace QuanLy.QL_NhanVien
{
    public partial class FrmTBMuonTra : Form
    {
        public FrmTBMuonTra()
        {
            InitializeComponent();
            FillTable("select * from ThietBiMuonTra");
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
                dtgvMuonTra.Columns["Id"].DataPropertyName = "Id";
                dtgvMuonTra.Columns["IdTB"].DataPropertyName = "IdTB";
                dtgvMuonTra.Columns["NguoiMuon"].DataPropertyName = "TenNguoiMuon";
                dtgvMuonTra.Columns["NgayTra"].DataPropertyName = "NgayTra";
                dtgvMuonTra.Columns["NgayMuon"].DataPropertyName = "NgayMuon";
                dtgvMuonTra.Columns["SoLuong"].DataPropertyName = "SoLuong";
                dtgvMuonTra.Columns["GhiChu"].DataPropertyName = "GhiChu";
                dtgvMuonTra.Columns["TrangThai"].DataPropertyName = "TrangThai";

                //dtgvMuonTra.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgvMuonTra.Columns["MaTB"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgvMuonTra.Columns["NgayBT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgvMuonTra.Columns["NgayKT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgvMuonTra.Columns["GhiChu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgvMuonTra.Columns["TrangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtgvMuonTra.DataSource = null;
                dtgvMuonTra.DefaultCellStyle.ForeColor = Color.Black;
                dtgvMuonTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgvMuonTra.MultiSelect = false;
                dtgvMuonTra.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnTBDangMuon_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            FillTable("select * from ThietBiMuonTra where Id = '"+txtTimKiem.Text+"'");
        }

        private void dtgvMuonTra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvMuonTra.Rows[e.RowIndex];
                ID = selectedRow.Cells["Id"].Value.ToString();
                if (selectedRow.Cells["Id"].Value.ToString() != "Đang mượn")
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn thiết bị đã được trả", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FillTable("UPDATE ThietBiMuonTra SET NgayTra = GETDATE(), TrangThai = N'Đã trả' WHERE Id = '" + ID + "';");
                    }
                    else
                    {
                    }
                }
            }
        }
    }
}
