namespace WindowsFormsApplication1
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
            this.textbox_NhapSo1 = new Demo_01.Textbox_NhapSo();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_NhapSo1
            // 
            this.textbox_NhapSo1.Location = new System.Drawing.Point(23, 12);
            this.textbox_NhapSo1.Name = "textbox_NhapSo1";
            this.textbox_NhapSo1.Size = new System.Drawing.Size(100, 20);
            this.textbox_NhapSo1.TabIndex = 0;
            // 
            // btn_nhap
            // 
            this.btn_nhap.Location = new System.Drawing.Point(175, 8);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(75, 23);
            this.btn_nhap.TabIndex = 1;
            this.btn_nhap.Text = "nhap";
            this.btn_nhap.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(311, 7);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 524);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_nhap);
            this.Controls.Add(this.textbox_NhapSo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Demo_01.Textbox_NhapSo textbox_NhapSo1;
        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.Button btn_xoa;







    }
}

