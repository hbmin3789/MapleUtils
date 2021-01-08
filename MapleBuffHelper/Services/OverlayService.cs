using MapleBuffHelper.Common;
using MapleUtils.Core.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MapleBuffHelper.Services
{
    public class OverlayService : IOverlayService
    {
        private Window _overlayWindow;

        #region Constructor

        public OverlayService()
        {

        }

        public OverlayService(Window pverlayWindow)
        {
            _overlayWindow = pverlayWindow;
        }

        #endregion

        public void SetOverlayWindow(Window overlayWindow)
        {
            _overlayWindow = overlayWindow;
        }

        public void StartOverlay(string targetProcessName)
        {
            IntPtr hTargetWnd = Win32Service.GetProcessHandle(targetProcessName);
            Win32Service.SetWindowPosition(_overlayWindow, hTargetWnd);
        }
    }
}
