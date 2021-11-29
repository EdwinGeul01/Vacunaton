using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace P1_Vacunaton_21811039
{
    class MdiChanges
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;

        public static void removeborders(ref Main menu)
        {
            foreach (var mdi in menu.Controls.OfType<MdiClient>())
            {
                mdi.Dock = DockStyle.None;
                int window = GetWindowLong(mdi.Handle, GWL_EXSTYLE);
                window &= ~WS_EX_CLIENTEDGE;
                SetWindowLong(mdi.Handle, GWL_EXSTYLE, window);
                mdi.Dock = DockStyle.Fill;
            }
        }

    }
}
