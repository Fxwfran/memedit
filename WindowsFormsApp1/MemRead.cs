using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MemoryRead
    {
        const int PROCESS_WM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;

        

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess,
          long lpBaseAddress, byte[] lpBuffer, UIntPtr dwSize, ref UIntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesWritten);

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        public static void Hack(int status, int pid, Int32 address)
        {
            Form1 frm1 = new Form1();
            var processHandle = OpenProcess(0x0020FFF, false, pid);
            int dec = status * 8;
            byte[] bytes = BitConverter.GetBytes(dec);

            for (int i = address; i < address + 64; i += 8)
            {
                WriteProcessMemory((int)processHandle, i, bytes, (int)bytes.Length, 0);
            }
        }
    }
}
