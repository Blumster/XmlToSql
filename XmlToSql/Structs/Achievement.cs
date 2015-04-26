using System;
using System.Xml.Serialization;

namespace XmlToSql.Structs
{
    public class Achievement : IXmlToSql
    {
        [XmlElement("strDescription")]
        public String Description;
        [XmlElement("IDAchievement")]
        public Int32 IDAchievement;

        [XmlElement("IDSkillCast")]
        public Int32 IDSkillCast;
        [XmlElement("strLogoFilename")]
        public String LogoFileName;
        [XmlElement("strRequirements")]
        public String Requirements;

        [XmlElement("intSkillLevel")]
        public Int32 SkillLevel;
        [XmlElement("strTitle")]
        public String Title;

        public override String ToString()
        {
            return String.Format("ID: {0} | {1}", IDAchievement, Title);
        }

        public String Table()
        {
            return "achievement";
        }

        public String Columns()
        {
            return "Id, SkillId, SkillLevel, Title, Description, Requirements";
        }

        public String Values()
        {
            return String.Format("{0}, {1}, {2}, '{3}', '{4}', '{5}'", IDAchievement, IDSkillCast, SkillLevel, Title.Replace("'", @"\'"), Description.Replace("'", @"\'"), Requirements.Replace("'", @"\'"));
        }
    }
}
