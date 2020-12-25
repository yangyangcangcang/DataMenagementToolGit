using CDTY.BasicDataManagement.Common;
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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 导入excel数据
        private void btnImportExcelData_Click(object sender, EventArgs e)
        {
            OpenNewForm(new DataImportFrm());
        }

        private void OpenNewForm(Form newFrm)
        {
            foreach (Control control in this.splitContainer.Panel2.Controls)
            {
                if(control is Form)
                {
                    ((Form)control).Close();
                }
            }
            newFrm.TopLevel = false;
            newFrm.Parent = this.splitContainer.Panel2;
            newFrm.Dock = DockStyle.Fill;
            newFrm.Show();
        }
        #endregion

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //GBaseDB.CreateBaseGTable("Dome");
        }
    }
}
