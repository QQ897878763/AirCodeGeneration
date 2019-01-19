using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Air.CodeGeneration.Common;
using Air.Currency.Frame.Library;
using Air.Currency.Frame.Library.Extension;
using Air.CodeGeneration.Data.Attribute;
using Air.CodeGeneration.Data.Core;
using Air.CodeGeneration.Data.Model;
using Air.T4.Common.Host;
using Microsoft.VisualStudio.TextTemplating;
using Air.CodeGeneration.Data.Core.Dto;

namespace Air.T4.Common
{
    public class T4EngineHelper
    {
        /// <summary>
        /// T4 模板引擎
        /// 需要执行文本模板则调用ProcessTemplate
        /// </summary>
        public static readonly Engine Engine = new Engine();

        /// <summary>
        /// 根据模板生成代码
        /// </summary>
        /// <param name="templateFilePath">模板文件路径</param>
        /// <param name="outputPath">输出路径</param>
        /// <param name="logAction">日志记录函数</param>
        public static void ProcessTemplate(string templateFilePath, string outputPath = null, Action<string> logAction = null)
        {

            var host = new BaseHost()
            {
                TemplateFile = templateFilePath
            };
            var input = File.ReadAllText(templateFilePath);
            var output = Engine.ProcessTemplate(input, host);
            if (string.IsNullOrWhiteSpace(outputPath))
            {
                outputPath = Path.Combine(Path.GetDirectoryName(templateFilePath), Path.GetFileNameWithoutExtension(templateFilePath) + host.FileExtension);
            }

            File.WriteAllText(outputPath, output, host.FileEncoding);

            if (logAction == null) return;
            foreach (CompilerError error in host.Errors)
            {
                logAction(error.ToString());
            }
        }

        /// <summary>
        /// The ProcessTemplate
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="templateFilePath">The templateFilePath<see cref="string"/></param>
        /// <param name="host">The host<see cref="T"/></param>
        /// <param name="outputPath">The outputPath<see cref="string"/></param>
        /// <param name="logAction">The logAction<see cref="Action{string}"/></param>
        public static string ProcessTemplate<T>(string templateFilePath = null, T host = null,
            string outputPath = null, Action<string> logAction = null)
            where T : BaseHost
        {

            if (!string.IsNullOrWhiteSpace(templateFilePath))
                host.TemplateFile = templateFilePath;

            string input = File.ReadAllText(templateFilePath);
            string output = Engine.ProcessTemplate(input, host);
            if (string.IsNullOrWhiteSpace(outputPath))
            {
                outputPath = Path.Combine(Path.GetDirectoryName(templateFilePath), Path.GetFileNameWithoutExtension(templateFilePath) + host.FileExtension);
            }
          
            File.WriteAllText(outputPath, output.Trim(), host.FileEncoding);

            if (logAction == null) return output;
            if (host.Errors?.Count > 0)
            {
                foreach (CompilerError error in host.Errors)
                {
                    if (error != null)
                        logAction(error.ToString());
                }
            }
            else
            {
                logAction(output);
            }
            return output;
        }

        /// <summary>
        /// 写入数据表至Database对象
        /// </summary>
        /// <param name="tableName">数据表名称</param>
        /// <param name="database">数据库对象</param>
        /// <param name="lstTypes">C#类型集合</param>
        /// <param name="logAction">日志委托</param>
        public static void SetDataBaseTableItems(string tableName, Database database, List<Type> lstTypes, Action<string> logAction = null)
        {
            DatabaseTable table = new DatabaseTable();
            Type t = lstTypes.Find(p => p.Name == tableName);

            table.Name = t.Name;
            table.FieldItems = new List<DatabaseTableField>();
            table.FieldRuleItems = new List<DataBaseFieldRuleAttribute>();
            DataBaseTableRuleAttribute attributeTable = t.GetCustomAttribute<DataBaseTableRuleAttribute>();
            if (attributeTable.IsCreateGnore) return;

            List<PropertyInfo> lstField = t.GetProperties()
                .Where(p => p.GetCustomAttribute<DataBaseFieldRuleAttribute>() != null)
                .ToList();
            foreach (var field in lstField)
            {
                DataBaseFieldRuleAttribute attribute = field.GetAttribute<DataBaseFieldRuleAttribute>();
                if (attribute.IsCreateGnore)
                    continue;
                if (attribute.Name.IsNullOrWhiteSpace())
                    attribute.Name = field.Name;
                if (attribute.DataType.IsNullOrWhiteSpace())
                {
                    logAction($"类型[{t.Name}]下的字段[{attribute.Name}]未指定数据类型!生成该类型的建表脚本失败!");
                    continue;
                }
                table.FieldRuleItems.Add(attribute);
            }
            //对字段进行排序(查询SQL 时候方便些...)
            table.FieldRuleItems = (from o in table.FieldRuleItems orderby o.Sort select o).ToList();
            database.TableItems.Add(table);
        }


        /// <summary>
        /// 写入数据表至Database对象
        /// </summary>
        /// <param name="tableName">数据表名称</param>
        /// <param name="database">数据库对象</param>
        /// <param name="lstTypes">C#类型集合</param>
        /// <param name="logAction">日志委托</param>
        public static void SetCoreDataBaseTableItems(string tableName, Air.CodeGeneration.Data.Core.Model.Database database, List<Type> lstTypes, Action<string> logAction = null)
        {
            Air.CodeGeneration.Data.Core.Model.DatabaseTable table = new Air.CodeGeneration.Data.Core.Model.DatabaseTable();
            Type t = lstTypes.Find(p => p.Name == tableName);

            table.Name = t.Name;
            table.FieldItems = new List<Air.CodeGeneration.Data.Core.Model.DatabaseTableField>();
            table.FieldRuleItems = new List<Air.CodeGeneration.Data.Core.Attribute.DataBaseFieldRuleAttribute>();
            Air.CodeGeneration.Data.Core.Attribute.DataBaseTableRuleAttribute attributeTable = t.GetCustomAttribute<Air.CodeGeneration.Data.Core.Attribute.DataBaseTableRuleAttribute>();
            if (attributeTable == null) return;
            if (attributeTable.IsCreateGnore) return;

            List<PropertyInfo> lstField = t.GetProperties()
                .Where(p => p.GetCustomAttribute<Air.CodeGeneration.Data.Core.Attribute.DataBaseFieldRuleAttribute>() != null)
                .ToList();
            foreach (var field in lstField)
            {
                Air.CodeGeneration.Data.Core.Attribute.DataBaseFieldRuleAttribute attribute = field.GetAttribute<Air.CodeGeneration.Data.Core.Attribute.DataBaseFieldRuleAttribute>();
                if (attribute.IsCreateGnore)
                    continue;
                if (attribute.Name.IsNullOrWhiteSpace())
                    attribute.Name = field.Name;
                if (attribute.DataType.IsNullOrWhiteSpace())
                {
                    logAction($"类型[{t.Name}]下的字段[{attribute.Name}]未指定数据类型!生成该类型的建表脚本失败!");
                    continue;
                }
                table.FieldRuleItems.Add(attribute);
            }
            //对字段进行排序(查询SQL 时候方便些...)
            table.FieldRuleItems = (from o in table.FieldRuleItems orderby o.Sort select o).ToList();
            database.TableItems.Add(table);
        }


        /// <summary>
        /// 获取反射DLL后的类型集合DataTable
        /// </summary>
        /// <param name="assemblyPath"></param>
        /// <param name="lstTypes"></param>
        /// <param name="platform"></param>
        /// <returns></returns>
        public static DataTable GetTypeDataTable(string assemblyPath, ref List<Type> lstTypes, int platform = 1)
        {
            DataTable dt = new DataTable();
            lstTypes = ReflectHandler.GetTypeList(assemblyPath);
            List<TypeReflectDto> lstDto = new List<TypeReflectDto>();
            if (platform != 1 && platform != 2)
            {
                throw new Exception($"无效的入参[{nameof(platform)}]");
            }
            for (int i = 0; i < lstTypes.Count; i++)
            {
                if (platform == 1)
                {
                    Air.CodeGeneration.Data.Core.Attribute.DataBaseTableRuleAttribute attr = lstTypes[i].GetCustomAttribute<Air.CodeGeneration.Data.Core.Attribute.DataBaseTableRuleAttribute>();
                    if (attr == null) continue;
                    if (attr.IsCreateGnore) continue;
                }
                if (platform == 2)
                {
                    Air.CodeGeneration.Data.Attribute.DataBaseTableRuleAttribute attr = lstTypes[i].GetCustomAttribute<Air.CodeGeneration.Data.Attribute.DataBaseTableRuleAttribute>();
                    if (attr == null) continue;
                    if (attr.IsCreateGnore) continue;
                }
                TypeReflectDto item = new TypeReflectDto();
                item.Sort = i + 1;
                item.Name = lstTypes[i].Name;
                item.FieldCount = lstTypes[i].GetProperties().Count().ToString();
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
    }
}
