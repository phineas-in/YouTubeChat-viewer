using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeChat_viewer
{
    public partial class ChatViewer : Form
    {
        string targetTitle = "Notepad2";
        Process theProcess = null;

        public ChatViewer()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);

            InitialDialog initD = new InitialDialog();
            DialogResult dr = initD.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                initD.Close();
            }
        }

        private void chatarea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
