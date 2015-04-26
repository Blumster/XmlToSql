using System;

namespace XmlToSql
{
    public interface IXmlToSql
    {
        String Table();
        String Columns();
        String Values();
    }
}
