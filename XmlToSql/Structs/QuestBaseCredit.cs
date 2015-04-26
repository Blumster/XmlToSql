using System;
using System.Xml.Serialization;

namespace XmlToSql.Structs
{
    public class QuestBaseCredit : IXmlToSql
    {
        [XmlElement("IDTargetLevel")] public Byte TargetLevel;
        [XmlElement("intBaseCredits")] public Int32 BaseCredits;

        public string Table()
        {
            return "quest_base_credit";
        }

        public string Columns()
        {
            return "Level, Credit";
        }

        public string Values()
        {
            return String.Format("{0}, {1}", TargetLevel, BaseCredits);
        }
    }
}
