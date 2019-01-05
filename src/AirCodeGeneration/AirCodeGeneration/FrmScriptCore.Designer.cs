namespace AirCodeGeneration
{
    partial class FrmScriptCore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScriptCore));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rich_Txt_Logs = new System.Windows.Forms.RichTextBox();
            this.dgv_Dll = new System.Windows.Forms.DataGridView();
            this.Col_Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Details = new System.Windows.Forms.TabPage();
            this.tabControl_Pages = new System.Windows.Forms.TabControl();
            this.tab_Code = new System.Windows.Forms.TabPage();
            this.rtb_Script = new System.Windows.Forms.RichTextBox();
            this.pan_Fill = new System.Windows.Forms.Panel();
            this.txt_DatabaseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.txt_DllFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SelectDLL = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pan_Head = new System.Windows.Forms.Panel();
            this.btn_OpenFileDir = new System.Windows.Forms.Button();
            this.cmb_Platform = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dll)).BeginInit();
            this.tab_Details.SuspendLayout();
            this.tabControl_Pages.SuspendLayout();
            this.tab_Code.SuspendLayout();
            this.pan_Fill.SuspendLayout();
            this.pan_Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // rich_Txt_Logs
            // 
            this.rich_Txt_Logs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rich_Txt_Logs.Location = new System.Drawing.Point(3, 450);
            this.rich_Txt_Logs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rich_Txt_Logs.Name = "rich_Txt_Logs";
            this.rich_Txt_Logs.Size = new System.Drawing.Size(1311, 159);
            this.rich_Txt_Logs.TabIndex = 0;
            this.rich_Txt_Logs.Text = "";
            // 
            // dgv_Dll
            // 
            this.dgv_Dll.AllowUserToAddRows = false;
            this.dgv_Dll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Sel,
            this.Col_Number,
            this.Col_Name,
            this.Col_ColumnCount});
            this.dgv_Dll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Dll.Location = new System.Drawing.Point(3, 4);
            this.dgv_Dll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Dll.Name = "dgv_Dll";
            this.dgv_Dll.RowHeadersVisible = false;
            this.dgv_Dll.RowTemplate.Height = 27;
            this.dgv_Dll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Dll.Size = new System.Drawing.Size(1311, 446);
            this.dgv_Dll.TabIndex = 1;
            // 
            // Col_Sel
            // 
            this.Col_Sel.DataPropertyName = "IsSel";
            this.Col_Sel.HeaderText = "选择";
            this.Col_Sel.Name = "Col_Sel";
            this.Col_Sel.Width = 60;
            // 
            // Col_Number
            // 
            this.Col_Number.DataPropertyName = "Sort";
            this.Col_Number.HeaderText = "序号";
            this.Col_Number.Name = "Col_Number";
            this.Col_Number.Width = 60;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "Name";
            this.Col_Name.HeaderText = "名称";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.Width = 200;
            // 
            // Col_ColumnCount
            // 
            this.Col_ColumnCount.DataPropertyName = "FieldCount";
            this.Col_ColumnCount.HeaderText = "字段数";
            this.Col_ColumnCount.Name = "Col_ColumnCount";
            this.Col_ColumnCount.Width = 90;
            // 
            // tab_Details
            // 
            this.tab_Details.Controls.Add(this.dgv_Dll);
            this.tab_Details.Controls.Add(this.rich_Txt_Logs);
            this.tab_Details.Location = new System.Drawing.Point(4, 28);
            this.tab_Details.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Details.Name = "tab_Details";
            this.tab_Details.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Details.Size = new System.Drawing.Size(1317, 613);
            this.tab_Details.TabIndex = 0;
            this.tab_Details.Text = "DLL详情";
            this.tab_Details.UseVisualStyleBackColor = true;
            // 
            // tabControl_Pages
            // 
            this.tabControl_Pages.Controls.Add(this.tab_Details);
            this.tabControl_Pages.Controls.Add(this.tab_Code);
            this.tabControl_Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Pages.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Pages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl_Pages.Name = "tabControl_Pages";
            this.tabControl_Pages.SelectedIndex = 0;
            this.tabControl_Pages.Size = new System.Drawing.Size(1325, 645);
            this.tabControl_Pages.TabIndex = 0;
            // 
            // tab_Code
            // 
            this.tab_Code.Controls.Add(this.rtb_Script);
            this.tab_Code.Location = new System.Drawing.Point(4, 28);
            this.tab_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Code.Name = "tab_Code";
            this.tab_Code.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Code.Size = new System.Drawing.Size(1317, 613);
            this.tab_Code.TabIndex = 1;
            this.tab_Code.Text = "输出代码";
            this.tab_Code.UseVisualStyleBackColor = true;
            // 
            // rtb_Script
            // 
            this.rtb_Script.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Script.Location = new System.Drawing.Point(3, 4);
            this.rtb_Script.Name = "rtb_Script";
            this.rtb_Script.Size = new System.Drawing.Size(1311, 605);
            this.rtb_Script.TabIndex = 0;
            this.rtb_Script.Text = "";
            // 
            // pan_Fill
            // 
            this.pan_Fill.Controls.Add(this.tabControl_Pages);
            this.pan_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Fill.Location = new System.Drawing.Point(0, 148);
            this.pan_Fill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan_Fill.Name = "pan_Fill";
            this.pan_Fill.Size = new System.Drawing.Size(1325, 645);
            this.pan_Fill.TabIndex = 3;
            // 
            // txt_DatabaseName
            // 
            this.txt_DatabaseName.Location = new System.Drawing.Point(127, 109);
            this.txt_DatabaseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DatabaseName.Name = "txt_DatabaseName";
            this.txt_DatabaseName.Size = new System.Drawing.Size(191, 28);
            this.txt_DatabaseName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "数据库名称";
            // 
            // txt_Output
            // 
            this.txt_Output.Enabled = false;
            this.txt_Output.Location = new System.Drawing.Point(127, 61);
            this.txt_Output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(1018, 28);
            this.txt_Output.TabIndex = 5;
            this.txt_Output.Click += new System.EventHandler(this.txt_Output_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "脚本输出位置";
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(1012, 100);
            this.btn_Execute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(133, 35);
            this.btn_Execute.TabIndex = 3;
            this.btn_Execute.Text = "生成SQL脚本";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // txt_DllFilePath
            // 
            this.txt_DllFilePath.Location = new System.Drawing.Point(127, 23);
            this.txt_DllFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DllFilePath.Name = "txt_DllFilePath";
            this.txt_DllFilePath.Size = new System.Drawing.Size(1018, 28);
            this.txt_DllFilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "DLL文件位置";
            // 
            // btn_SelectDLL
            // 
            this.btn_SelectDLL.Location = new System.Drawing.Point(901, 100);
            this.btn_SelectDLL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SelectDLL.Name = "btn_SelectDLL";
            this.btn_SelectDLL.Size = new System.Drawing.Size(91, 35);
            this.btn_SelectDLL.TabIndex = 0;
            this.btn_SelectDLL.Text = "选择DLL";
            this.btn_SelectDLL.UseVisualStyleBackColor = true;
            this.btn_SelectDLL.Click += new System.EventHandler(this.btn_SelectDLL_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pan_Head
            // 
            this.pan_Head.Controls.Add(this.btn_OpenFileDir);
            this.pan_Head.Controls.Add(this.cmb_Platform);
            this.pan_Head.Controls.Add(this.label4);
            this.pan_Head.Controls.Add(this.txt_DatabaseName);
            this.pan_Head.Controls.Add(this.label3);
            this.pan_Head.Controls.Add(this.txt_Output);
            this.pan_Head.Controls.Add(this.label2);
            this.pan_Head.Controls.Add(this.btn_Execute);
            this.pan_Head.Controls.Add(this.txt_DllFilePath);
            this.pan_Head.Controls.Add(this.label1);
            this.pan_Head.Controls.Add(this.btn_SelectDLL);
            this.pan_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_Head.Location = new System.Drawing.Point(0, 0);
            this.pan_Head.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan_Head.Name = "pan_Head";
            this.pan_Head.Size = new System.Drawing.Size(1325, 148);
            this.pan_Head.TabIndex = 2;
            // 
            // btn_OpenFileDir
            // 
            this.btn_OpenFileDir.Location = new System.Drawing.Point(1172, 62);
            this.btn_OpenFileDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OpenFileDir.Name = "btn_OpenFileDir";
            this.btn_OpenFileDir.Size = new System.Drawing.Size(129, 28);
            this.btn_OpenFileDir.TabIndex = 9;
            this.btn_OpenFileDir.Text = "打开输出目录";
            this.btn_OpenFileDir.UseVisualStyleBackColor = true;
            this.btn_OpenFileDir.Click += new System.EventHandler(this.btn_OpenFileDir_Click);
            // 
            // cmb_Platform
            // 
            this.cmb_Platform.FormattingEnabled = true;
            this.cmb_Platform.Location = new System.Drawing.Point(415, 108);
            this.cmb_Platform.Name = "cmb_Platform";
            this.cmb_Platform.Size = new System.Drawing.Size(158, 26);
            this.cmb_Platform.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "DLL平台";
            // 
            // FrmScriptCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 793);
            this.Controls.Add(this.pan_Fill);
            this.Controls.Add(this.pan_Head);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmScriptCore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成.NetCore实体DB脚本";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dll)).EndInit();
            this.tab_Details.ResumeLayout(false);
            this.tabControl_Pages.ResumeLayout(false);
            this.tab_Code.ResumeLayout(false);
            this.pan_Fill.ResumeLayout(false);
            this.pan_Head.ResumeLayout(false);
            this.pan_Head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox rich_Txt_Logs;
        private System.Windows.Forms.DataGridView dgv_Dll;
        private System.Windows.Forms.TabPage tab_Details;
        private System.Windows.Forms.TabControl tabControl_Pages;
        private System.Windows.Forms.TabPage tab_Code;
        private System.Windows.Forms.Panel pan_Fill;
        private System.Windows.Forms.TextBox txt_DatabaseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.TextBox txt_DllFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SelectDLL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pan_Head;
        private System.Windows.Forms.ComboBox cmb_Platform;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_Script;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ColumnCount;
        private System.Windows.Forms.Button btn_OpenFileDir;
    }
}