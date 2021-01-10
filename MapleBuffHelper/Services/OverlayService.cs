using MapleBuffHelper.Common;
using MapleUtils.Core.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace MapleBuffHelper.Services
{
    public class OverlayService : IOverlayService
    {
        private object _lock;
        private bool _isThreadStart;
        private Thread _redrawThread;
        private Window _overlayWindow;
        private IntPtr _hTargetWnd;

        #region Constructor

        public OverlayService()
        {
            InitializeVariables();
        }

        public OverlayService(Window pverlayWindow) : this()
        {
            _overlayWindow = pverlayWindow;
        }

        #endregion

        #region Initialize

        private void InitializeVariables()
        {
            _lock = new object();

            InitOverlayThread();
        }

        private void InitOverlayThread()
        {
            _redrawThread = new Thread(() =>
            {
                while (true)
                {
                    if (!_isThreadStart)
                    {
                        break;
                    }
                    App.Current.Dispatcher.Invoke(() =>
                    {
                        Win32Service.SetWindowPosition(_overlayWindow, _hTargetWnd);
                    });
                    Thread.Sleep(1);
                }
            });
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

            StopOverlayWindowThread();
            InitOverlayThread();
            StartOverlayThread();

            return true;
        }

        #region Thread Methods

        private void StartOverlayThread()
        {
            lock (_lock)
            {
                _isThreadStart = true;
            }
            _redrawThread.Start();
        }

        private void StopOverlayWindowThread()
        {
            lock(_lock)
            {
                _isThreadStart = false;
                if (_redrawThread.IsAlive)
                {
                    _redrawThread?.Join();
                }
            }
        }

        #endregion

    }
}
