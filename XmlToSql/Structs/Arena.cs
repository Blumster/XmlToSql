using System;
using System.Xml.Serialization;

namespace XmlToSql.Structs
{
    public class Arena : IXmlToSql
    {
        [XmlElement("sinArenaType")]
        public Byte ArenaType;
        [XmlElement("IDArena")]
        public Int32 IDArena;

        [XmlElement("IDContinentObject")]
        public Int32 IDContinentObject;

        [XmlElement("intLayer")]
        public Int32 Layer;

        [XmlElement("sinMaxNumTeams")]
        public Byte MaxNumTeams;

        [XmlElement("sinMaxPlayersPerTeam")]
        public Byte MaxPlayersPerTeam;
        [XmlElement("sinMinNumTeams")]
        public Byte MinNumTeams;
        [XmlElement("sinMinPlayersPerTeam")]
        public Byte MinPlayersPerTeam;

        [XmlElement("bitUseForLadder")]
        public String _useForLadder;

        public Boolean UseForLadder
        {
            get { return _useForLadder == "Tr"; }
        }

        public override String ToString()
        {
            return String.Format("ID: {0} | {1}", IDArena, IDContinentObject);
        }

        public String Table()
        {
            return "arena";
        }

        public String Columns()
        {
            return "Id, Type, ContinentObject, Layer, MinNumTeams, MaxNumTeams, MinPlayersPerTeam, MaxPlayersPerTeam, UseForLadder";
        }

        public String Values()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}",
                IDArena, ArenaType, IDContinentObject, Layer, MinNumTeams, MaxNumTeams, MinPlayersPerTeam, MaxPlayersPerTeam, UseForLadder.ToString().ToUpper());
        }
    }
}
