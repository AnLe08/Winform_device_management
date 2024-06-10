using DevExpress.Xpo.DB.Helpers;
using QuanLy.QL_ThongBao;
using QuanLyChungCu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy.QL_ThietBi
{
    public partial class FrmThemThietBi : Form
    {
        public FrmQLThietBi frmQLThietBi { get; set; }

        public FrmThemThietBi()
        {
            InitializeComponent();
        }

        private void FrmThemThietBi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == null || txtTen.Text == null || txtViTri.Text == null || cbbTinhTrang.Text == null)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin khi thêm");
            }
            else
            {
                string query;
                query = "insert into ThietBi (Id,Ten ,NgayCap, ViTri,SoLuong,TinhTrang) values (NEWID(), N'" + txtTen.Text + "', '" + dtNgayCap.Value + "', N'" + txtViTri.Text + "', " + txtSoLuong.Text + ", N'" + cbbTinhTrang.SelectedItem + "');";
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
                    MessageBox.Show("Thêm thành công!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
