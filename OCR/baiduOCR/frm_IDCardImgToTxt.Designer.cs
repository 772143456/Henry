namespace 百度OCR
{
    partial class frm_IDCardImgToTxt
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlocal = new System.Windows.Forms.Button();
            this.tblocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbjiaodu = new System.Windows.Forms.ComboBox();
            this.cbzhengfan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbfengxian = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(362, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 246);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(316, 236);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "本地图片路径";
            // 
            // btnlocal
            // 
            this.btnlocal.Location = new System.Drawing.Point(319, 22);
            this.btnlocal.Name = "btnlocal";
            this.btnlocal.Size = new System.Drawing.Size(107, 23);
            this.btnlocal.TabIndex = 9;
            this.btnlocal.Text = "打开文件并识别";
            this.btnlocal.UseVisualStyleBackColor = true;
            this.btnlocal.Click += new System.EventHandler(this.btnlocal_Click);
            // 
            // tblocal
            // 
            this.tblocal.Location = new System.Drawing.Point(93, 24);
            this.tblocal.Name = "tblocal";
            this.tblocal.Size = new System.Drawing.Size(220, 21);
            this.tblocal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "是否检测图像旋转角度";
            // 
            // cbjiaodu
            // 
            this.cbjiaodu.FormattingEnabled = true;
            this.cbjiaodu.Items.AddRange(new object[] {
            "false",
            "true"});
            this.cbjiaodu.Location = new System.Drawing.Point(155, 74);
            this.cbjiaodu.Name = "cbjiaodu";
            this.cbjiaodu.Size = new System.Drawing.Size(59, 20);
            this.cbjiaodu.TabIndex = 14;
            this.cbjiaodu.Text = "true";
            // 
            // cbzhengfan
            // 
            this.cbzhengfan.FormattingEnabled = true;
            this.cbzhengfan.Items.AddRange(new object[] {
            "front",
            "back"});
            this.cbzhengfan.Location = new System.Drawing.Point(155, 124);
            this.cbzhengfan.Name = "cbzhengfan";
            this.cbzhengfan.Size = new System.Drawing.Size(60, 20);
            this.cbzhengfan.TabIndex = 16;
            this.cbzhengfan.Text = "front";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "身份证正反面";
            // 
            // cbfengxian
            // 
            this.cbfengxian.FormattingEnabled = true;
            this.cbfengxian.Items.AddRange(new object[] {
            "false",
            "true"});
            this.cbfengxian.Location = new System.Drawing.Point(155, 176);
            this.cbfengxian.Name = "cbfengxian";
            this.cbfengxian.Size = new System.Drawing.Size(59, 20);
            this.cbfengxian.TabIndex = 18;
            this.cbfengxian.Text = "true";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "是否开启身份证风险类型";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(246, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 41);
            this.label5.TabIndex = 19;
            this.label5.Text = "默认不检测，即：false。朝向是指输入图像是正常方向、逆时针旋转90/180/270度。可选值包括:- true：检测旋转角度并矫正识别；- false：不检测" +
    "旋转角度，针对摆放情况不可控制的情况建议本参数置为true。";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "\tfront：身份证含照片的一面；back：身份证带国徽的一面";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(246, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(424, 36);
            this.label7.TabIndex = 21;
            this.label7.Text = "是否开启身份证风险类型(身份证复印件、临时身份证、身份证翻拍、修改过的身份证)功能，默认不开启，即：false。可选值:true-开启；false-不开启";
            // 
            // frm_IDCardImgToTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 493);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbfengxian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbzhengfan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbjiaodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlocal);
            this.Controls.Add(this.tblocal);
            this.Name = "frm_IDCardImgToTxt";
            this.Text = "身份证图片信息提取";
            this.Load += new System.EventHandler(this.frm_IDCardImgToTxt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlocal;
        private System.Windows.Forms.TextBox tblocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbjiaodu;
        private System.Windows.Forms.ComboBox cbzhengfan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbfengxian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}