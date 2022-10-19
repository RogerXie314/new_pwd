using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;

namespace new_pwd
{
    class Change
    {
        static void Main()
        {
            Application.Run(new Form1());
        }
        public void Change_pwd(string user_name, string pwd)
        {
            SecureString password = new SecureString();
            string pass = pwd;
            foreach (char c in pass)
            {
                password.AppendChar(c);
            }
            IntPtr pPassword = Marshal.SecureStringToGlobalAllocUnicode(password);
            USER_INFO_1003 ui = new USER_INFO_1003();
            ui.usri1003_password = Marshal.SecureStringToGlobalAllocUnicode(password);
            int err = NetUserSetInfo(".", user_name, 1003, ref ui, 0);
            Marshal.ZeroFreeGlobalAllocUnicode(pPassword);
            Console.Read();
        }
        [DllImport("Netapi32.dll")]
        extern public static int NetUserSetInfo(
        [MarshalAs(UnmanagedType.LPWStr)] string servername,
        [MarshalAs(UnmanagedType.LPWStr)] string username,
        int level,
        ref USER_INFO_1003 buf,
        int error);

        public struct USER_INFO_1003
        {
            public IntPtr usri1003_password;
        }
    }
}
