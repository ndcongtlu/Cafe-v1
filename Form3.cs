using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class Form3 : Form
    {
        clalog cla = new clalog();
        public Form3()
        {
            InitializeComponent();
        }
        private string getGia(string name)
        {
            string gia = "";
            DataTable dt = cla.readdata("SELECT * FROM Mon WHERE Ten_mon = N'"+ name +"' ");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    gia = dr["Don_gia"].ToString();
                }
            }
            else
                MessageBox.Show("Lỗi kết nối");
            return gia;
        }
        private int gia1 = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            gia1 = Convert.ToInt32(getGia(Form2.kt_mon.Text));
            txtDongia.Text = gia1.ToString("#,##0");
            thanhtien = 0;
        }
        public static string soluong = "";
        public static int thanhtien = 0;
        private void cmdXong_Click(object sender, EventArgs e)
        {
            soluong = numSoluong.Value.ToString();
            this.Close();
        }
        
        private void numSoluong_ValueChanged(object sender, EventArgs e)
        {
            int tt = Convert.ToInt32(numSoluong.Value.ToString()) * gia1;
            thanhtien = tt;
            txtThanhtien.Text = tt.ToString("#,##0");
            
        }
    }
}
