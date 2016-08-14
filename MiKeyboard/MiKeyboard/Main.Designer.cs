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
            this.cb_effects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_effects
            // 
            this.cb_effects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_effects.FormattingEnabled = true;
            this.cb_effects.Location = new System.Drawing.Point(13, 13);
            this.cb_effects.Name = "cb_effects";
            this.cb_effects.Size = new System.Drawing.Size(259, 21);
            this.cb_effects.TabIndex = 0;
            this.cb_effects.SelectedIndexChanged += new System.EventHandler(this.cb_effects_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb_effects);
            this.Name = "Main";
            this.Text = "MiKeyboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_effects;
    }
}

