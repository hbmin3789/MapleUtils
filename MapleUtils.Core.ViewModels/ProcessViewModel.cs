using MapleUtils.Core.ViewModels.Common;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace MapleUtils.Core.ViewModels
{
    public class ProcessViewModel : ViewModelBase
    {
        private ObservableCollection<Process> _processItems;
        public ObservableCollection<Process> ProcessItems
        {
            get => _processItems;
            set => SetProperty(ref _processItems, value);
        }

        public DelegateCommand GetProcessCommand { get; set; }

        public ProcessViewModel()
        {
            InitVariables();
            InitCommands();
        }

        #region Initialize

        protected override void InitVariables()
        {
            _processItems = new ObservableCollection<Process>();
        }

        protected override void InitCommands()
        {
            GetProcessCommand = new DelegateCommand(GetProcess);
        }

        #endregion

        #region Command Methods

        private void GetProcess()
        {
            Process[] processCollection = Process.GetProcesses();
            ProcessItems = new ObservableCollection<Process>(processCollection);
        }

        protected override void OnNavigate(Type t)
        {

        }

        #endregion
    }
}
