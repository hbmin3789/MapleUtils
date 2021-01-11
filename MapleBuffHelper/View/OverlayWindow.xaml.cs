using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MapleBuffHelper.View
{
    /// <summary>
    /// OverlayWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OverlayWindow : Window
    {
        public OverlayWindow()
        {
            InitializeComponent();
            InitializeOverlayWindow();
        }

        private void InitializeOverlayWindow()
        {
            App.OverlayService.SetOverlayWindow(this);
            this.SourceInitialized += new EventHandler(OnSourceInitialized);
        }

        #region Win32

        private void OnSourceInitialized(object sender, EventArgs e)
        {
            HwndSource source = (HwndSource)PresentationSource.FromVisual(this);
            source.AddHook(new HwndSourceHook(HandleMessages));
        }

        private IntPtr HandleMessages(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            // 0x0112 == WM_SYSCOMMAND
            // 0xF020 == SC_MINIMIZE
            if (msg == 0x0112 && ((int)wParam & 0xFFF0) == 0xF020)
            {
                handled = true;
            }

            return IntPtr.Zero;
        }

        #endregion

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if(this.WindowState == WindowState.Minimized)
            {
                this.Show();
                this.Activate();
            }
        }
    }
}
