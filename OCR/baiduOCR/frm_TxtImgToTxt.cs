using Baidu.Aip.Ocr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 百度OCR
{
    public partial class frm_TxtImgToTxt : Form
    {
        //api文档  http://ai.baidu.com/docs#/OCR-API/top
        public frm_TxtImgToTxt()
        {
            InitializeComponent();
        }
        string API_KEY = "cohIahxAt7HveHLYSHYK6G5N";
        string SECRET_KEY = "e8SAsDIWSK9NPUKviYiPQNlfaVDXQSY5";
        Ocr client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间
        }

        private void btnurl_Click(object sender, EventArgs e)
        {
            string url = tburl.Text;//url地址
                                    //图片完整URL，URL长度不超过1024字节，URL对应的图片base64编码后大小不超过4M，最短边至少15px，最长边最大4096px,支持jpg/png/bmp格式，当image字段存在时url字段失效，不支持https的图片链接
            WriteTo(GeneralBasicUrlDemo(url));
            //获取网络图片
            try
            {
                Image O_Image = Image.FromStream(WebRequest.Create(url).GetResponse().GetResponseStream());
                //将获取的图片赋给图片框
                pictureBox1.Image = O_Image;
            }
            catch
            {

            }
        }

        private void btnlocal_Click(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog();
            filename.InitialDirectory = Application.StartupPath;
            filename.Filter = "All files(*.*)|*.*|image files|*.jpg;*.png;*.bmp";
            filename.FilterIndex = 2;
            filename.RestoreDirectory = true;
            if (filename.ShowDialog() == DialogResult.OK)
            {
                //本地图片.解析图像数据，base64编码后进行urlencode，要求base64编码和urlencode后大小不超过4M，最短边至少15px，最长边最大4096px,支持jpg/png/bmp格式，当image字段存在时url字段失效
                string local = filename.FileName.ToString();//本地图片的路径地址
                tblocal.Text = local;
                WriteTo(GeneralBasicDemo(local));
                pictureBox1.Image = Image.FromFile(local);
            }

        }
        /// <summary>
        /// 在界面上显示，解析图片
        /// </summary>
        /// <param name="returnstr"></param>
        public void WriteTo(string returnstr)
        {
            try
            {
                ReturnJson rj = CYQ.Data.Tool.JsonHelper.ToEntity<ReturnJson>(returnstr);
                string resultstr = "";
                for (int i = 0; i < rj.words_result.Count; i++)
                {
                    resultstr += rj.words_result[i].words + "\r\n";
                }
                richTextBox1.AppendText(resultstr + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("解析出错，出错原因：" + ex.Message);
            }
        }
        /// <summary>
        /// 本地图片识别
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public string GeneralBasicDemo(string filename)
        {
            var image = File.ReadAllBytes(filename);
            // 调用通用文字识别, 图片参数为本地图片，可能会抛出网络等异常，请使用try/catch捕获
            var result = client.GeneralBasic(image);
            Console.WriteLine(result);
            // 如果有可选参数
            var options = new Dictionary<string, object>{
        {"language_type", "CHN_ENG"},
        {"detect_direction", "true"},
        {"detect_language", "true"},
        {"probability", "true"}
    };
            // 带参数调用通用文字识别, 图片参数为本地图片
            result = client.GeneralBasic(image, options);
            return result.ToString();
        }
        /// <summary>
        /// 联网图片识别
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string GeneralBasicUrlDemo(string url)
        {
            // 调用通用文字识别, 图片参数为远程url图片，可能会抛出网络等异常，请使用try/catch捕获
            var result = client.GeneralBasicUrl(url);
            Console.WriteLine(result);
            // 如果有可选参数
            var options = new Dictionary<string, object>{
        {"language_type", "CHN_ENG"},
        {"detect_direction", "true"},
        {"detect_language", "true"},
        {"probability", "true"}
    };
            // 带参数调用通用文字识别, 图片参数为远程url图片
            result = client.GeneralBasicUrl(url, options);
            return result.ToString();
        }
        public void WriteToTxt(string returnstr,string savePath)
        {
            try
            {
                ReturnJson rj = CYQ.Data.Tool.JsonHelper.ToEntity<ReturnJson>(returnstr);
                string resultstr = "";
                for (int i = 0; i < rj.words_result.Count; i++)
                {
                    resultstr += rj.words_result[i].words + "\r\n";
                }
                //richTextBox1.AppendText(resultstr + "\r\n");
                //写入txt
                FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(resultstr);//开始写入值
                sr.Close();
                fs.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("解析出错，出错原因：" + ex.Message);
            }
        }
        public void WriteToWord(string returnstr,string savePath)
        {
            try
            {
                ReturnJson rj = CYQ.Data.Tool.JsonHelper.ToEntity<ReturnJson>(returnstr);
                string resultstr = "";
                for (int i = 0; i < rj.words_result.Count; i++)
                {
                    resultstr += rj.words_result[i].words + "\r\n";
                }
                //richTextBox1.AppendText(resultstr + "\r\n");
                //写入word
            }
            catch (Exception ex)
            {
                MessageBox.Show("解析出错，出错原因：" + ex.Message);
            }
        }
        private void btnTrans2Txt_Click(object sender,EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog=new FolderBrowserDialog();
            dialog.Description="请选择jpg所在文件夹,选择后将自动OCR并生成txt文件";
            if(dialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {               
                //将该文件夹的所有jpg读取，逐个转换，生成一个txt，并保存到当前文件夹
                DirectoryInfo folder = new DirectoryInfo(dialog.SelectedPath);
                FileSystemInfo fileinfo1 = folder as FileSystemInfo;
                List<string>allpicturePath=ListFiles(fileinfo1);

                FileStream fs1 = new FileStream(dialog.SelectedPath+"\\combine.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                //sw.WriteLine(this.textBox3.Text.Trim() + "+" + this.textBox4.Text);//开始写入值
                sw.Close();
                fs1.Close();

                foreach(var temPic in allpicturePath)
                {                    
                    //Console.WriteLine(temPic);
                    WriteToTxt(GeneralBasicDemo(temPic),dialog.SelectedPath+"\\combine.txt");
                } 
                MessageBox.Show(this, "成功向文件中写入内容！", "提示对话框", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }       

        //读取文件夹中的照片
        public List<string> ListFiles(FileSystemInfo info)
        {
            List<string>listPics=new List<string>();
            DirectoryInfo dir=info as DirectoryInfo;
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            for(int i=0;i<files.Length;i++)
            {
                FileInfo file = files[i] as FileInfo;
                //是文件
                if(file!=null)
                {
                    string extension=Path.GetExtension(file.Name);
                    if(extension.ToUpper()==".JPG")
                        listPics.Add(file.FullName);
                }
                else
                {
                    //针对子目录
                    //ListFiles(files[i]);
                }                   
            }

            return listPics;
        }
    }
}
