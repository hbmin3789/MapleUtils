using MapleUtils.Core.ViewModels.Common;
using MapleUtils.Core.ViewModels.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MapleUtils.Core.ViewModels
{
    public class ProcessViewModel : ViewModelBase
    {

        #region Fields

        public static IOverlayService OverlayService;

        #endregion

        #region Properties

        private bool _isOverlaying;
        public bool IsOverlaying
        {
            get => _isOverlaying;
            set => SetProperty(ref _isOverlaying, value);
        }

        private string _keyword;
        public string Keyword
        {
            get => _keyword;
            set
            {
                FilteredProcessItems = new ObservableCollection<Process>(
                        ProcessItems.Where(x=>x.ProcessName.Contains(value)));
                SetProperty(ref _keyword, value);
            }
                    
        }

        private Process _selectedProcess = null;
        public Process SelectedProcess
        {
            get => _selectedProcess;
            set => SetProperty(ref _selectedProcess, value);
        }

        private ObservableCollection<Process> _filteredProcessItems;
        public ObservableCollection<Process> FilteredProcessItems
        {
            get => _filteredProcessItems;
            set => SetProperty(ref _filteredProcessItems, value);
        }

        private ObservableCollection<Process> _processItems;
        public ObservableCollection<Process> ProcessItems
        {
            get => _processItems;
            set => SetProperty(ref _processItems, value);
        }

        #endregion

        #region Commands

        public DelegateCommand GetProcessCommand { get; set; }
        public DelegateCommand StartOverlayCommand { get; set; }

        #endregion

        public ProcessViewModel()
        {
            InitVariables();
            InitCommands();
        }

        #region Initialize

        protected override void InitVariables()
        {
            _processItems = new ObservableCollection<Process>();
            _filteredProcessItems = new ObservableCollection<Process>();
        }

        protected override void InitCommands()
        {
            GetProcessCommand = new DelegateCommand(GetProcess);
            StartOverlayCommand = new DelegateCommand(StartOverlay);
        }

        #endregion

        #region Command Methods

        private void GetProcess()
        {
            Process[] processCollection = Process.GetProcesses();
            ProcessItems = new ObservableCollection<Process>(processCollection);
            FilteredProcessItems = new ObservableCollection<Process>(ProcessItems);
        }

        protected override void OnNavigate(Type t)
        {

        }

        private void StartOverlay()
        {
            if(SelectedProcess != null)
            {
                var result = OverlayService.StartOverlay(SelectedProcess.MainModule.ModuleName);
                if (!result)
                {
                    OnMessage?.Invoke("");
                }
            }
        }

        #endregion
    }
}
