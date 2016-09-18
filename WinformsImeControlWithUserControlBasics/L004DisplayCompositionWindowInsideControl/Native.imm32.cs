using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinformsImeControlWithUserControlBasics.L004DisplayCompositionWindowInsideControl {
    public partial class Native {
        [DllImport("Imm32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr ImmGetContext(IntPtr hwnd);

        [DllImport("Imm32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ImmGetOpenStatus(IntPtr hIMC);

        [DllImport("Imm32.dll", CharSet = CharSet.Unicode)]
        public static extern int ImmReleaseContext(IntPtr hWnd, IntPtr hIMC);

        [DllImport("imm32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ImmSetCompositionWindow(IntPtr hIMC, ref COMPOSITIONFORM lpCompForm);

        // dwStyle for CANDIDATEFORM and COMPOSITIONWINDOW
        public const int
            CFS_DEFAULT = 0x0000,
            CFS_RECT = 0x0001,
            CFS_POINT = 0x0002,
            CFS_FORCE_POSITION = 0x0020,
            CFS_CANDIDATEPOS = 0x0040,
            CFS_EXCLUDE = 0x0080;

    }
}
