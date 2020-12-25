using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTY.BasicDataManagement.Common
{
    public class Global
    {
        /// <summary>
        /// Excel文件路径
        /// </summary>
        public static string g_strExcelFilePath = string.Empty;

        /// <summary>
        /// 当前sheet表的名称
        /// </summary>
        public static string  g_strCurrentSheetName { get; set; }
    }
}
