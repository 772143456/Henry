namespace Pdf2Jpg
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_pdfPath = new System.Windows.Forms.Label();
            this.lab_jpgPath = new System.Windows.Forms.Label();
            this.lab_jpgName = new System.Windows.Forms.Label();
            this.btn_pdf2jpg = new System.Windows.Forms.Button();
            this.txt_pdfPath = new System.Windows.Forms.TextBox();
            this.txt_jpgPath = new System.Windows.Forms.TextBox();
            this.txt_jpgName = new System.Windows.Forms.TextBox();
            this.btn_pdfPath = new System.Windows.Forms.Button();
            this.btn_jpgPath = new System.Windows.Forms.Button();
            this.btn_PDF2JPEG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_pdfPath
            // 
            this.lab_pdfPath.AutoSize = true;
            this.lab_pdfPath.Location = new System.Drawing.Point(75, 83);
            this.lab_pdfPath.Name = "lab_pdfPath";
            this.lab_pdfPath.Size = new System.Drawing.Size(47, 12);
            this.lab_pdfPath.TabIndex = 0;
            this.lab_pdfPath.Text = "PDF路径";
            this.lab_pdfPath.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_jpgPath
            // 
            this.lab_jpgPath.AutoSize = true;
            this.lab_jpgPath.Location = new System.Drawing.Point(75, 138);
            this.lab_jpgPath.Name = "lab_jpgPath";
            this.lab_jpgPath.Size = new System.Drawing.Size(47, 12);
            this.lab_jpgPath.TabIndex = 1;
            this.lab_jpgPath.Text = "JPG路径";
            // 
            // lab_jpgName
            // 
            this.lab_jpgName.AutoSize = true;
            this.lab_jpgName.Location = new System.Drawing.Point(75, 193);
            this.lab_jpgName.Name = "lab_jpgName";
            this.lab_jpgName.Size = new System.Drawing.Size(47, 12);
            this.lab_jpgName.TabIndex = 2;
            this.lab_jpgName.Text = "JPG名字";
            // 
            // btn_pdf2jpg
            // 
            this.btn_pdf2jpg.Location = new System.Drawing.Point(0, 0);
            this.btn_pdf2jpg.Name = "btn_pdf2jpg";
            this.btn_pdf2jpg.Size = new System.Drawing.Size(75, 23);
            this.btn_pdf2jpg.TabIndex = 0;
            // 
            // txt_pdfPath
            // 
            this.txt_pdfPath.Location = new System.Drawing.Point(149, 80);
            this.txt_pdfPath.Name = "txt_pdfPath";
            this.txt_pdfPath.Size = new System.Drawing.Size(251, 21);
            this.txt_pdfPath.TabIndex = 4;
            // 
            // txt_jpgPath
            // 
            this.txt_jpgPath.Location = new System.Drawing.Point(149, 134);
            this.txt_jpgPath.Name = "txt_jpgPath";
            this.txt_jpgPath.Size = new System.Drawing.Size(251, 21);
            this.txt_jpgPath.TabIndex = 5;
            // 
            // txt_jpgName
            // 
            this.txt_jpgName.Location = new System.Drawing.Point(149, 189);
            this.txt_jpgName.Name = "txt_jpgName";
            this.txt_jpgName.Size = new System.Drawing.Size(251, 21);
            this.txt_jpgName.TabIndex = 6;
            // 
            // btn_pdfPath
            // 
            this.btn_pdfPath.Location = new System.Drawing.Point(407, 78);
            this.btn_pdfPath.Name = "btn_pdfPath";
            this.btn_pdfPath.Size = new System.Drawing.Size(45, 23);
            this.btn_pdfPath.TabIndex = 7;
            this.btn_pdfPath.Text = "..";
            this.btn_pdfPath.UseVisualStyleBackColor = true;
            this.btn_pdfPath.Click += new System.EventHandler(this.btn_pdfPath_Click);
            // 
            // btn_jpgPath
            // 
            this.btn_jpgPath.Location = new System.Drawing.Point(407, 133);
            this.btn_jpgPath.Name = "btn_jpgPath";
            this.btn_jpgPath.Size = new System.Drawing.Size(45, 23);
            this.btn_jpgPath.TabIndex = 8;
            this.btn_jpgPath.Text = "..";
            this.btn_jpgPath.UseVisualStyleBackColor = true;
            this.btn_jpgPath.Click += new System.EventHandler(this.btn_jpgPath_Click);
            // 
            // btn_PDF2JPEG
            // 
            this.btn_PDF2JPEG.Location = new System.Drawing.Point(244, 255);
            this.btn_PDF2JPEG.Name = "btn_PDF2JPEG";
            this.btn_PDF2JPEG.Size = new System.Drawing.Size(75, 23);
            this.btn_PDF2JPEG.TabIndex = 9;
            this.btn_PDF2JPEG.Text = "PDF转图片格式";
            this.btn_PDF2JPEG.UseVisualStyleBackColor = true;
            this.btn_PDF2JPEG.Click += new System.EventHandler(this.btn_PDF2JPEG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.btn_PDF2JPEG);
            this.Controls.Add(this.btn_jpgPath);
            this.Controls.Add(this.btn_pdfPath);
            this.Controls.Add(this.txt_jpgName);
            this.Controls.Add(this.txt_jpgPath);
            this.Controls.Add(this.txt_pdfPath);
            this.Controls.Add(this.lab_jpgName);
            this.Controls.Add(this.lab_jpgPath);
            this.Controls.Add(this.lab_pdfPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_pdfPath;
        private System.Windows.Forms.Label lab_jpgPath;
        private System.Windows.Forms.Label lab_jpgName;
        private System.Windows.Forms.Button btn_pdf2jpg;
        private System.Windows.Forms.TextBox txt_pdfPath;
        private System.Windows.Forms.TextBox txt_jpgPath;
        private System.Windows.Forms.TextBox txt_jpgName;
        private System.Windows.Forms.Button btn_pdfPath;
        private System.Windows.Forms.Button btn_jpgPath;
        private System.Windows.Forms.Button btn_PDF2JPEG;
    }
}

