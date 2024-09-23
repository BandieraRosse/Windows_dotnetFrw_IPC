using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

[StructLayout(LayoutKind.Sequential)]
public struct COPYDATASTRUCT
{
    public IntPtr dwData;  // 可以用来标识数据类型
    public int cbData;     // 数据大小
    public IntPtr lpData;  // 数据指针
}
