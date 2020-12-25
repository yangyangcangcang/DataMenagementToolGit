using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTY.BasicDataManagement.Model
{
    public class BaseModel
    {
        public int number { get; set; }
        //无奈之举   由于每次都要创建表  表名不固定  所以将表名写在这里
        public string TableName { get; set; }
    }
}
