using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Air.Currency.Frame.Library;
using System.Windows.Forms;
using Air.CodeGeneration.Common;
using Air.Data.Core.Attribute;
using Air.Data.Core.Dto;
using System.Reflection;
using Air.Data.Core.Model;
using Air.T4.Common;
using Air.T4.Common.Host;
using Air.T4.Common.Model.Database;


namespace AirCodeGeneration
{
    public partial class FrmScriptCore : Form
    {
        private DataTable _dt_Models;
        private List<Type> _lst_Types;
        public FrmScriptCore()
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
                    _dt_Models = GetTypeDataTable(dlgText.FileName);
                    this.dgv_Dll.DataSource = _dt_Models;
                }
            }
        }

        /// <summary>
        /// 获取反射DLL后的类型集合DataTable
        /// </summary>
        /// <param name="assemblyPath">字符集路径</param>
        /// <returns></returns>
        private DataTable GetTypeDataTable(string assemblyPath)
        {
            DataTable dt = new DataTable();
            _lst_Types = ReflectHandler.GetTypeList(assemblyPath);
            List<TypeReflectDto> lstDto = new List<TypeReflectDto>();
            for (int i = 0; i < _lst_Types.Count; i++)
            {
                if (_lst_Types[i].GetCustomAttribute<DataBaseTableRuleAttribute>().IsCreateGnore)
                    continue;
                TypeReflectDto item = new TypeReflectDto();
                item.Sort = i + 1;
                item.Name = _lst_Types[i].Name;
                item.FieldCount = _lst_Types[i].GetProperties().Count().ToString();
                item.IsSel = true;
                lstDto.Add(item);
            }

            if (lstDto != null && lstDto.Count > 1)
            {
                lstDto.Add(new TypeReflectDto()
                {
                    FieldCount = "",
                    IsSel = true,
                    Sort = lstDto.Count + 1,
                    Name = "全选"
                });
            }

            dt = lstDto.ToDataTable();
            return dt;
        }

        /// <summary>
        /// 生成脚本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Execute_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dt_Models?.Rows?.Count <= 0 || _lst_Types == null)
                {
                    MessageBox.Show("没有可生成脚本的DLL!");
                    return;
                }

                //需要选择T4模板进行导出脚本
                string t4FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "T4Template", "TemplateCoreCreateDataBaseTable.sql.tt");
                Database database = new Database()
                {
                    Name = txt_DatabaseName.Text
                };
                database.TableItems = new List<DatabaseTable>();
                string scriptFileName = string.Empty;
                foreach (DataGridViewRow row in dgv_Dll.Rows)
                {
                    if (row.Cells["Col_Name"].Value.ToString() == "全选") continue;
                    if (row.Cells["Col_Sel"].Value.ToString() == "false") continue;
                    scriptFileName = row.Cells["Col_Name"].Value.ToString();
                    string tableName = row.Cells["Col_Name"].Value.ToString();
                    T4EngineHelper.SetCoreDataBaseTableItems(tableName, database, _lst_Types);
                }
                HostDatabase hostDatabase = new HostDatabase();
                hostDatabase.Name = txt_DatabaseName.Text;
                hostDatabase.TableItems = database.TableItems.MapTo(new List<HostDatabaseTable>());
                DataBaseCoreHost host = new DataBaseCoreHost(hostDatabase);

                string output = Path.Combine(txt_Output.Text, scriptFileName + ".sql");
                T4EngineHelper.ProcessTemplate(t4FilePath, host, output, LogWrite);
            }
            catch (Exception ex)
            {
                LogWrite(ex.Message);
            }
        }

        private void LogWrite(string logValue)
        {
            this.Invoke(new Action(() =>
            {
                this.rich_Txt_Logs.Text = string.Concat(Environment.NewLine, logValue);
            }));
        }
    }
}
