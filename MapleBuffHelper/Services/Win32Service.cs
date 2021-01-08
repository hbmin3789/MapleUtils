using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;

namespace MapleBuffHelper.Common
{
    public class Win32Service
    {
        #region Winapi Classes
        private class LPPOINT
        {
            long x;
            long y;
        }

        private struct RECT
        {
            public int left;
            public int right;
            public int top;
            public int bottom;
        }

        #endregion

        [DllImport("user32.dll")]
        private static extern bool MoveToEx(IntPtr hdc, int X, int Y, LPPOINT lpPoint);
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

        public static IntPtr GetProcessHandle(string processName)
        {
            return FindWindowA("", processName);
        }

        public static void SetWindowPosition(Window window, IntPtr hTargetWnd)
        {
            var hOverlayWnd = new WindowInteropHelper(window).Handle;
            var dc = GetDC(hOverlayWnd);
            RECT rect = new RECT();
            GetWindowRect(hTargetWnd, ref rect);

            MoveToEx(dc, rect.left, rect.top, null);

            ReleaseDC(hOverlayWnd, dc);
        }
    }
}
