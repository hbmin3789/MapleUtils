using MapleBuffHelper.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MapleBuffHelper.Services
{
    public class OverlayService
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

        public void StartOverlay()
        {
            //Win32Service.SetWindowPosition(_overlayWindow, );
        }
    }
}
