namespace Diagnostics
{
    partial class DiagnosticsForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticsForm));
            this.ListGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateListButton = new System.Windows.Forms.Button();
            this.ListListBox = new System.Windows.Forms.ListBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListGroupBox
            // 
            this.ListGroupBox.Controls.Add(this.UpdateListButton);
            this.ListGroupBox.Controls.Add(this.ListListBox);
            this.ListGroupBox.Location = new System.Drawing.Point(25, 40);
            this.ListGroupBox.Name = "ListGroupBox";
            this.ListGroupBox.Size = new System.Drawing.Size(270, 380);
            this.ListGroupBox.TabIndex = 0;
            this.ListGroupBox.TabStop = false;
            this.ListGroupBox.Text = "系统进程列表";
            // 
            // UpdateListButton
            // 
            this.UpdateListButton.Location = new System.Drawing.Point(15, 327);
            this.UpdateListButton.Name = "UpdateListButton";
            this.UpdateListButton.Size = new System.Drawing.Size(240, 35);
            this.UpdateListButton.TabIndex = 1;
            this.UpdateListButton.Text = "更新系统进程信息(&E)";
            this.UpdateListButton.UseVisualStyleBackColor = true;
            this.UpdateListButton.Click += new System.EventHandler(this.UpdateListButton_Click);
            // 
            // ListListBox
            // 
            this.ListListBox.FormattingEnabled = true;
            this.ListListBox.ItemHeight = 15;
            this.ListListBox.Location = new System.Drawing.Point(15, 35);
            this.ListListBox.Name = "ListListBox";
            this.ListListBox.Size = new System.Drawing.Size(240, 274);
            this.ListListBox.Sorted = true;
            this.ListListBox.TabIndex = 0;
            this.ListListBox.Click += new System.EventHandler(this.ListListBox_Click);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.InfoTextBox);
            this.InfoGroupBox.Location = new System.Drawing.Point(328, 40);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(270, 380);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "进程的详细信息";
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(15, 35);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.InfoTextBox.Size = new System.Drawing.Size(240, 310);
            this.InfoTextBox.TabIndex = 0;
            this.InfoTextBox.WordWrap = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(622, 28);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // DiagnosticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.ListGroupBox);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "DiagnosticsForm";
            this.Text = "演示获取系统进程信息";
            this.Load += new System.EventHandler(this.DiagnosticsForm_Load);
            this.ListGroupBox.ResumeLayout(false);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ListGroupBox;
        private System.Windows.Forms.Button UpdateListButton;
        private System.Windows.Forms.ListBox ListListBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}

