using System;
using System.Collections.Generic;
using System.Text;

namespace MapleUtils.Core.ViewModels.Interfaces
{
    public interface IOverlayService
    {
        bool StartOverlay(string targetWindowName);
        bool StartOverlay(IntPtr targetWindowHandle);
    }
}
