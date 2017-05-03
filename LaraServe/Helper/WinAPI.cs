using System;
using System.Runtime.InteropServices;

namespace LaraServe.Helper
{
    static class WinAPI
    {
        public const int CS_DROPSHADOW = 0x00020000;
        public const int WM_NCPAINT = 0x0085;
        public const int WM_ACTIVATEAPP = 0x001C;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        public const int HT_CLIENT = 0x1;
        public const int HT_CAPTION = 0x2;


        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wp, string lp);


    }
}
