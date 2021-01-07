using MapleUtils.Core.ViewModels.Common;
using MapleUtils.Core.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MapleItemSearch.Services
{
    public class PageService : IPageService
    {
        /// <summary>
        /// 페이지 이동
        /// </summary>
        /// <typeparam name="T">ViewModel 타입</typeparam>
        public void NavigateTo<T>(object sender) where T : ViewModelBase, new()
        {
            var window = sender as Window;
            window.DataContext = new T();
        }
    }
}
