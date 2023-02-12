
namespace cafe
{
    partial class Form5
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
            this.txtMaxacnhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdXacnhan = new System.Windows.Forms.Button();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.cmdGuilai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaxacnhan
            // 
            this.txtMaxacnhan.Location = new System.Drawing.Point(133, 78);
            this.txtMaxacnhan.Name = "txtMaxacnhan";
            this.txtMaxacnhan.Size = new System.Drawing.Size(100, 20);
            this.txtMaxacnhan.TabIndex = 0;
            this.txtMaxacnhan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMaxacnhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxacnhan_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã xác nhận";
            // 
            // cmdXacnhan
            // 
            this.cmdXacnhan.Enabled = false;
            this.cmdXacnhan.Location = new System.Drawing.Point(78, 143);
            this.cmdXacnhan.Name = "cmdXacnhan";
            this.cmdXacnhan.Size = new System.Drawing.Size(75, 23);
            this.cmdXacnhan.TabIndex = 2;
            this.cmdXacnhan.Text = "Xác nhận";
            this.cmdXacnhan.UseVisualStyleBackColor = true;
            this.cmdXacnhan.Click += new System.EventHandler(this.cmdXacnhan_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Location = new System.Drawing.Point(191, 143);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(75, 23);
            this.cmdThoat.TabIndex = 3;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.UseVisualStyleBackColor = true;
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cmdGuilai
            // 
            this.cmdGuilai.Location = new System.Drawing.Point(239, 78);
            this.cmdGuilai.Name = "cmdGuilai";
            this.cmdGuilai.Size = new System.Drawing.Size(75, 23);
            this.cmdGuilai.TabIndex = 4;
            this.cmdGuilai.Text = "Gửi lại";
            this.cmdGuilai.UseVisualStyleBackColor = true;
            this.cmdGuilai.Click += new System.EventHandler(this.cmdGuilai_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 260);
            this.ControlBox = false;
            this.Controls.Add(this.cmdGuilai);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdXacnhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxacnhan);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxacnhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdXacnhan;
        private System.Windows.Forms.Button cmdThoat;
        private System.Windows.Forms.Button cmdGuilai;
    }
}