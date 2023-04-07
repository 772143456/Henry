namespace 百度OCR
{
    partial class frm_TxtImgToTxt
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tburl = new System.Windows.Forms.TextBox();
            this.btnurl = new System.Windows.Forms.Button();
            this.btnlocal = new System.Windows.Forms.Button();
            this.tblocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrans2Txt=new System.Windows.Forms.Button();
            //this.btnTrans2Word=new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tburl
            // 
            this.tburl.Location = new System.Drawing.Point(113, 39);
            this.tburl.Name = "tburl";
            this.tburl.Size = new System.Drawing.Size(392, 21);
            this.tburl.TabIndex = 0;
            //this.tburl.Text = "https://login.bce.baidu.com/img/20181212-2x.png";
            this.tburl.Text = "";
            // 
            // btnurl
            // 
            this.btnurl.Location = new System.Drawing.Point(511, 37);
            this.btnurl.Name = "btnurl";
            this.btnurl.Size = new System.Drawing.Size(75, 23);
            this.btnurl.TabIndex = 1;
            this.btnurl.Text = "开始识别";
            this.btnurl.UseVisualStyleBackColor = true;
            this.btnurl.Click += new System.EventHandler(this.btnurl_Click);
            // btnTrans2Txt
            // 
            // 
            // 
            this.btnTrans2Txt.Location = new System.Drawing.Point(611, 87);
            this.btnTrans2Txt.Name = "btnTrans2Txt";
            this.btnTrans2Txt.Size = new System.Drawing.Size(75, 23);
            this.btnTrans2Txt.TabIndex = 8;
            this.btnTrans2Txt.Text = "jpg2txt";
            this.btnTrans2Txt.UseVisualStyleBackColor = true;
            this.btnTrans2Txt.Click += new System.EventHandler(this.btnTrans2Txt_Click);
            // btnTrans2Word
            // 
            //this.btnTrans2Word.Location = new System.Drawing.Point(611, 37);
            //this.btnTrans2Word.Name = "btnTrans2Word";
            //this.btnTrans2Word.Size = new System.Drawing.Size(75, 23);
            //this.btnTrans2Word.TabIndex = 9;
            //this.btnTrans2Word.Text = "pdf2word";
            //this.btnTrans2Word.UseVisualStyleBackColor = true;
            //this.btnTrans2Word.Click += new System.EventHandler(this.btnTrans2Word_Click);
            // 
            // btnlocal
            // 
            this.btnlocal.Location = new System.Drawing.Point(203, 87);
            this.btnlocal.Name = "btnlocal";
            this.btnlocal.Size = new System.Drawing.Size(107, 23);
            this.btnlocal.TabIndex = 3;
            this.btnlocal.Text = "打开文件并识别";
            this.btnlocal.UseVisualStyleBackColor = true;
            this.btnlocal.Click += new System.EventHandler(this.btnlocal_Click);
            // 
            // tblocal
            // 
            this.tblocal.Location = new System.Drawing.Point(95, 87);
            this.tblocal.Name = "tblocal";
            this.tblocal.Size = new System.Drawing.Size(100, 21);
            this.tblocal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "网络图片URL地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "本地图片路径";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 175);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(330, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_TxtImgToTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 318);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlocal);
            this.Controls.Add(this.tblocal);
            this.Controls.Add(this.btnurl);
            this.Controls.Add(this.tburl);
            this.Controls.Add(this.btnTrans2Txt);
            //this.Controls.Add(this.btnTrans2Word);
            this.Name = "frm_TxtImgToTxt";
            this.Text = "本地网络图片识别文字";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tburl;
        private System.Windows.Forms.Button btnurl;
        private System.Windows.Forms.Button btnlocal;
        private System.Windows.Forms.TextBox tblocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTrans2Txt;
        //private System.Windows.Forms.Button btnTrans2Word;
    }
}

