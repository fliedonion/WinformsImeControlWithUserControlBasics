using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinformsImeControlWithUserControlBasics.L002AcceptText {
    public partial class Native {
        [DllImport("Imm32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr ImmGetContext(IntPtr hwnd);

        [DllImport("Imm32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ImmGetOpenStatus(IntPtr hIMC);

        [DllImport("Imm32.dll", CharSet = CharSet.Unicode)]
        public static extern int ImmReleaseContext(IntPtr hWnd, IntPtr hIMC);


    }
}
