using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaloCSharpSDK;

namespace cafe
{
    public partial class Form1 : Form
    {
        clalog clalog = new clalog();
        public Form1()
        {
            InitializeComponent();
        }
        public static string linkimage = "";
        private void cmdEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            Image i = Image.FromFile(op.FileName);
            linkimage = op.FileName;
            picB1.Image = i;
            cmdEdit.Visible = false;
        }

        private void chkHienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienthi.Checked)
            {
                txtMatkhau.PasswordChar = '\0';
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
            }
        }
        private string getID(string username, string password)
        {

            string id = "";
            DataTable da = clalog.readdata("SELECT * FROM userandpass WHERE username =N'" + username + "' and password=N'" + password + "'");
            if (da != null)
            {
                foreach (DataRow dr in da.Rows)
                {
                    id = dr["id_user"].ToString();
                }
            }
            else
            {
                id = null;
            }
            return id;
        }
        public string getLV(string username, string password)
        {

            string id = "";
            DataTable da = clalog.readdata("SELECT * FROM userandpass WHERE username =N'" + username + "' and password=N'" + password + "'");
            if (da != null)
            {
                foreach (DataRow dr in da.Rows)
                {
                    id = dr["lv"].ToString();
                }
            }
            else
            {
                id = null;
            }
            return id;
        }
        public string getgmail(string username, string password)
        {

            string id = "";
            DataTable da = clalog.readdata("SELECT * FROM userandpass WHERE username =N'" + username + "' and password=N'" + password + "'");
            if (da != null)
            {
                foreach (DataRow dr in da.Rows)
                {
                    id = dr["gmail"].ToString();
                }
            }
            else
            {
                id = null;
            }
            return id;
        }
        public static string Id_user = "";
        public static string lv = "";
        public static string gmail = "";
        private void cmdDangnhap_Click(object sender, EventArgs e)
        {
            Id_user = getID(txtTaikhoan.Text, txtMatkhau.Text);
            lv = getLV(txtTaikhoan.Text, txtMatkhau.Text);
            gmail = getgmail(txtTaikhoan.Text, txtMatkhau.Text);
            if (Id_user != "" && lv =="admin")
            {
                MessageBox.Show("Đăng nhập thành công ", "Chúc mừng ");
                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else if(Id_user !="" && lv =="user")
            {
                MessageBox.Show("Đăng nhập thành công ", "Chúc mừng ");
                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }    
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu ! Vui lòng nhập lại", "Cảnh báo");
            }
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picB1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
