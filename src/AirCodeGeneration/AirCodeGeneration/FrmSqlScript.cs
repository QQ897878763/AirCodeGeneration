using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Air.CodeGeneration.Common;

namespace AirCodeGeneration
{
    public partial class FrmSqlScript : Form
    {
        public FrmSqlScript()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            string output = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Output");
            this.txt_Output.Text = output;
        }

        /// <summary>
        /// 选择dll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SelectDLL_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlgText = new OpenFileDialog())
            {
                dlgText.Filter = "|*.dll";
                if (dlgText.ShowDialog() == DialogResult.OK)
                {
                    txt_DllFilePath.Text = dlgText.FileName;
                    DataTable dt = ReflectHandler.GetTypeDataTable(dlgText.FileName);
                    this.dgv_Dll.DataSource = dt;
                }
            }
        }
    }
}
