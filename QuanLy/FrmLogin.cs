using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLy
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximumSize = this.Size; 
            this.MinimumSize = this.Size; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text == "q" && txtMatKhau.Text == "q")
            {
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
