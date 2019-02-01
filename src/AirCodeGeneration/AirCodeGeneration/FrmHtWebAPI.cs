using Air.T4.Common;
using Air.T4.Common.Host;
using Air.T4.Common.Model.Database;
using AutoMapper;
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
using System.Reflection;


namespace AirCodeGeneration
{
    public partial class FrmHtWebAPI : Form
    {
        private DataTable _dt_Models;
        private List<Type> _lst_Types = null;

        public FrmHtWebAPI()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            string output = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Output");
            txt_Output.Text = output;
             
            dgv_Dll.CellContentClick += Dgv_Dll_CellContentClick;
            dgv_Dll.Click += Dgv_Dll_Click;
        }

        private void Dgv_Dll_Click(object sender, EventArgs e)
        {
            dgv_Dll.EndEdit();

        }

        private void Dgv_Dll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgv_Dll.Rows.Count - 1)
            {
                return;
            }

            //全选
            if (dgv_Dll.Rows[e.RowIndex].Cells["Col_Sel"].Value.ToString().ToLower() == "false")
            {
                foreach (DataGridViewRow dr in dgv_Dll.Rows)
                {
                    if (dr.Index == dgv_Dll.Rows.Count - 1) continue;
                    dr.Cells["Col_Sel"].Value = false;
                }
            }
            else
            {
                foreach (DataGridViewRow dr in dgv_Dll.Rows)
                {
                    if (dr.Index == dgv_Dll.Rows.Count - 1) continue;
                    dr.Cells["Col_Sel"].Value = true;
                }
            }
        }

   
 

        private void LoadDLL()
        {
            using (OpenFileDialog dlgText = new OpenFileDialog())
            {
                dlgText.Filter = "|*.dll";
                if (dlgText.ShowDialog() == DialogResult.OK)
                {
                    txt_DllFilePath.Text = dlgText.FileName;
                    _dt_Models = T4EngineHelper.GetTypeDataTable(dlgText.FileName, ref _lst_Types);
                    this.dgv_Dll.DataSource = _dt_Models;
                    ReadOnlySpan<char> span = dlgText.FileName.ToCharArray();
                    int index = dlgText.FileName.LastIndexOf("\\") + 1;
                    string toPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, span.Slice(index).ToString());

                    //这里需要copy dll文件到当前运行目录，否则T4引擎在执行时会有找不到加载项异常
                    if (File.Exists(toPath))
                        File.Delete(toPath);
                    File.Copy(dlgText.FileName, toPath);
                }
            }
        }

        /// <summary>
        /// 写入脚本
        /// </summary>
        /// <param name="platform"></param>
        private void WriteCreateScript(string t4FilePath, string nameSpace = "HY.Data.Custom.Dto", string outputPathAppend = "CreateInput")
        {
            if (_dt_Models?.Rows?.Count <= 0 || _lst_Types == null)
            {
                MessageBox.Show("没有可生成脚本的DLL!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Output.Text))
            {
                MessageBox.Show("输出目录为空!");
                return;
            }
            //TODO 需要根据Dgv选中的元素
            List<Type> lst = new List<Type>();
            foreach (DataGridViewRow row in dgv_Dll.Rows)
            {
                if (row.Cells["Col_Name"].Value.ToString() == "全选") continue;
                if (row.Cells["Col_Sel"].Value.ToString().ToLower() == "false") continue;
                lst.Add(_lst_Types.Find(p => p.Name == row.Cells["Col_Name"].Value.ToString()));
            }

            var modelTypes = lst.Where(t =>
                    t.IsClass && t.GetCustomAttributes<Air.CodeGeneration.Data.Core.Attribute.DataBaseTableRuleAttribute>().Count() > 0
                    && t.IsPublic && (!t.IsAbstract)).ToList();

            foreach (var item in modelTypes)
            {
                string output = Path.Combine(txt_Output.Text, string.Concat(item, outputPathAppend, ".cs"));
                if (!Directory.Exists(txt_Output.Text))
                    Directory.CreateDirectory(txt_Output.Text);
                string className = string.Concat(item.Name, outputPathAppend);
                HtWebApiHost host = new HtWebApiHost(item, nameSpace, className);
                rtb_Script.Text = T4EngineHelper.ProcessTemplate(t4FilePath, host, output, LogWrite);
            }

        }

        private void LogWrite(string logValue)
        {
            this.Invoke(new Action(() =>
            {
                this.rich_Txt_Logs.Text = string.Concat(Environment.NewLine, logValue);
            }));
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {

            string t4FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, T4Consts.FILE_Folder, T4Consts.WEB_API_CREATE_INPUT_HT);
            WriteCreateScript(t4FilePath);
        }

        private void btn_OpenFileDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer", $"{this.txt_Output.Text.Trim()}");
        }

        private void btn_SelectDLL_Click(object sender, EventArgs e)
        {
            LoadDLL();
        }

        private void txt_Output_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer", $"{this.txt_Output.Text.Trim()}");
        }
    }
}
