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

namespace ReceiverB
{

    public partial class ReceiverB : Form
    {
        private const int WM_COPYDATA = 0x004A;
        public ReceiverB()
        {
            InitializeComponent();
            this.Text = "ReceiverB";
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_COPYDATA)
            {
                COPYDATASTRUCT cds = (COPYDATASTRUCT)m.GetLParam(typeof(COPYDATASTRUCT));
                string message = Marshal.PtrToStringAuto(cds.lpData);
                
                listBox1.Items.Add($"内容：{message}，"+$"时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
            }
            base.WndProc(ref m);
        }
    }
}
