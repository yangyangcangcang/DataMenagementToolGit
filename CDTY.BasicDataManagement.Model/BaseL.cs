using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTY.BasicDataManagement.Model
{
    public partial class BaseL:BaseModel
    {
        public string stationname { get; set; }
        public int? jingdu { get; set; }
        public int? weidu { get; set; }
        public int? heig { get; set; }
    }
}
