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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rich_Txt_Logs = new System.Windows.Forms.RichTextBox();
            this.Col_ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_Dll = new System.Windows.Forms.DataGridView();
            this.tab_Details = new System.Windows.Forms.TabPage();
            this.tabControl_Pages = new System.Windows.Forms.TabControl();
            this.tab_Code = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dll)).BeginInit();
            this.tab_Details.SuspendLayout();
            this.tabControl_Pages.SuspendLayout();
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
            this.rich_Txt_Logs.Location = new System.Drawing.Point(3, 129);
            this.rich_Txt_Logs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rich_Txt_Logs.Name = "rich_Txt_Logs";
            this.rich_Txt_Logs.Size = new System.Drawing.Size(1171, 180);
            this.rich_Txt_Logs.TabIndex = 0;
            this.rich_Txt_Logs.Text = "";
            // 
            // Col_ColumnCount
            // 
            this.Col_ColumnCount.DataPropertyName = "FieldCount";
            this.Col_ColumnCount.HeaderText = "字段数";
            this.Col_ColumnCount.Name = "Col_ColumnCount";
            this.Col_ColumnCount.Width = 90;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "Name";
            this.Col_Name.HeaderText = "名称";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.Width = 200;
            // 
            // Col_Number
            // 
            this.Col_Number.DataPropertyName = "Sort";
            this.Col_Number.HeaderText = "序号";
            this.Col_Number.Name = "Col_Number";
            this.Col_Number.Width = 50;
            // 
            // Col_Sel
            // 
            this.Col_Sel.DataPropertyName = "IsSel";
            this.Col_Sel.HeaderText = "选择";
            this.Col_Sel.Name = "Col_Sel";
            this.Col_Sel.Width = 50;
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
            this.dgv_Dll.Size = new System.Drawing.Size(1171, 125);
            this.dgv_Dll.TabIndex = 1;
            // 
            // tab_Details
            // 
            this.tab_Details.Controls.Add(this.dgv_Dll);
            this.tab_Details.Controls.Add(this.rich_Txt_Logs);
            this.tab_Details.Location = new System.Drawing.Point(4, 28);
            this.tab_Details.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Details.Name = "tab_Details";
            this.tab_Details.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Details.Size = new System.Drawing.Size(1177, 313);
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
            this.tabControl_Pages.Size = new System.Drawing.Size(1185, 345);
            this.tabControl_Pages.TabIndex = 0;
            // 
            // tab_Code
            // 
            this.tab_Code.Location = new System.Drawing.Point(4, 28);
            this.tab_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Code.Name = "tab_Code";
            this.tab_Code.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Code.Size = new System.Drawing.Size(1255, 709);
            this.tab_Code.TabIndex = 1;
            this.tab_Code.Text = "输出代码";
            this.tab_Code.UseVisualStyleBackColor = true;
            // 
            // pan_Fill
            // 
            this.pan_Fill.Controls.Add(this.tabControl_Pages);
            this.pan_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Fill.Location = new System.Drawing.Point(0, 199);
            this.pan_Fill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan_Fill.Name = "pan_Fill";
            this.pan_Fill.Size = new System.Drawing.Size(1185, 345);
            this.pan_Fill.TabIndex = 3;
            // 
            // txt_DatabaseName
            // 
            this.txt_DatabaseName.Location = new System.Drawing.Point(148, 138);
            this.txt_DatabaseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DatabaseName.Name = "txt_DatabaseName";
            this.txt_DatabaseName.Size = new System.Drawing.Size(181, 28);
            this.txt_DatabaseName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "数据库名称";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(148, 83);
            this.txt_Output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(516, 28);
            this.txt_Output.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "脚本输出位置";
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(532, 137);
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
            this.txt_DllFilePath.Location = new System.Drawing.Point(148, 25);
            this.txt_DllFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DllFilePath.Name = "txt_DllFilePath";
            this.txt_DllFilePath.Size = new System.Drawing.Size(516, 28);
            this.txt_DllFilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "DLL文件位置";
            // 
            // btn_SelectDLL
            // 
            this.btn_SelectDLL.Location = new System.Drawing.Point(382, 138);
            this.btn_SelectDLL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SelectDLL.Name = "btn_SelectDLL";
            this.btn_SelectDLL.Size = new System.Drawing.Size(109, 35);
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
            this.pan_Head.Size = new System.Drawing.Size(1185, 199);
            this.pan_Head.TabIndex = 2;
            // 
            // FrmScriptCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 544);
            this.Controls.Add(this.pan_Fill);
            this.Controls.Add(this.pan_Head);
            this.Name = "FrmScriptCore";
            this.Text = "FrmScriptCore";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dll)).EndInit();
            this.tab_Details.ResumeLayout(false);
            this.tabControl_Pages.ResumeLayout(false);
            this.pan_Fill.ResumeLayout(false);
            this.pan_Head.ResumeLayout(false);
            this.pan_Head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox rich_Txt_Logs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Number;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Sel;
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
    }
}