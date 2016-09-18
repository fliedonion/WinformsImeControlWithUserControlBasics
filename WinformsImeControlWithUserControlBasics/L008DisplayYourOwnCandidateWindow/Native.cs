using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinformsImeControlWithUserControlBasics.L008DisplayYourOwnCandidateWindow {
    public partial class Native {
        // Window Style
        public const int 
            WS_EX_NOACTIVATE = 0x08000000,
            WS_EX_TOOLWINDOW = 0x00000080;

        // WM
        public const int
            WM_CHAR = 0x0102,
            WM_SETFOCUS = 0x0007;
    }
}
