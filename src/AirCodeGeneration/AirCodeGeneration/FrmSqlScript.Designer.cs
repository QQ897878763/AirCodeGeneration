namespace AirCodeGeneration
{
    partial class FrmSqlScript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSqlScript));
            this.pan_Head = new System.Windows.Forms.Panel();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.txt_DllFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SelectDLL = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pan_Fill = new System.Windows.Forms.Panel();
            this.tabControl_Pages = new System.Windows.Forms.TabControl();
            this.tab_Details = new System.Windows.Forms.TabPage();
            this.dgv_Dll = new System.Windows.Forms.DataGridView();
            this.rich_Txt_Logs = new System.Windows.Forms.RichTextBox();
            this.tab_Code = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Col_Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pan_Head.SuspendLayout();
            this.pan_Fill.SuspendLayout();
            this.tabControl_Pages.SuspendLayout();
            this.tab_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dll)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Head
            // 
            this.pan_Head.Controls.Add(this.txt_Output);
            this.pan_Head.Controls.Add(this.label2);
            this.pan_Head.Controls.Add(this.btn_Execute);
            this.pan_Head.Controls.Add(this.txt_DllFilePath);
            this.pan_Head.Controls.Add(this.label1);
            this.pan_Head.Controls.Add(this.btn_SelectDLL);
            this.pan_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_Head.Location = new System.Drawing.Point(0, 0);
            this.pan_Head.Name = "pan_Head";
            this.pan_Head.Size = new System.Drawing.Size(1123, 122);
            this.pan_Head.TabIndex = 0;
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(132, 69);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(459, 25);
            this.txt_Output.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "脚本输出位置";
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(624, 69);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(118, 29);
            this.btn_Execute.TabIndex = 3;
            this.btn_Execute.Text = "生成SQL脚本";
            this.btn_Execute.UseVisualStyleBackColor = true;
            // 
            // txt_DllFilePath
            // 
            this.txt_DllFilePath.Location = new System.Drawing.Point(132, 21);
            this.txt_DllFilePath.Name = "txt_DllFilePath";
            this.txt_DllFilePath.Size = new System.Drawing.Size(459, 25);
            this.txt_DllFilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DLL文件位置";
            // 
            // btn_SelectDLL
            // 
            this.btn_SelectDLL.Location = new System.Drawing.Point(624, 17);
            this.btn_SelectDLL.Name = "btn_SelectDLL";
            this.btn_SelectDLL.Size = new System.Drawing.Size(97, 29);
            this.btn_SelectDLL.TabIndex = 0;
            this.btn_SelectDLL.Text = "选择DLL";
            this.btn_SelectDLL.UseVisualStyleBackColor = true;
            this.btn_SelectDLL.Click += new System.EventHandler(this.btn_SelectDLL_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pan_Fill
            // 
            this.pan_Fill.Controls.Add(this.tabControl_Pages);
            this.pan_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Fill.Location = new System.Drawing.Point(0, 122);
            this.pan_Fill.Name = "pan_Fill";
            this.pan_Fill.Size = new System.Drawing.Size(1123, 661);
            this.pan_Fill.TabIndex = 1;
            // 
            // tabControl_Pages
            // 
            this.tabControl_Pages.Controls.Add(this.tab_Details);
            this.tabControl_Pages.Controls.Add(this.tab_Code);
            this.tabControl_Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Pages.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Pages.Name = "tabControl_Pages";
            this.tabControl_Pages.SelectedIndex = 0;
            this.tabControl_Pages.Size = new System.Drawing.Size(1123, 661);
            this.tabControl_Pages.TabIndex = 0;
            // 
            // tab_Details
            // 
            this.tab_Details.Controls.Add(this.dgv_Dll);
            this.tab_Details.Controls.Add(this.rich_Txt_Logs);
            this.tab_Details.Location = new System.Drawing.Point(4, 25);
            this.tab_Details.Name = "tab_Details";
            this.tab_Details.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Details.Size = new System.Drawing.Size(1115, 632);
            this.tab_Details.TabIndex = 0;
            this.tab_Details.Text = "DLL详情";
            this.tab_Details.UseVisualStyleBackColor = true;
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
            this.dgv_Dll.Location = new System.Drawing.Point(3, 3);
            this.dgv_Dll.Name = "dgv_Dll";
            this.dgv_Dll.RowHeadersVisible = false;
            this.dgv_Dll.RowTemplate.Height = 27;
            this.dgv_Dll.Size = new System.Drawing.Size(1109, 475);
            this.dgv_Dll.TabIndex = 1;
            // 
            // rich_Txt_Logs
            // 
            this.rich_Txt_Logs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rich_Txt_Logs.Location = new System.Drawing.Point(3, 478);
            this.rich_Txt_Logs.Name = "rich_Txt_Logs";
            this.rich_Txt_Logs.Size = new System.Drawing.Size(1109, 151);
            this.rich_Txt_Logs.TabIndex = 0;
            this.rich_Txt_Logs.Text = "";
            // 
            // tab_Code
            // 
            this.tab_Code.Location = new System.Drawing.Point(4, 25);
            this.tab_Code.Name = "tab_Code";
            this.tab_Code.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Code.Size = new System.Drawing.Size(1115, 632);
            this.tab_Code.TabIndex = 1;
            this.tab_Code.Text = "输出代码";
            this.tab_Code.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Col_Sel
            // 
            this.Col_Sel.DataPropertyName = "IsSel";
            this.Col_Sel.HeaderText = "选择";
            this.Col_Sel.Name = "Col_Sel";
            this.Col_Sel.Width = 50;
            // 
            // Col_Number
            // 
            this.Col_Number.DataPropertyName = "Sort";
            this.Col_Number.HeaderText = "序号";
            this.Col_Number.Name = "Col_Number";
            this.Col_Number.Width = 50;
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
            // FrmSqlScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 783);
            this.Controls.Add(this.pan_Fill);
            this.Controls.Add(this.pan_Head);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSqlScript";
            this.Text = "导出SQL脚本";
            this.pan_Head.ResumeLayout(false);
            this.pan_Head.PerformLayout();
            this.pan_Fill.ResumeLayout(false);
            this.tabControl_Pages.ResumeLayout(false);
            this.tab_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_Head;
        private System.Windows.Forms.TextBox txt_DllFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SelectDLL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Panel pan_Fill;
        private System.Windows.Forms.TabControl tabControl_Pages;
        private System.Windows.Forms.TabPage tab_Details;
        private System.Windows.Forms.TabPage tab_Code;
        private System.Windows.Forms.RichTextBox rich_Txt_Logs;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgv_Dll;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ColumnCount;
    }
}