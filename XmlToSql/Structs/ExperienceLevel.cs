using System;
using System.Xml.Serialization;

namespace XmlToSql.Structs
{
    public class ExperienceLevel : IXmlToSql
    {
        [XmlElement("iAttributePoints")]
        public Int32 AttributePoints;
        [XmlElement("intExperience")]
        public Int32 Experience;
        [XmlElement("IDLevel")]
        public UInt32 Id;

        [XmlElement("iResearchPoints")]
        public Int32 ResearchPoints;
        [XmlElement("iSkillPoints")]
        public Int32 SkillPoints;

        public override String ToString()
        {
            return String.Format("ID: {0} | {1}", Id, Experience);
        }

        public String Columns()
        {
            return "Level, Experience, SkillPoints, AttributePoints, ResearchPoints";
        }

        public String Table()
        {
            return "experience_level";
        }

        public String Values()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}", Id, Experience, SkillPoints, AttributePoints, ResearchPoints);
        }
    }
}
