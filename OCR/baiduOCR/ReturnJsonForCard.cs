using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 百度OCR
{
    public class ReturnJsonForCard
    {
        public string log_id { get; set; }
        public string direction { get; set; }
        public string image_status { get; set; }
        public string risk_type { get; set; }
        public string edit_tool { get; set; }
        public string words_result_num { get; set; }
        public string words_result { get; set; }
    }
    public class AReturnJsonForCard
    {
        public BReturnJsonForCard 住址 { get; set; }
        public BReturnJsonForCard 出生 { get; set; }
        public BReturnJsonForCard 姓名 { get; set; }
        public BReturnJsonForCard 公民身份号码 { get; set; }
        public BReturnJsonForCard 性别 { get; set; }
        public BReturnJsonForCard 民族 { get; set; }
    }
    public class BReturnJsonForCard
    {
        public string location { get; set; }
        public string words { get; set; }
    }
}
