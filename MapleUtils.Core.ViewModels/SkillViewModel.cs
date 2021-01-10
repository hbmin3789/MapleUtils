using MapleStoryHelper.Standard.SkillLib.Model;
using MapleUtils.Core.ViewModels.Common;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MapleUtils.Core.ViewModels
{
    public class SkillViewModel : ViewModelBase
    {
        private ObservableCollection<SkillBase> _keyboardLayer;
        public ObservableCollection<SkillBase> KeyboardLayer
        {
            get => _keyboardLayer;
            set => SetProperty(ref _keyboardLayer, value);
        }            

        private ObservableCollection<SkillBase> _skillItems;
        public ObservableCollection<SkillBase> SkillItems
        {
            get => _skillItems;
            set => SetProperty(ref _skillItems, value);
        }

        private SkillBase _selectedKey;
        public SkillBase SelectedKey
        {
            get => _selectedKey;
            set => SetProperty(ref _selectedKey, value);
        }

        public DelegateCommand SetSkillCommand { get; set; }

        public SkillViewModel()
        {
            InitVariables();
            InitCommands();
        }


        protected override void InitVariables()
        {
            _skillItems = new ObservableCollection<SkillBase>();
            _keyboardLayer = new ObservableCollection<SkillBase>();
        }

        protected override void InitCommands()
        {
            SetSkillCommand = new DelegateCommand(SetSkill);
        }

        private void SetSkill()
        {
            var idx = KeyboardLayer.IndexOf(SelectedKey);
        }

        protected override void OnNavigate(Type t)
        {
            
        }
    }
}
