using QuanLy.Model;
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

namespace QuanLy.QL_ThietBi
{
    public partial class FrmSuaTB : Form
    {
        public ThietBi TB = new ThietBi();
        public FrmSuaTB(ThietBi tb)
        {
            InitializeComponent();
            TB = tb;
            txtTen.Text = tb.Ten;
            dtNgayCap.Value = tb.NgayCap;
            txtSoLuong.Text = tb.SoLuong;
            txtViTri.Text = tb.ViTri;
            cbbTinhTrang.Text = tb.TinhTrang;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query;
            query = "update ThietBi set Ten =  N'" + txtTen.Text + "',NgayCap = '" + dtNgayCap.Value + "', ViTri = N'" + txtViTri.Text + "',SoLuong = " + txtSoLuong.Text + ",TinhTrang = N'" + cbbTinhTrang.SelectedItem + "'  where Id = '"+TB.Id+"';";
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
                MessageBox.Show("Sửa thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
