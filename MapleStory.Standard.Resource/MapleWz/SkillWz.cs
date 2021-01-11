using MapleStoryHelper.Framework.ResourceManager.Common;
using MapleStoryHelper.Standard.SkillLib.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WzComparerR2.CharaSim;
using WzComparerR2.Common.Extension;
using WzComparerR2.PluginBase;
using WzComparerR2.WzLib;

namespace MapleStoryHelper.Framework.ResourceManager
{
    public partial class MapleWz
    {
        public List<SkillBase> GetSkills()
        {
            List<SkillBase> retval = new List<SkillBase>();

            retval = GetDefaultSkills();
            retval.AddRange(GetVSkills1());
            retval.AddRange(GetVSkills2());

            LoadImage(ref retval);
            LoadText(ref retval);

            return retval;
        }

        private void LoadText(ref List<SkillBase> retval)
        {
            var img = StringWzStruct.WzNode.Nodes["Skill.img"].GetImage();

            for (int i=0; i < retval.Count; i++)
            {
                try
                {
                    retval[i].SkillName = retval[i].SkillCode.ToSkillName(img.Node);
                }
                catch(Exception e)
                {
                    //retval.Remove(retval[i]);
                }
            }
        }

        private void LoadImage(ref List<SkillBase> retval)
        {
            for(int i = 0; i < retval.Count; i++)
            {
                try
                {
                    MemoryStream stream = new MemoryStream();
                    if(retval[i].Icon.Bitmap != null)
                    {
                        retval[i].Icon.Bitmap.Save(stream, ImageFormat.Png);
                        retval[i].ImgByte = stream.ToArray();
                    }
                }
                catch(Exception e)
                {

                }
            }
        }

        private List<SkillBase> GetDefaultSkills()
        {
            List<SkillBase> retval = new List<SkillBase>();

            var nodes = SkillWzStruct.WzNode.Nodes;

            for (int i=0;i< nodes.Count; i++)
            {
                try
                {
                    List<SkillBase> temp = GetSkillsFromJobNode(nodes[i].GetImage().Node);
                    if(temp == null)
                    {
                        continue;
                    }

                    for (int j = 0; j < temp.Count; j++)
                    {
                        retval.Add(temp[j]);
                    }
                }
                catch(Exception e)
                {

                }
            }

            return retval;
        }

        private List<SkillBase> GetSkillsFromJobNode(Wz_Node node)
        {
            List<SkillBase> retval = new List<SkillBase>();

            var skills = node.FindNodeByPath("skill")?.Nodes;
            if(skills == null)
            {
                return null;
            }

            for (int i = 0; i < skills.Count; i++)
            {
                SkillBase newItem = SkillBase.CreateFromNode(skills[i], PluginManager.FindWz);
                newItem.SkillCode = skills[i].Text;
                retval.Add(newItem);
            }

            return retval;
        }

        private List<SkillBase> GetVSkills1()
        {
            List<SkillBase> retval = new List<SkillBase>();



            return retval;
        }

        private List<SkillBase> GetVSkills2()
        {
            List<SkillBase> retval = new List<SkillBase>();




            return retval;
        }
    }
}
