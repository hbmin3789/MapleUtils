using System;
using System.Collections.Generic;
using System.Text;

namespace MapleStoryHelper.Standard.Item.Extension
{
    public static class ItemExtension
    {
        public static string GetImageUrl(this ItemBase item)
        {
            return item == null ? "" : "data:image/png;base64," + Convert.ToBase64String(item.Image);
        }
    }
}
