using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MapleUtils.Core.ViewModels.Common
{
    public abstract class ViewModelBase : BindableBase
    {
        protected abstract void InitVariables();
        protected abstract void InitCommands();
    }
}
