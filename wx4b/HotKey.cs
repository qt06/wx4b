using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QTCSharpTool
{
    class HotKey
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
         IntPtr hWnd, // handle to window  
         int id, // hot key identifier  
         KeyModifiers fsModifiers, // key-modifier options  
         Keys vk // virtual-key code  
        );

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
         IntPtr hWnd, // handle to window  
         int id // hot key identifier  
        );


        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }
    }
}
