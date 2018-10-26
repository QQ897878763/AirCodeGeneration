namespace Air.WeifenLuo.WinFormsUI
{
    partial class ToolWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolWindow));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("服务器");
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tview = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(231, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.ToolTipText = "新建数据库连接";
            // 
            // tview
            // 
            this.tview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tview.ImageIndex = 6;
            this.tview.ImageList = this.imageList1;
            this.tview.Location = new System.Drawing.Point(0, 27);
            this.tview.Margin = new System.Windows.Forms.Padding(4);
            this.tview.Name = "tview";
            treeNode1.Name = "节点0";
            treeNode1.Text = "服务器";
            this.tview.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tview.SelectedImageIndex = 0;
            this.tview.Size = new System.Drawing.Size(231, 325);
            this.tview.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "batch.ICO");
            this.imageList1.Images.SetKeyName(1, "bdata.ICO");
            this.imageList1.Images.SetKeyName(2, "cs.ICO");
            this.imageList1.Images.SetKeyName(3, "database.ICO");
            this.imageList1.Images.SetKeyName(4, "file.ICO");
            this.imageList1.Images.SetKeyName(5, "fileopen.ICO");
            this.imageList1.Images.SetKeyName(6, "msaccess.ICO");
            this.imageList1.Images.SetKeyName(7, "pz.ICO");
            this.imageList1.Images.SetKeyName(8, "server.ICO");
            this.imageList1.Images.SetKeyName(9, "sqlserver.ICO");
            this.imageList1.Images.SetKeyName(10, "table.ICO");
            // 
            // ToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 352);
            this.Controls.Add(this.tview);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ToolWindow";
            this.TabText = "服务视图";
            this.Text = "服务视图";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TreeView tview;
        private System.Windows.Forms.ImageList imageList1;
    }
}