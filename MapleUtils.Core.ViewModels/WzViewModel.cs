using MapleStoryHelper.Framework.ResourceManager;
using MapleStoryHelper.Standard.SkillLib.Model;
using MapleUtils.Core.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MapleUtils.Core.ViewModels
{
    public class WzViewModel : SkillListViewModelBase
    {
        #region Member

        private MapleWz _mapleWz;
        private object _lock;

        #endregion

        #region Properties

        public override string Keyword
        {
            get => _keyword;
            set
            {
                SetProperty(ref _keyword, value);
                FilteredSkillItems = new ObservableCollection<SkillBase>(SkillItems.Where(x=>x.SkillName.Contains(value)));
            }
        }

        private bool _isLoading = false;
        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
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
            base.InitVariables();
            _lock = new object();
            _mapleWz = new MapleWz();
        }

        protected override void InitCommands()
        {
            base.InitCommands();
        }

        #endregion

        #region Wz

        private void LoadMapleWz()
        {
            _mapleWz.LoadFile(@"C:\Nexon\Maple");
        }

        private async void LoadSkillList()
        {
            IsLoading = true;
            SkillItems = new ObservableCollection<SkillBase>(_mapleWz.GetSkills());
            FilteredSkillItems = new ObservableCollection<SkillBase>(SkillItems);
            IsLoading = false;
        }

        #endregion

        protected override void OnNavigate(Type t)
        {
            throw new NotImplementedException();
        }
    }
}
