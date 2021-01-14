using MapleStoryHelper.Standard.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MapleStoryHelper.Standard.SkillLib.Model
{
    public class KeySkill : SkillBase
    {
        private EWindowsKeyCode _keyCode;
        public EWindowsKeyCode KeyCode
        {
            get => _keyCode;
            set => SetProperty(ref _keyCode, value);
        }
    }
}
