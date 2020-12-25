using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTY.BasicDataManagement.Model
{
    public partial class BaseG:BaseModel
    {
        public int stationnum { get; set; }
        public string stationname { get; set; }
        public int qiaosuibz { get; set; }
        public string qiaosuiname { get; set; }
        public string polenum { get; set; }
        public int kuaju { get; set; }
        public int jiegoubz { get; set; }
        public int quxianbz { get; set; }
        public string gonglibiao { get; set; }
        public string gongdianduanname { get; set; }
        public int gongdianduanbz { get; set; }
        public string linggongquname { get; set; }
        public int linggongqubz { get; set; }
        public string gongquname { get; set; }
        public int gongqubz { get; set; }
        public int daogao { get; set; }
        public int lachuzhi { get; set; }
        public string Sign_Type { get; set; }
        public string Sign_Gonglibiao { get; set; }
        public int Flage { get; set; }
        public int speed { get; set; }

    }
}
