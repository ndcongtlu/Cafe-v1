
namespace cafe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.cmdDangnhap = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.picB1 = new System.Windows.Forms.PictureBox();
            this.chkHienthi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picB1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(243, 255);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(246, 26);
            this.txtMatkhau.TabIndex = 1;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(243, 192);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(246, 26);
            this.txtTaikhoan.TabIndex = 2;
            this.txtTaikhoan.TextChanged += new System.EventHandler(this.txtTaikhoan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tài khoản";
            // 
            // cmdThoat
            // 
            this.cmdThoat.Location = new System.Drawing.Point(378, 325);
            this.cmdThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(112, 35);
            this.cmdThoat.TabIndex = 5;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.UseVisualStyleBackColor = true;
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cmdDangnhap
            // 
            this.cmdDangnhap.Location = new System.Drawing.Point(202, 325);
            this.cmdDangnhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdDangnhap.Name = "cmdDangnhap";
            this.cmdDangnhap.Size = new System.Drawing.Size(112, 35);
            this.cmdDangnhap.TabIndex = 6;
            this.cmdDangnhap.Text = "Đăng nhập";
            this.cmdDangnhap.UseVisualStyleBackColor = true;
            this.cmdDangnhap.Click += new System.EventHandler(this.cmdDangnhap_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(232, 45);
            this.cmdEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(112, 35);
            this.cmdEdit.TabIndex = 7;
            this.cmdEdit.Text = "Chỉnh sửa ";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // picB1
            // 
            this.picB1.Location = new System.Drawing.Point(-2, -3);
            this.picB1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picB1.Name = "picB1";
            this.picB1.Size = new System.Drawing.Size(225, 169);
            this.picB1.TabIndex = 0;
            this.picB1.TabStop = false;
            this.picB1.Click += new System.EventHandler(this.picB1_Click);
            // 
            // chkHienthi
            // 
            this.chkHienthi.AutoSize = true;
            this.chkHienthi.Location = new System.Drawing.Point(500, 260);
            this.chkHienthi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHienthi.Name = "chkHienthi";
            this.chkHienthi.Size = new System.Drawing.Size(159, 24);
            this.chkHienthi.TabIndex = 8;
            this.chkHienthi.Text = "Hiển thị mật khẩu";
            this.chkHienthi.UseVisualStyleBackColor = true;
            this.chkHienthi.CheckedChanged += new System.EventHandler(this.chkHienthi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 414);
            this.Controls.Add(this.chkHienthi);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdDangnhap);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.picB1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdThoat;
        private System.Windows.Forms.Button cmdDangnhap;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.PictureBox picB1;
        private System.Windows.Forms.CheckBox chkHienthi;
    }
}

