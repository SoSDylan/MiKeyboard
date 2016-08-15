namespace MiKeyboard
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cb_effects = new MetroFramework.Controls.MetroComboBox();
            this.panel = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmi_show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.csmi_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_effects
            // 
            this.cb_effects.FormattingEnabled = true;
            this.cb_effects.ItemHeight = 23;
            this.cb_effects.Location = new System.Drawing.Point(168, 23);
            this.cb_effects.Name = "cb_effects";
            this.cb_effects.Size = new System.Drawing.Size(193, 29);
            this.cb_effects.TabIndex = 1;
            this.cb_effects.UseSelectable = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.metroTabPage1);
            this.panel.Location = new System.Drawing.Point(6, 58);
            this.panel.Name = "panel";
            this.panel.SelectedIndex = 0;
            this.panel.Size = new System.Drawing.Size(448, 215);
            this.panel.Style = MetroFramework.MetroColorStyle.Lime;
            this.panel.TabIndex = 2;
            this.panel.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(440, 173);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "MiKeyboard";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MiKeyboard";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmi_show,
            this.toolStripSeparator1,
            this.csmi_quit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 54);
            // 
            // csmi_show
            // 
            this.csmi_show.Name = "csmi_show";
            this.csmi_show.Size = new System.Drawing.Size(103, 22);
            this.csmi_show.Text = "Show";
            this.csmi_show.Click += new System.EventHandler(this.csmi_show_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // csmi_quit
            // 
            this.csmi_quit.Name = "csmi_quit";
            this.csmi_quit.Size = new System.Drawing.Size(103, 22);
            this.csmi_quit.Text = "Quit";
            this.csmi_quit.Click += new System.EventHandler(this.csmi_quit_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::MiKeyboard.Properties.Resources.folder;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(367, 23);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(29, 29);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 280);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.cb_effects);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "MiKeyboard";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.panel.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cb_effects;
        private MetroFramework.Controls.MetroTabControl panel;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem csmi_show;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem csmi_quit;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

