
namespace YouTubeChat_viewer
{
    partial class InitialDialog
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
            this.link_btn = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // link_btn
            // 
            this.link_btn.BackColor = System.Drawing.Color.Moccasin;
            this.link_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.link_btn.Font = new System.Drawing.Font("Alien League", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.link_btn.Location = new System.Drawing.Point(12, 12);
            this.link_btn.Name = "link_btn";
            this.link_btn.Size = new System.Drawing.Size(214, 29);
            this.link_btn.TabIndex = 0;
            this.link_btn.Text = "link to youtube";
            this.link_btn.UseVisualStyleBackColor = false;
            this.link_btn.Click += new System.EventHandler(this.link_btn_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Moccasin;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settings.Font = new System.Drawing.Font("Alien League", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settings.Location = new System.Drawing.Point(232, 11);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(214, 29);
            this.settings.TabIndex = 1;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Moccasin;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Alien League", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.Location = new System.Drawing.Point(452, 11);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(214, 29);
            this.close.TabIndex = 2;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // InitialDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(678, 50);
            this.Controls.Add(this.close);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.link_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InitialDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InitialDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button link_btn;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button close;
    }
}