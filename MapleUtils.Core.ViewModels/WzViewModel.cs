using MapleStoryHelper.Framework.ResourceManager;
using MapleStoryHelper.Standard.SkillLib.Model;
using MapleUtils.Core.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MapleUtils.Core.ViewModels
{
    public class WzViewModel : ViewModelBase
    {
        #region Member

        private MapleWz _mapleWz;
        private object _lock;

        #endregion

        #region Properties

        private bool _isLoading = false;
        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        private ObservableCollection<SkillBase> _skillItems;
        public ObservableCollection<SkillBase> SkillItems
        {
            get => _skillItems;
            set => SetProperty(ref _skillItems, value);
        }

        #endregion

        public WzViewModel() : base()
        {
            LoadMapleWz();
            LoadSkillList();
        }

        #region Initialize

        protected override void InitVariables()
        {
            _lock = new object();
            _mapleWz = new MapleWz();

            _skillItems = new ObservableCollection<SkillBase>();
        }

        protected override void InitCommands()
        {
            
        }

        private void LoadMapleWz()
        {
            _mapleWz.LoadFile(@"C:\Nexon\Maple");
        }

        private async void LoadSkillList()
        {
            lock (_lock)
            {
                IsLoading = true;
                SkillItems = new ObservableCollection<SkillBase>(_mapleWz.GetSkills());
                IsLoading = false;
            }
        }

        #endregion

        protected override void OnNavigate(Type t)
        {
            throw new NotImplementedException();
        }
    }
}
