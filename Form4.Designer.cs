
namespace cafe
{
    partial class Form4
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
            this.dataMenu = new System.Windows.Forms.DataGridView();
            this.cmdThanhtoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdTienmat = new System.Windows.Forms.RadioButton();
            this.rdATM = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdGiamgia25 = new System.Windows.Forms.RadioButton();
            this.rdGiamgia50 = new System.Windows.Forms.RadioButton();
            this.rdGiamgia75 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.LBtongtien = new System.Windows.Forms.Label();
            this.khungttTienmat = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTientra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTiennhan = new System.Windows.Forms.TextBox();
            this.chkXacnhan = new System.Windows.Forms.CheckBox();
            this.rdGiamgiacus = new System.Windows.Forms.RadioButton();
            this.txtSopt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).BeginInit();
            this.khungttTienmat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataMenu
            // 
            this.dataMenu.AllowUserToAddRows = false;
            this.dataMenu.AllowUserToDeleteRows = false;
            this.dataMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMenu.Enabled = false;
            this.dataMenu.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataMenu.Location = new System.Drawing.Point(3, 36);
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.ReadOnly = true;
            this.dataMenu.Size = new System.Drawing.Size(473, 411);
            this.dataMenu.TabIndex = 0;
            this.dataMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmdThanhtoan
            // 
            this.cmdThanhtoan.Enabled = false;
            this.cmdThanhtoan.Location = new System.Drawing.Point(564, 398);
            this.cmdThanhtoan.Name = "cmdThanhtoan";
            this.cmdThanhtoan.Size = new System.Drawing.Size(80, 40);
            this.cmdThanhtoan.TabIndex = 1;
            this.cmdThanhtoan.Text = "Thanh toán";
            this.cmdThanhtoan.UseVisualStyleBackColor = true;
            this.cmdThanhtoan.Click += new System.EventHandler(this.cmdThanhtoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thực đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hình thức :";
            // 
            // rdTienmat
            // 
            this.rdTienmat.AutoSize = true;
            this.rdTienmat.Location = new System.Drawing.Point(43, 41);
            this.rdTienmat.Name = "rdTienmat";
            this.rdTienmat.Size = new System.Drawing.Size(66, 17);
            this.rdTienmat.TabIndex = 4;
            this.rdTienmat.TabStop = true;
            this.rdTienmat.Text = "Tiền mặt";
            this.rdTienmat.UseVisualStyleBackColor = true;
            this.rdTienmat.CheckedChanged += new System.EventHandler(this.rdTienmat_CheckedChanged);
            // 
            // rdATM
            // 
            this.rdATM.AutoSize = true;
            this.rdATM.Location = new System.Drawing.Point(43, 77);
            this.rdATM.Name = "rdATM";
            this.rdATM.Size = new System.Drawing.Size(70, 17);
            this.rdATM.TabIndex = 5;
            this.rdATM.TabStop = true;
            this.rdATM.Text = "Thẻ ATM";
            this.rdATM.UseVisualStyleBackColor = true;
            this.rdATM.CheckedChanged += new System.EventHandler(this.rdATM_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(13, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã giảm giá :";
            // 
            // rdGiamgia25
            // 
            this.rdGiamgia25.AutoSize = true;
            this.rdGiamgia25.Location = new System.Drawing.Point(33, 35);
            this.rdGiamgia25.Name = "rdGiamgia25";
            this.rdGiamgia25.Size = new System.Drawing.Size(45, 17);
            this.rdGiamgia25.TabIndex = 7;
            this.rdGiamgia25.TabStop = true;
            this.rdGiamgia25.Text = "25%";
            this.rdGiamgia25.UseVisualStyleBackColor = true;
            this.rdGiamgia25.CheckedChanged += new System.EventHandler(this.rdGiamgia25_CheckedChanged);
            // 
            // rdGiamgia50
            // 
            this.rdGiamgia50.AutoSize = true;
            this.rdGiamgia50.Location = new System.Drawing.Point(33, 59);
            this.rdGiamgia50.Name = "rdGiamgia50";
            this.rdGiamgia50.Size = new System.Drawing.Size(45, 17);
            this.rdGiamgia50.TabIndex = 8;
            this.rdGiamgia50.TabStop = true;
            this.rdGiamgia50.Text = "50%";
            this.rdGiamgia50.UseVisualStyleBackColor = true;
            this.rdGiamgia50.CheckedChanged += new System.EventHandler(this.rdGiamgia50_CheckedChanged);
            // 
            // rdGiamgia75
            // 
            this.rdGiamgia75.AutoSize = true;
            this.rdGiamgia75.Location = new System.Drawing.Point(33, 83);
            this.rdGiamgia75.Name = "rdGiamgia75";
            this.rdGiamgia75.Size = new System.Drawing.Size(45, 17);
            this.rdGiamgia75.TabIndex = 9;
            this.rdGiamgia75.TabStop = true;
            this.rdGiamgia75.Text = "75%";
            this.rdGiamgia75.UseVisualStyleBackColor = true;
            this.rdGiamgia75.CheckedChanged += new System.EventHandler(this.rdGiamgia75_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng tiền :";
            // 
            // LBtongtien
            // 
            this.LBtongtien.AutoSize = true;
            this.LBtongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtongtien.Location = new System.Drawing.Point(571, 104);
            this.LBtongtien.Name = "LBtongtien";
            this.LBtongtien.Size = new System.Drawing.Size(18, 20);
            this.LBtongtien.TabIndex = 11;
            this.LBtongtien.Text = "0";
            // 
            // khungttTienmat
            // 
            this.khungttTienmat.Controls.Add(this.label5);
            this.khungttTienmat.Controls.Add(this.txtTientra);
            this.khungttTienmat.Controls.Add(this.label6);
            this.khungttTienmat.Controls.Add(this.txtTiennhan);
            this.khungttTienmat.Location = new System.Drawing.Point(482, 272);
            this.khungttTienmat.Name = "khungttTienmat";
            this.khungttTienmat.Size = new System.Drawing.Size(250, 90);
            this.khungttTienmat.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhận";
            // 
            // txtTientra
            // 
            this.txtTientra.Enabled = false;
            this.txtTientra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTientra.Location = new System.Drawing.Point(69, 52);
            this.txtTientra.Name = "txtTientra";
            this.txtTientra.Size = new System.Drawing.Size(162, 26);
            this.txtTientra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cần trả";
            // 
            // txtTiennhan
            // 
            this.txtTiennhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiennhan.Location = new System.Drawing.Point(69, 9);
            this.txtTiennhan.Name = "txtTiennhan";
            this.txtTiennhan.Size = new System.Drawing.Size(162, 26);
            this.txtTiennhan.TabIndex = 14;
            this.txtTiennhan.TextChanged += new System.EventHandler(this.txtTiennhan_TextChanged);
            this.txtTiennhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiennhan_KeyPress);
            // 
            // chkXacnhan
            // 
            this.chkXacnhan.AutoSize = true;
            this.chkXacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkXacnhan.Location = new System.Drawing.Point(482, 368);
            this.chkXacnhan.Name = "chkXacnhan";
            this.chkXacnhan.Size = new System.Drawing.Size(96, 24);
            this.chkXacnhan.TabIndex = 18;
            this.chkXacnhan.Text = "Xác nhận";
            this.chkXacnhan.UseVisualStyleBackColor = true;
            this.chkXacnhan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rdGiamgiacus
            // 
            this.rdGiamgiacus.AutoSize = true;
            this.rdGiamgiacus.Location = new System.Drawing.Point(33, 104);
            this.rdGiamgiacus.Name = "rdGiamgiacus";
            this.rdGiamgiacus.Size = new System.Drawing.Size(14, 13);
            this.rdGiamgiacus.TabIndex = 19;
            this.rdGiamgiacus.TabStop = true;
            this.rdGiamgiacus.UseVisualStyleBackColor = true;
            this.rdGiamgiacus.CheckedChanged += new System.EventHandler(this.rdGiamgiacus_CheckedChanged);
            // 
            // txtSopt
            // 
            this.txtSopt.Enabled = false;
            this.txtSopt.Location = new System.Drawing.Point(54, 101);
            this.txtSopt.Name = "txtSopt";
            this.txtSopt.Size = new System.Drawing.Size(24, 20);
            this.txtSopt.TabIndex = 20;
            this.txtSopt.TextChanged += new System.EventHandler(this.txtSopt_TextChanged);
            this.txtSopt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSopt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "%";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdTienmat);
            this.panel1.Controls.Add(this.rdATM);
            this.panel1.Location = new System.Drawing.Point(482, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 100);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rdGiamgia25);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rdGiamgia50);
            this.panel2.Controls.Add(this.txtSopt);
            this.panel2.Controls.Add(this.rdGiamgia75);
            this.panel2.Controls.Add(this.rdGiamgiacus);
            this.panel2.Location = new System.Drawing.Point(609, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 130);
            this.panel2.TabIndex = 23;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkXacnhan);
            this.Controls.Add(this.khungttTienmat);
            this.Controls.Add(this.LBtongtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdThanhtoan);
            this.Controls.Add(this.dataMenu);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).EndInit();
            this.khungttTienmat.ResumeLayout(false);
            this.khungttTienmat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMenu;
        private System.Windows.Forms.Button cmdThanhtoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdTienmat;
        private System.Windows.Forms.RadioButton rdATM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdGiamgia25;
        private System.Windows.Forms.RadioButton rdGiamgia50;
        private System.Windows.Forms.RadioButton rdGiamgia75;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBtongtien;
        private System.Windows.Forms.Panel khungttTienmat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTientra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTiennhan;
        private System.Windows.Forms.CheckBox chkXacnhan;
        private System.Windows.Forms.RadioButton rdGiamgiacus;
        private System.Windows.Forms.TextBox txtSopt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}