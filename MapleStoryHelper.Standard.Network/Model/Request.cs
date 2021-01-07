using MapleStoryHelper.Standard.MobLib.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MapleStoryHelper.Standard.MNetwork.Model
{
    public class SkillSearchRequest
    {
        [JsonProperty("keyWord")]
        public string KeyWord { get; set; }
    }

    public class MobSearchRequest
    {
        [JsonProperty("keyWord")]
        public string KeyWord { get; set; }
        [JsonProperty("category")]
        public EMobMapCategory Category { get; set; }
    }
}
