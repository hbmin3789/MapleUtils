using MapleBuffHelper.Common;
using MapleBuffHelper.Services;
using MapleBuffHelper.View;
using MapleUtils.Core.ViewModels;
using MapleUtils.Core.ViewModels.Common;
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
        public static OverlayWindow OverlayWindow { get; set; }
        public static Setting Setting { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            InitVariables();
            InitServices();
        }

        private void InitVariables()
        {
            OverlayService = new OverlayService();
            OverlayWindow = new OverlayWindow();
            Setting = new Setting();
        }

        private void InitServices()
        {
            ProcessViewModel.OverlayService = OverlayService;
            ViewModelBase.SetSettingService(Setting);
        }
    }
}
