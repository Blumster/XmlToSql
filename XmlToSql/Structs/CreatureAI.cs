using System;
using System.Globalization;
using System.Xml.Serialization;

namespace XmlToSql.Structs
{
    public class CreatureAI : IXmlToSql
    {
        [XmlElement("AICode")] public UInt32 Code;

        [XmlElement("strDescInternal")] public String Description;
        [XmlElement("AIID")] public UInt32 Id;

        [XmlElement("val1")] public String _val1;

        [XmlElement("val10")] public String _val10;

        [XmlElement("val11")] public String _val11;

        [XmlElement("val12")] public String _val12;

        [XmlElement("val13")] public String _val13;

        [XmlElement("val14")] public String _val14;

        [XmlElement("val15")] public String _val15;

        [XmlElement("val16")] public String _val16;

        [XmlElement("val17")] public String _val17;

        [XmlElement("val18")] public String _val18;

        [XmlElement("val19")] public String _val19;
        [XmlElement("val2")] public String _val2;

        [XmlElement("val20")] public String _val20;
        [XmlElement("val3")] public String _val3;

        [XmlElement("val4")] public String _val4;

        [XmlElement("val5")] public String _val5;

        [XmlElement("val6")] public String _val6;

        [XmlElement("val7")] public String _val7;

        [XmlElement("val8")] public String _val8;

        [XmlElement("val9")] public String _val9;

        public Single Val1
        {
            get { return _val1.Length == 0 ? 0.0f : Single.Parse(_val1, CultureInfo.InvariantCulture); }
        }

        public Single Val2
        {
            get { return _val2.Length == 0 ? 0.0f : Single.Parse(_val2, CultureInfo.InvariantCulture); }
        }

        public Single Val3
        {
            get { return _val3.Length == 0 ? 0.0f : Single.Parse(_val3, CultureInfo.InvariantCulture); }
        }

        public Single Val4
        {
            get { return _val4.Length == 0 ? 0.0f : Single.Parse(_val4, CultureInfo.InvariantCulture); }
        }

        public Single Val5
        {
            get { return _val5.Length == 0 ? 0.0f : Single.Parse(_val5, CultureInfo.InvariantCulture); }
        }

        public Single Val6
        {
            get { return _val6.Length == 0 ? 0.0f : Single.Parse(_val6, CultureInfo.InvariantCulture); }
        }

        public Single Val7
        {
            get { return _val7.Length == 0 ? 0.0f : Single.Parse(_val7, CultureInfo.InvariantCulture); }
        }

        public Single Val8
        {
            get { return _val8.Length == 0 ? 0.0f : Single.Parse(_val8, CultureInfo.InvariantCulture); }
        }

        public Single Val9
        {
            get { return _val9.Length == 0 ? 0.0f : Single.Parse(_val9, CultureInfo.InvariantCulture); }
        }

        public Single Val10
        {
            get { return _val10.Length == 0 ? 0.0f : Single.Parse(_val10, CultureInfo.InvariantCulture); }
        }

        public Single Val11
        {
            get { return _val11.Length == 0 ? 0.0f : Single.Parse(_val11, CultureInfo.InvariantCulture); }
        }

        public Single Val12
        {
            get { return _val12.Length == 0 ? 0.0f : Single.Parse(_val12, CultureInfo.InvariantCulture); }
        }

        public Single Val13
        {
            get { return _val13.Length == 0 ? 0.0f : Single.Parse(_val13, CultureInfo.InvariantCulture); }
        }

        public Single Val14
        {
            get { return _val14.Length == 0 ? 0.0f : Single.Parse(_val14, CultureInfo.InvariantCulture); }
        }

        public Single Val15
        {
            get { return _val15.Length == 0 ? 0.0f : Single.Parse(_val15, CultureInfo.InvariantCulture); }
        }

        public Single Val16
        {
            get { return _val16.Length == 0 ? 0.0f : Single.Parse(_val16, CultureInfo.InvariantCulture); }
        }

        public Single Val17
        {
            get { return _val17.Length == 0 ? 0.0f : Single.Parse(_val17, CultureInfo.InvariantCulture); }
        }

        public Single Val18
        {
            get { return _val18.Length == 0 ? 0.0f : Single.Parse(_val18, CultureInfo.InvariantCulture); }
        }

        public Single Val19
        {
            get { return _val19.Length == 0 ? 0.0f : Single.Parse(_val19, CultureInfo.InvariantCulture); }
        }

        public Single Val20
        {
            get { return _val20.Length == 0 ? 0.0f : Single.Parse(_val20, CultureInfo.InvariantCulture); }
        }

        public override String ToString()
        {
            return String.Format("ID: {0} | {1}", Id, Description);
        }

        public String Table()
        {
            return "creature_ai";
        }

        public String Columns()
        {
            return "Id, Code, Val1, Val2, Val3, Val4, Val5, Val6, Val7, Val8, Val9, Val10, Val11, Val12, Val13, Val14, Val15, Val16, Val17, Val18, Val19, Val20, Description";
        }

        public String Values()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, '{22}'",
                Id, Code, Val1.ToString(CultureInfo.InvariantCulture), Val2.ToString(CultureInfo.InvariantCulture), Val3.ToString(CultureInfo.InvariantCulture), Val4.ToString(CultureInfo.InvariantCulture),
                Val5.ToString(CultureInfo.InvariantCulture), Val6.ToString(CultureInfo.InvariantCulture), Val7.ToString(CultureInfo.InvariantCulture), Val8.ToString(CultureInfo.InvariantCulture),
                Val9.ToString(CultureInfo.InvariantCulture), Val10.ToString(CultureInfo.InvariantCulture), Val11.ToString(CultureInfo.InvariantCulture), Val12.ToString(CultureInfo.InvariantCulture),
                Val13.ToString(CultureInfo.InvariantCulture), Val14.ToString(CultureInfo.InvariantCulture), Val15.ToString(CultureInfo.InvariantCulture), Val16.ToString(CultureInfo.InvariantCulture),
                Val17.ToString(CultureInfo.InvariantCulture), Val18.ToString(CultureInfo.InvariantCulture), Val19.ToString(CultureInfo.InvariantCulture), Val20.ToString(CultureInfo.InvariantCulture),
                Description.Replace("'", @"\'"));
        }
    }
}
