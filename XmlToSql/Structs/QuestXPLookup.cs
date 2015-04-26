using System;
using System.Globalization;
using System.Xml.Serialization;

namespace XmlToSql.Structs
{
    public class QuestXPLookup : IXmlToSql
    {
        [XmlElement("IDQuestXPIndex")] public Byte QuestXPIndex;
        [XmlElement("rlLevelXP")] public Single LevelXP;

        public String Table()
        {
            return "quest_XP_lookup";
        }

        public String Columns()
        {
            return "Index, LevelXP";
        }

        public String Values()
        {
            return String.Format("{0}, {1}", QuestXPIndex, LevelXP.ToString(CultureInfo.InvariantCulture));
        }
    }
}
