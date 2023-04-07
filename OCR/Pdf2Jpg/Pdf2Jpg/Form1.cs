using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PdfiumViewer;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;


namespace Pdf2Jpg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_pdfPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                //FileName:显示路径+名字
                this.txt_pdfPath.Text = openFileDialog.FileName;
            }
        }

        private void btn_PDF2JPEG_Click(object sender, EventArgs e)
        {
            string strpdfPath = txt_pdfPath.Text.ToString();
            var pdf = PdfiumViewer.PdfDocument.Load(strpdfPath);
            var pdfpage = pdf.PageCount;
            var pagesizes = pdf.PageSizes;

            for(int i=1;i<=pdfpage;i++)
            {
                Size size = new Size();
                size.Height = (int)pagesizes[(i - 1)].Height;
                size.Width=(int)pagesizes[(i - 1)].Width;
                //可以把“.jpg”写成其形式
                RenderPage(strpdfPath, i, size, txt_jpgPath.Text.ToString() + "\\" + txt_jpgName.Text.ToString()+"_"+i.ToString() + @".jpg");
            }
            MessageBox.Show("转换成功！");
        }
        public void RenderPage(string pdfPath,int pageNumber,System.Drawing.Size size,string outputPath,int dpi=300)
        {
            using (var document=PdfiumViewer.PdfDocument.Load(pdfPath))
            using (var stream=new FileStream(outputPath,FileMode.Create))
            using (var image=GetPageImage(pageNumber,size,document,dpi))
            {
                image.Save(stream, ImageFormat.Jpeg);
            }
        }
        private static System.Drawing.Image GetPageImage(int pageNumber,Size size,PdfiumViewer.PdfDocument document,int dpi)
        {
            return document.Render(pageNumber - 1, size.Width, size.Height, dpi, dpi, PdfRenderFlags.Annotations);
        }
        private void btn_jpgPath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                //SelectedPath:获取文件夹绝对路径，显示在textbox里面
                this.txt_jpgPath.Text = folder.SelectedPath;
            }
        }
    }
}
