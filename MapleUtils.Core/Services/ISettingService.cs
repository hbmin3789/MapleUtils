using System;
using System.Collections.Generic;
using System.Text;

namespace MapleUtils.Core.Services
{
    public interface ISettingService
    {
        void Save();
        void Load();
    }
}
