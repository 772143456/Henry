using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 百度OCR
{
    public class ReturnJson
    {
        public string log_id { get; set; }
        public int words_result_num { get; set; }
        public List<AReturnJson> words_result { get; set; }
    }
    public class AReturnJson
    {
        public string words { get; set; }
    }
}
