using System;
using System.Globalization;
using System.Xml.Serialization;

namespace XmlToSql.Structs
{
    public class QuestCreditsLookup : IXmlToSql
    {
        [XmlElement("IDQuestCreditsIndex")] public Byte QuestCreditsIndex;
        [XmlElement("rlLevelCredits")]      public Single LevelCredits;

        public String Table()
        {
            return "quest_credits_lookup";
        }

        public String Columns()
        {
            return "Index, LevelCredits";
        }

        public String Values()
        {
            return String.Format("{0}, {1}", QuestCreditsIndex, LevelCredits.ToString(CultureInfo.InvariantCulture));
        }
    }
}
