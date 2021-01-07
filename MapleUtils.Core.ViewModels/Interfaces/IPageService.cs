using MapleUtils.Core.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MapleUtils.Core.ViewModels.Interfaces
{
    public interface IPageService
    {
        void NavigateTo<T>(object sender) where T : ViewModelBase, new ();
    }
}
