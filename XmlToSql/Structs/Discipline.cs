using System;
using System.Xml.Serialization;

namespace XmlToSql.Structs
{
    public class Discipline : IXmlToSql
    {
        [XmlElement("intCostToTrain")] public Int32 CostToTrain;
        [XmlElement("sinDisciplineType")] public Int32 DisciplineType;
        [XmlElement("IDDiscipline")] public Int32 Id;

        [XmlElement("tinLevelPrereq")] public Byte LevelPrereq;
        [XmlElement("strName")] public String Name;

        [XmlElement("IDDisciplinePrereq1")] public Int32 Prereq1;

        [XmlElement("IDDisciplinePrereq2")] public Int32 Prereq2;

        [XmlElement("IDDisciplinePrereq3")] public Int32 Prereq3;

        [XmlElement("IDDisciplinePrereq4")] public Int32 Prereq4;

        [XmlElement("IDDisciplinePrereq5")] public Int32 Prereq5;

        [XmlElement("IDRace")] public Int32 Race;

        [XmlElement("sinRanksPrereq1")] public Int16 RanksPrereq1;

        [XmlElement("sinRanksPrereq2")] public Int16 RanksPrereq2;

        [XmlElement("sinRanksPrereq3")] public Int16 RanksPrereq3;

        [XmlElement("sinRanksPrereq4")] public Int16 RanksPrereq4;

        [XmlElement("sinRanksPrereq5")] public Int16 RanksPrereq5;

        [XmlElement("strPrereq1")] public String StrPrereq1;

        [XmlElement("strPrereq2")] public String StrPrereq2;

        [XmlElement("strPrereq3")] public String StrPrereq3;

        [XmlElement("strPrereq4")] public String StrPrereq4;

        [XmlElement("strPrereq5")] public String StrPrereq5;

        [XmlElement("sinTier")] public Int32 Tier;
        [XmlElement("bitControlShop")] public String ControlShop;

        [XmlElement("bitFabricatedPlant")] public String FabricatedPlant;

        [XmlElement("bitReactor")] public String Reactor;

        public Boolean IsFabricatedPlant
        {
            get { return FabricatedPlant == "Tr"; }
        }

        public Boolean IsReactor
        {
            get { return Reactor == "Tr"; }
        }

        public Boolean IsControlShop
        {
            get { return ControlShop == "Tr"; }
        }

        public override String ToString()
        {
            return String.Format("ID: {0} | {1}", Id, Name);
        }

        public String Table()
        {
            return "discipline";
        }

        public String Columns()
        {
            return "Id, Race, DisciplinePrereq1, DisciplinePrereq2, DisciplinePrereq3, DisciplinePrereq4, DisciplinePrereq5, RankPrereq1, RankPrereq2, RankPrereq3, RankPrereq4, RankPrereq5, Name, LevelPrereq, FabricationPlant, Reactor, ControlShop";
        }

        public String Values()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, '{12}', {13}, {14}, {15}, {16}", Id, Race, Prereq1, Prereq2, Prereq3, Prereq4, Prereq5,
                RanksPrereq1, RanksPrereq2, RanksPrereq3, RanksPrereq4, RanksPrereq5, Name.Replace("'", @"\'"), LevelPrereq, IsFabricatedPlant.ToString().ToUpper(), IsReactor.ToString().ToUpper(), IsControlShop.ToString().ToUpper());
        }
    }
}
