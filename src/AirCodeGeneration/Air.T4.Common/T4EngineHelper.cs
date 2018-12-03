using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Air.Currency.Frame.Library;
using Air.Currency.Frame.Library.Extension;
using Air.Data.Attribute;
using Air.Data.Model;
using Air.T4.Common.Host;
using Microsoft.VisualStudio.TextTemplating;

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
        public static void ProcessTemplate<T>(string templateFilePath = null, T host = null,
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
            if (!string.IsNullOrWhiteSpace(output))
            {
                output = output.Trim();
            }
            File.WriteAllText(outputPath, output, host.FileEncoding);

            if (logAction == null) return;
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
            database.TableItems.Add(table);
        }
    }
}
