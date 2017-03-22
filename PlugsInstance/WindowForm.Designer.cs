namespace PlugsInstance
{
    partial class WindowForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.MenuControl = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExtent = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(0, 24);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(292, 246);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "";
            // 
            // MenuControl
            // 
            this.MenuControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.MenuExtent});
            this.MenuControl.Location = new System.Drawing.Point(0, 0);
            this.MenuControl.Name = "MenuControl";
            this.MenuControl.Size = new System.Drawing.Size(292, 24);
            this.MenuControl.TabIndex = 1;
            this.MenuControl.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystemNew});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(50, 20);
            this.menuSystem.Text = "系统";
            // 
            // menuSystemNew
            // 
            this.menuSystemNew.Name = "menuSystemNew";
            this.menuSystemNew.Size = new System.Drawing.Size(152, 22);
            this.menuSystemNew.Text = "新建";
            this.menuSystemNew.Click += new System.EventHandler(this.menuSystemNew_Click);
            // 
            // MenuExtent
            // 
            this.MenuExtent.Name = "MenuExtent";
            this.MenuExtent.Size = new System.Drawing.Size(80, 20);
            this.MenuExtent.Text = "扩展插件";
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.MenuControl);
            this.MainMenuStrip = this.MenuControl;
            this.Name = "WindowForm";
            this.Text = "插件示例";
            this.Load += new System.EventHandler(this.WindowForm_Load);
            this.MenuControl.ResumeLayout(false);
            this.MenuControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.MenuStrip MenuControl;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuSystemNew;
        private System.Windows.Forms.ToolStripMenuItem MenuExtent;
    }
}

