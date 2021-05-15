
namespace YouTubeChat_viewer
{
    partial class ChatViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatViewer));
            this.chatarea = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // chatarea
            // 
            this.chatarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatarea.ForeColor = System.Drawing.Color.ForestGreen;
            this.chatarea.Location = new System.Drawing.Point(0, 0);
            this.chatarea.Name = "chatarea";
            this.chatarea.RightMargin = 4;
            this.chatarea.Size = new System.Drawing.Size(462, 593);
            this.chatarea.TabIndex = 0;
            this.chatarea.Text = "";
            this.chatarea.TextChanged += new System.EventHandler(this.chatarea_TextChanged);
            // 
            // ChatViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(462, 593);
            this.Controls.Add(this.chatarea);
            this.Font = new System.Drawing.Font("Abduction III", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat viewer - Phineas Solutions";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatarea;
    }
}

