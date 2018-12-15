namespace AirCodeGeneration
{
    partial class FrmMain
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
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_NETStandard = new System.Windows.Forms.TabPage();
            this.tabPage_Framework = new System.Windows.Forms.TabPage();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_NETStandard);
            this.tabControl_Main.Controls.Add(this.tabPage_Framework);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1198, 568);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_NETStandard
            // 
            this.tabPage_NETStandard.Location = new System.Drawing.Point(4, 28);
            this.tabPage_NETStandard.Name = "tabPage_NETStandard";
            this.tabPage_NETStandard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NETStandard.Size = new System.Drawing.Size(1190, 536);
            this.tabPage_NETStandard.TabIndex = 0;
            this.tabPage_NETStandard.Text = ".NET Standard";
            this.tabPage_NETStandard.UseVisualStyleBackColor = true;
            // 
            // tabPage_Framework
            // 
            this.tabPage_Framework.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Framework.Name = "tabPage_Framework";
            this.tabPage_Framework.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Framework.Size = new System.Drawing.Size(1190, 536);
            this.tabPage_Framework.TabIndex = 1;
            this.tabPage_Framework.Text = "Framework";
            this.tabPage_Framework.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 568);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_NETStandard;
        private System.Windows.Forms.TabPage tabPage_Framework;
    }
}