using MapleBuffHelper.Properties;
using MapleUtils.Core.Services;
using MapleUtils.Core.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleBuffHelper.Common
{
    public class Setting : ISettingService
    {
        public void Load()
        {
            var skillViewModel = App.Current.Resources["SkillViewModel"] as SkillViewModel;

        }

        public void Save()
        {
            var skillViewModel = App.Current.Resources["SkillViewModel"] as SkillViewModel;

            Settings.Default.KeyboardLayer = SerializeObject(skillViewModel.KeyboardLayer);
            Settings.Default.UserSkillList = SerializeObject(skillViewModel.SkillItems);

            Settings.Default.Save();
        }

        private T DeserializeObject<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }

        private string SerializeObject(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
