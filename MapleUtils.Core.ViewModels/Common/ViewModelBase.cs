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
        public delegate void OnMessageHandler(string message);
        public OnMessageHandler OnMessage;
        protected object CurrentPage { get; set; }
        protected static IPageService pageService { get; set; }

        public DelegateCommand NavigateCommand { get; set; }

        protected abstract void InitVariables();
        protected abstract void InitCommands();
        protected abstract void OnNavigate(Type t);        

    }
}
