using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ReceiverC
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int WM_COPYDATA = 0x004A;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            this.Title = "ReceiverC";
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            IntPtr hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;
            Dispatcher.BeginInvoke(new Action(() => { HookWndProc(hwnd); }), DispatcherPriority.Loaded);
        }

        private void HookWndProc(IntPtr hwnd)
        {
            System.Windows.Interop.HwndSource source = System.Windows.Interop.HwndSource.FromHwnd(hwnd);
            source.AddHook(new System.Windows.Interop.HwndSourceHook(WndProc));
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == WM_COPYDATA)
            {
                COPYDATASTRUCT cds = (COPYDATASTRUCT)Marshal.PtrToStructure(lParam, typeof(COPYDATASTRUCT));
                string message = Marshal.PtrToStringAuto(cds.lpData);
                listBox.Items.Add($"{message},时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} ");
                handled = true;
            }
            return IntPtr.Zero;
        }
    }
}
