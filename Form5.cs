using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Threading;

namespace cafe
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private int pass;
        private void GuiMail(string gmail)
        {
            try
            {
                Random rd = new Random();
                pass = rd.Next(100000, 1000000);
                MailMessage mail = new MailMessage("ndcong1992@gmail.com", gmail, "Mã xác nhận", pass.ToString());
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Host = "smtp.gmail.com";
                client.UseDefaultCredentials = false;
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("ndcong1992@gmail.com", "nguyenduycong123456789");
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Đã gửi tin nhắn thành công!", "Thành Công", MessageBoxButtons.OK);
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi kết nối mạng", "Cảnh bảo", MessageBoxButtons.OK);
            }
       }
        private void Form5_Load(object sender, EventArgs e)
        {
            GuiMail(Form1.gmail);
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdXacnhan_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtMaxacnhan.Text)==pass)
            {
                MessageBox.Show("ĐÚNG", "Thông báo", MessageBoxButtons.OK);
                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtMaxacnhan.Text != "")
            {
                cmdXacnhan.Enabled = true;
            }    
        }

        private void cmdGuilai_Click(object sender, EventArgs e)
        {
            GuiMail(Form1.gmail);
        }

        private void txtMaxacnhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
