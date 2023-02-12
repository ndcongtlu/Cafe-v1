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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }
        clalog cla = new clalog();
        private int searchtd(string IDhoadon)
        {
            int sum = 0;
            DataTable dt = cla.readdata("SELECT Ten_mon , Don_gia , So_luong , thanh_tien FROM Mon m, Thuc_don td Where m.IDmon = td.IDmon and td.IDhoadon = '" + IDhoadon + "' ");
            if( dt != null)
            {
                dataMenu.DataSource = dt;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    sum = sum + Convert.ToInt32(dt.Rows[i]["thanh_tien"]);
                }
            }
            return sum;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LBtongtien.Text = searchtd(Form2.IDhoadon).ToString("#,##0");
            khungttTienmat.Enabled = false;
            tongtien = searchtd(Form2.IDhoadon);
        }

         private void hinhthuctt(string ht, string IDhoadon )
        {
            cla.exedata("UPDATE Hoa_don SET Hinh_thuctt = N'"+ ht +"' Where IDhoadon = '" + IDhoadon + "' ");
        }
        private void rdTienmat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTienmat.Checked)
            {
                hinhthuctt(rdTienmat.Text, Form2.IDhoadon);
                khungttTienmat.Enabled = true;
            }
            else
                khungttTienmat.Enabled = false;
        }

        private void rdATM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdATM.Checked)
            {
                hinhthuctt(rdATM.Text, Form2.IDhoadon);
            }
        }
        private static int tongtien = 0;
        private static string mucgiam = "";
        private void rdGiamgia25_CheckedChanged(object sender, EventArgs e)
        {
            if(rdGiamgia25.Checked)
            {
                int num = 0;
                num = searchtd(Form2.IDhoadon) - (searchtd(Form2.IDhoadon) * 25 / 100);
                tongtien = num;
                LBtongtien.Text = num.ToString("#,##0");
                mucgiam = "25%";
            }    
        }

        private void rdGiamgia50_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGiamgia50.Checked)
            {
                int num = 0;
                num = searchtd(Form2.IDhoadon) - ((searchtd(Form2.IDhoadon)*50)/100);
                tongtien = num;
                LBtongtien.Text = num.ToString("#,##0");
                mucgiam = "50%";
            }
        }

        private void rdGiamgia75_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGiamgia75.Checked)
            {
                int num = 0;
                num = searchtd(Form2.IDhoadon) - (searchtd(Form2.IDhoadon) * 75 / 100) ;
                tongtien = num;
                LBtongtien.Text = num.ToString("#,##0");
                mucgiam = "75%";
            }
        }

        private void txtTiennhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTiennhan_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if(txtTiennhan.Text == "")
            {
                num = 0;
            }
            else
            {
                num = Convert.ToInt32(txtTiennhan.Text);
            } 
            if(num<tongtien)
            {
                txtTientra.Text = "0";
            }    
            else
            {
                txtTientra.Text = (num - tongtien).ToString("#,##0");
            }    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkXacnhan.Checked)
            {
                txtTiennhan.Enabled = false;
                cmdThanhtoan.Enabled = true;
            }   
            else
            {
                txtTiennhan.Enabled = true;
                cmdThanhtoan.Enabled = false;
            }    
        }
        private void updatehd(string IDhoadon,string giamgia , int tongtien  )
        {
           Boolean check =  cla.exedata("UPDATE Hoa_don SET Giamgia = '"+ giamgia +"' , Tong_tien = "+ tongtien +", trang_thai = 'YES' WHERE IDhoadon = '"+ IDhoadon +"' ");
            if(check)
            {
                MessageBox.Show("Thanh toán thành công");
            }    
            else
            {
                MessageBox.Show("Thanh toán không thành công");
            }    
        }
        private void cmdThanhtoan_Click(object sender, EventArgs e)
        {
            updatehd(Form2.IDhoadon,mucgiam,tongtien);
            this.Close();
        }

        private void txtSopt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rdGiamgiacus_CheckedChanged(object sender, EventArgs e)
        {
            if(rdGiamgiacus.Checked)
            {
                txtSopt.Enabled = true;
            }    
        }

        private void txtSopt_TextChanged(object sender, EventArgs e)
        {
            if (rdGiamgiacus.Checked)
            {
                int num = 0;
                int cd;
                if(txtSopt.Text =="")
                {
                    cd = 0;
                }    
                else
                {
                    cd = Convert.ToInt32(txtSopt.Text);
                }    
                num = searchtd(Form2.IDhoadon) - (searchtd(Form2.IDhoadon) * cd / 100) ;
                tongtien = num;
                LBtongtien.Text = num.ToString("#,##0");
                mucgiam = txtSopt.Text + "%";
            }
        }
    }
}
