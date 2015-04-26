using System;
using System.Globalization;
using System.Xml.Serialization;

namespace XmlToSql.Structs
{
    public class ContinentObject : IXmlToSql
    {
        [XmlElement("intContestedMission")]
        public Int32 ContestedMission;
        [XmlElement("IDContinentObject")]
        public UInt32 ContinentObjectId;

        [XmlElement("intCoordinates")]
        public Int32 Coordinates;
        [XmlElement("strDisplayName")]
        public String DisplayName;

        [XmlElement("CBIDImage")]
        public Int32 Image;
        [XmlElement("strMapFilename")]
        public String MapFileName;
        [XmlElement("intMaxLevel")]
        public Int32 MaxLevel;
        [XmlElement("intMaxPlayers")]
        public Int32 MaxPlayers;
        [XmlElement("intMaxVersion")]
        public Int32 MaxVersion;
        [XmlElement("intMinLevel")]
        public Int32 MinLevel;
        [XmlElement("intMinVersion")]
        public Int32 MinVersion;

        [XmlElement("IDObjective")]
        public Int32 Objective;
        [XmlElement("IDOwningFaction")]
        public Int32 OwningFaction;

        [XmlElement("rlPositionX")]
        public Single PositionX;

        [XmlElement("rlPositionZ")]
        public Single PositionZ;
        [XmlElement("rlRotation")]
        public Single Rotation;
        [XmlElement("bitDropBrokenItems")]
        public String _dropBrokenItems;
        [XmlElement("bitDropCommodities")]
        public String _dropCommodities;

        [XmlElement("bitIsArena")]
        public String _isArena;
        [XmlElement("bitIsClientOnly")]
        public String _isClientOnly;
        [XmlElement("bitIsPersistent")]
        public String _isPersistent;
        [XmlElement("bitIsTown")]
        public String _isTown;

        [XmlElement("bitPlayCreateSounds")]
        public String _playCreateSounds;

        public Boolean IsPersistent
        {
            get { return _isPersistent == "Tr"; }
        }

        public Boolean IsTown
        {
            get { return _isTown == "Tr"; }
        }

        public Boolean IsClientOnly
        {
            get { return _isClientOnly == "Tr"; }
        }

        public Boolean IsArena
        {
            get { return _isArena == "Tr"; }
        }

        public Boolean IsPlayCreateSounds
        {
            get { return _playCreateSounds == "Tr"; }
        }

        public Boolean IsDropCommodities
        {
            get { return _dropCommodities == "Tr"; }
        }

        public Boolean IsDropBrokenItems
        {
            get { return _dropBrokenItems == "Tr"; }
        }

        public override String ToString()
        {
            return String.Format("ID: {0} | {1}", ContinentObjectId, DisplayName);
        }

        public String Table()
        {
            return "continent_object";
        }

        public String Columns()
        {
            return "`Id`, `ContestedMission`, `Coordinates`, `DisplayName`, `Image`, `MapFileName`, `MinLevel`, `MaxLevel`, `MaxPlayers`, `MinVersion`, `MaxVersion`, `Objective`, `OwningFaction`, `PositionX`, `PositionZ`, `Rotation`, `IsPersistent`, `IsTown`, `IsClientOnly`, `IsArena`, `PlayCreateSounds`, `DropCommodities`, `DropBrokenItems`";
        }

        public String Values()
        {
            return String.Format("{0}, {1}, {2}, '{3}', {4}, '{5}', {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}",
                ContinentObjectId, ContestedMission, Coordinates, DisplayName.Replace("'", @"\'"), Image, MapFileName.Replace("'", @"\'"), MinLevel, MaxLevel, MaxPlayers, MinVersion, MaxVersion,
                Objective, OwningFaction, PositionX.ToString(CultureInfo.InvariantCulture), PositionZ.ToString(CultureInfo.InvariantCulture), Rotation.ToString(CultureInfo.InvariantCulture), IsPersistent.ToString().ToUpper(), IsTown.ToString().ToUpper(), IsClientOnly.ToString().ToUpper(), IsArena.ToString().ToUpper(), IsPlayCreateSounds.ToString().ToUpper(), IsDropCommodities.ToString().ToUpper(), IsDropBrokenItems.ToString().ToUpper());
        }
    }
}
