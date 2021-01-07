using MapleUtils.Core.ViewModels.Common;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MapleUtils.Core.ViewModels
{
    public class SearchViewModel : ViewModelBase
    {
        #region Properties

        private string _keyWord;
        public string KeyWord
        {
            get => _keyWord;
            set => SetProperty(ref _keyWord, value);
        }

        #endregion

        #region Commands

        public DelegateCommand SearchCommand { get; set; }

        #endregion

        public SearchViewModel()
        {

        }

        #region Initialize

        protected override void InitVariables()
        {

        }

        protected override void InitCommands()
        {
            
        }

        #endregion

    }
}
