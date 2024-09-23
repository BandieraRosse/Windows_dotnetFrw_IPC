using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenderA
{
    public partial class SenderA : Form
    {
        private const int WM_COPYDATA = 0x004A;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public SenderA()
        {
            InitializeComponent();
            this.Text = "SenderA";
        }

        private void SendMessageTo(string windowTitle, string message)
        {
            IntPtr hWnd = FindWindow(null, windowTitle);
            if (hWnd != IntPtr.Zero)
            {
                var data = new COPYDATASTRUCT
                {
                    dwData = IntPtr.Zero,
                    cbData = (message.Length + 1)*2,
                    lpData = Marshal.StringToHGlobalAuto(message)
                };

                SendMessage(hWnd, WM_COPYDATA, IntPtr.Zero, Marshal.UnsafeAddrOfPinnedArrayElement(new COPYDATASTRUCT[] { data }, 0));
                Marshal.FreeHGlobal(data.lpData);
            }
            else
            {
                MessageBox.Show("未找到目标窗口。");
            }
        }
        private void buttonB_MouseClick(object sender, MouseEventArgs e)
        {
            SendMessageTo("ReceiverB",textBox1.Text);
        }

        private void buttonC_MouseClick(object sender, MouseEventArgs e)
        {
            SendMessageTo("ReceiverC", textBox1.Text);
        }
    }

}
