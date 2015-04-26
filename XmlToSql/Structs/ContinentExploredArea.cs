using System;
using System.Xml.Serialization;

namespace XmlToSql.Structs
{
    public class ContinentExploredArea : IXmlToSql
    {
        [XmlElement("IDContinentObject")]
        public UInt32 ContinentObject;

        [XmlElement("IDExploredArea")]
        public Byte ExploredArea;

        [XmlElement("strExploredAreaName")]
        public String ExploredAreaName;

        [XmlElement("intXPLevel")]
        public Int32 XPLevel;

        public override String ToString()
        {
            return String.Format("ID: {0}-{2} | {1}", ContinentObject, ExploredAreaName, ExploredArea);
        }

        public String Table()
        {
            return "continent_area";
        }

        public String Columns()
        {
            return "ContinentObject, Area, XPLevel, AreaName";
        }

        public String Values()
        {
            return String.Format("{0}, {1}, {2}, '{3}'", ContinentObject, ExploredArea, XPLevel, ExploredAreaName.Replace("'", @"\'"));
        }
    }
}
