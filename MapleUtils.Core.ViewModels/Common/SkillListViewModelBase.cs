using MapleStoryHelper.Standard.SkillLib.Model;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MapleUtils.Core.ViewModels.Common
{
    /// <summary>
    /// 스킬 리스트를 구현하는 UI에 사용될 뷰모델 클래스
    /// </summary>
    public class SkillListViewModelBase : ViewModelBase
    {
        #region Properties

        protected string _keyword;
        public string Keyword
        {
            get => _keyword;
            set => SetProperty(ref _keyword, value);
        }

        protected ObservableCollection<SkillBase> _skillItems;
        public ObservableCollection<SkillBase> SkillItems
        {
            get => _skillItems;
            set => SetProperty(ref _skillItems, value);
        }

        protected ObservableCollection<SkillBase> _filteredSkillItems;
        public ObservableCollection<SkillBase> FilteredSkillItems
        {
            get => _filteredSkillItems;
            set => SetProperty(ref _filteredSkillItems, value);
        }

        protected SkillBase _selectedSkill;
        public SkillBase SelectedSkill
        {
            get => _selectedSkill;
            set => SetProperty(ref _selectedSkill, value);
        }

        #endregion

        #region Commands

        public DelegateCommand SearchSkillCommand { get; set; }

        #endregion

        public SkillListViewModelBase() : base()
        {
            InitCommands();
            InitVariables();
        }

        #region InitializeVariables

        protected override void InitCommands()
        {
            SearchSkillCommand = new DelegateCommand(SearchSkill);
        }

        protected override void InitVariables()
        {
            _skillItems = new ObservableCollection<SkillBase>();
            _filteredSkillItems = new ObservableCollection<SkillBase>();
        }

        #endregion

        #region CommandMethods

        private void SearchSkill()
        {
            FilteredSkillItems = new ObservableCollection<SkillBase>(
                SkillItems.Where(x => x.SkillName.Contains(Keyword)));
        }

        #endregion

        protected override void OnNavigate(Type t)
        {
            throw new NotImplementedException();
        }
    }
}
