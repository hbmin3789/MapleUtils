using MapleStoryHelper.Standard.MobLib.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WzComparerR2.CharaSim;

namespace MapleStoryHelper.Standard.MobLib.Model
{
    public class MobBase : Mob
    {
        private string _mobName;
        public string MobName
        {
            get => _mobName;
            set => SetProperty(ref _mobName, value);
        }

        private EMobMapCategory _mobMapCategory;
        public EMobMapCategory MobMapCategory
        {
            get => _mobMapCategory;
            set => SetProperty(ref _mobMapCategory, value);
        }

        private int _defense;
        public int Defense
        {
            get => _defense;
            set => SetProperty(ref _defense, value);
        }

        private object _imgBitmapSource;
        [JsonIgnore]
        public object ImgBitmapSource
        {
            get => _imgBitmapSource;
            set => SetProperty(ref _imgBitmapSource, value);
        }

        private byte[] _imgByte;
        public byte[] ImgByte
        {
            get => _imgByte;
            set => SetProperty(ref _imgByte, value);
        }
    }
}
