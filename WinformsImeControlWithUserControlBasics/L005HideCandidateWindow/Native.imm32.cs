﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinformsImeControlWithUserControlBasics.L005HideCandidateWindow {
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

        // WM_IME
        public const int
            WM_IME_SETCONTEXT = 0x0281,
            WM_IME_NOTIFY = 0x0282,
            WM_IME_CONTROL = 0x0283,
            WM_IME_COMPOSITIONFULL = 0x0284,
            WM_IME_SELECT = 0x0285,
            WM_IME_CHAR = 0x0286,
            WM_IME_KEYDOWN = 0x0290,
            WM_IME_KEYUP = 0x0291,
            WM_IME_STARTCOMPOSITION = 0x010D,
            WM_IME_ENDCOMPOSITION = 0x010E,
            WM_IME_COMPOSITION = 0x010F,
            WM_IME_KEYLAST = 0x010F;


    }
}
