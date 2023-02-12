
namespace cafe
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.numSoluong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.cmdXong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng";
            // 
            // numSoluong
            // 
            this.numSoluong.Location = new System.Drawing.Point(103, 56);
            this.numSoluong.Name = "numSoluong";
            this.numSoluong.Size = new System.Drawing.Size(120, 20);
            this.numSoluong.TabIndex = 2;
            this.numSoluong.ValueChanged += new System.EventHandler(this.numSoluong_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn giá :";
            // 
            // txtDongia
            // 
            this.txtDongia.Enabled = false;
            this.txtDongia.Location = new System.Drawing.Point(103, 97);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(120, 20);
            this.txtDongia.TabIndex = 4;
            // 
            // cmdXong
            // 
            this.cmdXong.Location = new System.Drawing.Point(119, 172);
            this.cmdXong.Name = "cmdXong";
            this.cmdXong.Size = new System.Drawing.Size(75, 23);
            this.cmdXong.TabIndex = 5;
            this.cmdXong.Text = "Xong";
            this.cmdXong.UseVisualStyleBackColor = true;
            this.cmdXong.Click += new System.EventHandler(this.cmdXong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thành tiền";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Enabled = false;
            this.txtThanhtien.Location = new System.Drawing.Point(103, 135);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(120, 20);
            this.txtThanhtien.TabIndex = 7;
            this.txtThanhtien.Text = "0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 220);
            this.ControlBox = false;
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdXong);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSoluong);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Bảng";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Button cmdXong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThanhtien;
    }
}