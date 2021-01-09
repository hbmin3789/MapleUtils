using MapleBuffHelper.Common;
using MapleUtils.Core.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace MapleBuffHelper.Services
{
    public class OverlayService : IOverlayService
    {
        private Timer _redrawTimer;
        private Window _overlayWindow;
        private IntPtr _hTargetWnd;

        #region Constructor

        public OverlayService()
        {

        }

        public OverlayService(Window pverlayWindow)
        {
            _overlayWindow = pverlayWindow;
        }

        #endregion

        /// <summary>
        /// 오버레이할 윈도우를 지정합니다.
        /// </summary>
        /// <param name="overlayWindow">오버레이할 윈도우</param>
        public void SetOverlayWindow(Window overlayWindow)
        {
            _overlayWindow = overlayWindow;
        }

        /// <summary>
        /// 윈도우 위에 오버레이 합니다.
        /// </summary>
        /// <param name="targetProcessName">오버레이 할 프로세스 이름</param>
        /// <returns></returns>
        public bool StartOverlay(string targetWindowName)
        {
            return StartOverlay(Win32Service.GetProcessHandle(targetWindowName));
        }

        public bool StartOverlay(IntPtr targetWindowHandle)
        {
            _hTargetWnd = targetWindowHandle;
            if (_hTargetWnd == IntPtr.Zero)
            {
                return false;
            }

            _overlayWindow.Show();
            Win32Service.SetWindowPosition(_overlayWindow, _hTargetWnd);

            StartRedrawTimer();

            return true;
        }

        private void StartRedrawTimer()
        {
            if(_redrawTimer == null)
            {
                _redrawTimer = new Timer();
                _redrawTimer.Elapsed += _redrawTimer_Elapsed;
                _redrawTimer.Interval = 300;

                _redrawTimer.Start();
            }
        }

        private void _redrawTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Win32Service.SetWindowPosition(_overlayWindow, _hTargetWnd);
        }

        private void StopRedrawTimer()
        {
            _redrawTimer.Stop();
            _redrawTimer = null;
        }
    }
}
