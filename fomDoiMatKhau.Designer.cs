namespace QL_BenhVien
{
    partial class fomDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fomDoiMatKhau));
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMkCu = new System.Windows.Forms.TextBox();
            this.txtMkMoi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMkmoi2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(117, 289);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(179, 46);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txtMkCu
            // 
            this.txtMkCu.Location = new System.Drawing.Point(339, 55);
            this.txtMkCu.Name = "txtMkCu";
            this.txtMkCu.Size = new System.Drawing.Size(280, 38);
            this.txtMkCu.TabIndex = 2;
            // 
            // txtMkMoi1
            // 
            this.txtMkMoi1.Location = new System.Drawing.Point(339, 129);
            this.txtMkMoi1.Name = "txtMkMoi1";
            this.txtMkMoi1.Size = new System.Drawing.Size(280, 38);
            this.txtMkMoi1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu mới";
            // 
            // txtMkmoi2
            // 
            this.txtMkmoi2.Location = new System.Drawing.Point(339, 196);
            this.txtMkmoi2.Name = "txtMkmoi2";
            this.txtMkmoi2.Size = new System.Drawing.Size(280, 38);
            this.txtMkmoi2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(440, 289);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(179, 46);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // fomDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(682, 402);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMkmoi2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMkMoi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMkCu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fomDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMkCu;
        private System.Windows.Forms.TextBox txtMkMoi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMkmoi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
    }
}