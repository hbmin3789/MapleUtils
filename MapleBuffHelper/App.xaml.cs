using MapleBuffHelper.Services;
using MapleUtils.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MapleBuffHelper
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public static OverlayService OverlayService { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            InitVariables();
            InitServices();
        }

        private void InitVariables()
        {
            OverlayService = new OverlayService();
        }

        private void InitServices()
        {
            ProcessViewModel.OverlayService = OverlayService;
        }
    }
}
