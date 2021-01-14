using MapleUtils.Core.Services;
using MapleUtils.Core.ViewModels.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MapleUtils.Core.ViewModels.Common
{

    public abstract class ViewModelBase : BindableBase
    {
        #region Abstracts

        protected abstract void InitVariables();
        protected abstract void InitCommands();
        protected abstract void OnNavigate(Type t);

        #endregion

        #region Delegates
        public delegate void OnMessageHandler(string message);
        public OnMessageHandler OnMessage;
        #endregion

        #region Properties

        protected object CurrentPage { get; set; }
        protected static IPageService pageService { get; set; }
        protected static ISettingService settingService { get; set; }

        #endregion

        public ViewModelBase()
        {
            InitCommands();
            InitVariables();
        }

        public DelegateCommand NavigateCommand { get; set; }

        public static void SetSettingService(ISettingService service)
        {
            settingService = service;
        }

    }
}
