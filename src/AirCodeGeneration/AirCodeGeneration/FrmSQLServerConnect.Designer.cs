namespace AirCodeGeneration
{
    partial class FrmSQLServerConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSQLServerConnect));
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.cbbDatabase = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbShenFenRZ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbServerType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Connection = new System.Windows.Forms.Button();
            this.cbbServer = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(433, 406);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 29);
            this.Btn_Cancel.TabIndex = 24;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(277, 406);
            this.Btn_Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(100, 29);
            this.Btn_Confirm.TabIndex = 22;
            this.Btn_Confirm.Text = "确定";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // cbbDatabase
            // 
            this.cbbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDatabase.Enabled = false;
            this.cbbDatabase.FormattingEnabled = true;
            this.cbbDatabase.Items.AddRange(new object[] {
            "全部库"});
            this.cbbDatabase.Location = new System.Drawing.Point(216, 332);
            this.cbbDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDatabase.Name = "cbbDatabase";
            this.cbbDatabase.Size = new System.Drawing.Size(284, 23);
            this.cbbDatabase.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "数据库:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(216, 275);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(284, 25);
            this.txtPassword.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "登陆名:";
            // 
            // cbbShenFenRZ
            // 
            this.cbbShenFenRZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShenFenRZ.FormattingEnabled = true;
            this.cbbShenFenRZ.Items.AddRange(new object[] {
            "Windows 身份认证",
            "SQL Server 身份认证"});
            this.cbbShenFenRZ.Location = new System.Drawing.Point(216, 156);
            this.cbbShenFenRZ.Margin = new System.Windows.Forms.Padding(4);
            this.cbbShenFenRZ.Name = "cbbShenFenRZ";
            this.cbbShenFenRZ.Size = new System.Drawing.Size(284, 23);
            this.cbbShenFenRZ.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "身份认证:";
            // 
            // cbbServerType
            // 
            this.cbbServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbServerType.FormattingEnabled = true;
            this.cbbServerType.Items.AddRange(new object[] {
            "SQL Server2000",
            "SQL Server2005",
            "SQL Server2008",
            "SQL Server2012及以上版本"});
            this.cbbServerType.Location = new System.Drawing.Point(216, 103);
            this.cbbServerType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbServerType.Name = "cbbServerType";
            this.cbbServerType.Size = new System.Drawing.Size(284, 23);
            this.cbbServerType.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "服务器类型:";
            // 
            // Btn_Connection
            // 
            this.Btn_Connection.Location = new System.Drawing.Point(83, 406);
            this.Btn_Connection.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Connection.Name = "Btn_Connection";
            this.Btn_Connection.Size = new System.Drawing.Size(139, 29);
            this.Btn_Connection.TabIndex = 21;
            this.Btn_Connection.Text = "连接/连接测试";
            this.Btn_Connection.UseVisualStyleBackColor = true;
            // 
            // cbbServer
            // 
            this.cbbServer.FormattingEnabled = true;
            this.cbbServer.Location = new System.Drawing.Point(216, 45);
            this.cbbServer.Margin = new System.Windows.Forms.Padding(4);
            this.cbbServer.Name = "cbbServer";
            this.cbbServer.Size = new System.Drawing.Size(284, 23);
            this.cbbServer.TabIndex = 13;
            this.cbbServer.Text = "127.0.0.1";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(216, 217);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(284, 25);
            this.txtUserName.TabIndex = 17;
            this.txtUserName.Text = "sa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "服务器:";
            // 
            // FrmSQLServerConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 474);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.cbbDatabase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbShenFenRZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbServerType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Connection);
            this.Controls.Add(this.cbbServer);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSQLServerConnect";
            this.Text = "SQL Server连接";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.ComboBox cbbDatabase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbShenFenRZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbServerType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Connection;
        private System.Windows.Forms.ComboBox cbbServer;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
    }
}