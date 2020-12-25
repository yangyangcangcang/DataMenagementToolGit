using CDTY.BasicDataManagement.Common;
using CDTY.BasicDataManagement.DAL;
using CDTY.BasicDataManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDTY.BasicDataManagement.UI
{
    public partial class DataImportFrm : Form
    {

        private AccessSqlHelper mAccessSqlHelper = new AccessSqlHelper();

        private DataTable dataTable = null;

        public DataImportFrm()
        {
            InitializeComponent();
        }

        #region 选择Excel文件
        private void btnSelectExcelFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//打开文件对话框   
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Global.g_strExcelFilePath = openFileDialog.FileName;
            //获取Excel表中的sheet表名称
            IList<string> list = NpoiExcelHelper.GetExcelFileSheetNames(Global.g_strExcelFilePath);

            this.cmbSelectWorkerSheet.DataSource = new BindingList<string>(list);
        }
        #endregion

        #region 打开Excel表
        private void btnOpenSheet_Click(object sender, EventArgs e)
        {
            //获取选择的内容
            string strSelectSheet = this.cmbSelectWorkerSheet.SelectedItem.ToString();

            dataTable = NpoiExcelHelper.ExcelToDataTable(Global.g_strExcelFilePath, strSelectSheet, true);

            this.dgvExcelData.DataSource = dataTable;

            Global.g_strCurrentSheetName = strSelectSheet;

         

            //var list = dataTable.Select("隧道名称");
            //var rows = dataTable.Rows;

        }
        #endregion

        #region 导入数据库
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Global.g_strCurrentSheetName))
            {
                return;
            }
            try
            {
                ////导入数据库  
                ////1、生成三张表
                DBaseDB.CreateBaseDTable(Global.g_strCurrentSheetName);
                GBaseDB.CreateBaseGTable(Global.g_strCurrentSheetName);
                LBaseDB.CreateBaseLTable(Global.g_strCurrentSheetName);
                //2、向表中导入数据
                var list = (from d in dataTable.AsEnumerable() select d.Field<string>("站区名称")).ToList();
                //去重
                var distinctlist = list.Distinct();
                //创建对象   然后插入数据库
                int nIndex = 1;
                foreach (var item in distinctlist)
                {



                    BaseL baseL = new BaseL();
                    baseL.TableName = $"{Global.g_strCurrentSheetName}L";
                    baseL.stationname = item;
                    baseL.number = nIndex++;
                    //LBaseDB.Insert(Global.g_strCurrentSheetName, baseL);
                    mAccessSqlHelper.Insert(baseL);
                }
                //组装另一张表中的数据
                var list2 = (from d in dataTable.AsEnumerable() select d.Field<string>("隧道名称")).ToList();
                var distinctlist2 = list2.Distinct();
                nIndex = 1;
                foreach (var item in distinctlist2)
                {
                    BaseD baseD = new BaseD();
                    baseD.suidaoname = item;
                    baseD.number = nIndex++;
                    DBaseDB.Insert(Global.g_strCurrentSheetName, baseD);
                }

                //组装三张表




            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        #endregion
    }
}
