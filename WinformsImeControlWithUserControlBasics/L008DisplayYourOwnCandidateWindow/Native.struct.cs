using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinformsImeControlWithUserControlBasics.L008DisplayYourOwnCandidateWindow {
    public partial class Native {


        [StructLayout(LayoutKind.Sequential)]
        public struct COMPOSITIONFORM {
            public uint dwStyle;
            public POINT ptCurrentPos;
            public RECT rcArea;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int _Left;
            public int _Top;
            public int _Right;
            public int _Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT {
            public int x;
            public int y;
        }
    }
}
