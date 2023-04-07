using Baidu.Aip.Ocr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 百度OCR
{
    public partial class frm_IDCardImgToTxt : Form
    {
        public frm_IDCardImgToTxt()
        {
            InitializeComponent();
        }
        string API_KEY = "cohIahxAt7HveHLYSHYK6G5N";
        string SECRET_KEY = "e8SAsDIWSK9NPUKviYiPQNlfaVDXQSY5";
        Ocr client;
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
                string local = filename.FileName.ToString();
                tblocal.Text = local;
                WriteTo(IdcardDemo(local));
                pictureBox1.Image = Image.FromFile(local);
            }
        }
        /// <summary>
        /// 在界面上显示
        /// </summary>
        /// <param name="returnstr"></param>
        public void WriteTo(string returnstr)
        {
            try
            {
                ReturnJsonForCard rj = CYQ.Data.Tool.JsonHelper.ToEntity<ReturnJsonForCard>(returnstr);
                AReturnJsonForCard acj = CYQ.Data.Tool.JsonHelper.ToEntity<AReturnJsonForCard>(rj.words_result);
                string resultstr = "";
                resultstr += "姓名：" + acj.姓名.words + "\r\n" + "性别：" + acj.性别.words + "\r\n" + "民族：" + acj.民族.words + "\r\n" + "出生：" + acj.出生.words + "\r\n" + "住址：" + acj.住址.words + "\r\n" + "公民身份号码：" + acj.公民身份号码.words + "\r\n";
                string card_direction = "";
                if (rj.direction == "-1")
                {
                    card_direction = "未定义";
                }
                else if (rj.direction == "0")
                {
                    card_direction = "正向";
                }
                else if (rj.direction == "1")
                {
                    card_direction = "逆时针90度";
                }
                else if (rj.direction == "2")
                {
                    card_direction = "逆时针180度";
                }
                else if (rj.direction == "3")
                {
                    card_direction = "逆时针270度";
                }
                resultstr += "图像方向：" + card_direction + "\r\n";

                string card_image_status = "";
                if (rj.image_status == "normal")
                {
                    card_image_status = "识别正常";
                }
                else if (rj.image_status == "reversed_side")
                {
                    card_image_status = "身份证正反面颠倒";
                }
                else if (rj.image_status == "non_idcard")
                {
                    card_image_status = "上传的图片中不包含身份证";
                }
                else if (rj.image_status == "blurred")
                {
                    card_image_status = "身份证模糊";
                }
                else if (rj.image_status == "other_type_card")
                {
                    card_image_status = "其他类型证照";
                }
                else if (rj.image_status == "over_exposure")
                {
                    card_image_status = "身份证关键字段反光或过曝";
                }
                else if (rj.image_status == "unknown")
                {
                    card_image_status = "未知状态";
                }

                resultstr += "识别状态：" + card_image_status + "\r\n";

                string card_risk_type = "";
                if (rj.risk_type == "normal")
                {
                    card_risk_type = "正常";
                }
                else if (rj.risk_type == "copy")
                {
                    card_risk_type = "复印件";
                }
                else if (rj.risk_type == "temporary")
                {
                    card_risk_type = "临时身份证";
                }
                else if (rj.risk_type == "screen")
                {
                    card_risk_type = "翻拍";
                }
                else if (rj.risk_type == "unknown")
                {
                    card_risk_type = "其他未知情况";
                }
                resultstr += "识别身份证类型：" + card_risk_type + "\r\n";

                resultstr += "图片编辑工具：" + rj.edit_tool + "\r\n";
                richTextBox1.Clear();
                richTextBox1.AppendText(resultstr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("解析出错，出错原因：" + ex.Message);
            }
        }

        private void frm_IDCardImgToTxt_Load(object sender, EventArgs e)
        {
            client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间

        }
        /// <summary>
        /// 身份证识别
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public string IdcardDemo(string filename)
        {
            bool cardjiaodu = cbjiaodu.Text == "true" ? true : false;
            string cardzhengfan = cbzhengfan.Text == "front" ? "front" : "back";
            bool cardfengxian = cbfengxian.Text == "true" ? true : false;

            var image = File.ReadAllBytes(filename);
            var idCardSide = "back";

            // 调用身份证识别，可能会抛出网络等异常，请使用try/catch捕获
            var result = client.Idcard(image, idCardSide);
            Console.WriteLine(result);
            // 如果有可选参数
            var options = new Dictionary<string, object>{
        {"detect_direction", cardjiaodu.ToString()},
        {"detect_risk", cardfengxian.ToString()},
                {"id_card_side",cardzhengfan.ToString() }
    };
            // 带参数调用身份证识别
            result = client.Idcard(image, idCardSide, options);
            return result.ToString();
        }
    }
}
