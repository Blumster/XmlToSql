using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using MySql.Data.MySqlClient;

namespace XmlToSql
{
    public class Program
    {
        public static void Main()
        {
            if (!File.Exists("wad.xml")) 
            {
                Console.WriteLine("Missing wad.xml!");
                return;
            }

            var des = new XmlSerializer(typeof(DataHolder));
            var dh = des.Deserialize(new FileStream("wad.xml", FileMode.Open, FileAccess.Read)) as DataHolder;
            if (dh == null)
            {
                Console.WriteLine("Unknown error deserializing");
                return;
            }

            // Specify which loaded field do you want to export to SQL
            //MoveToSql(dh.CreatureAIs);

            Console.ReadLine();
        }

        public static void MoveToSql(IEnumerable<IXmlToSql> items)
        {
            var itemArr = items.ToArray();
            if (itemArr.Length == 0)
                return;

            var table = itemArr[0].Table();
            var sql = new StringBuilder().AppendFormat("INSERT INTO `{0}` ({1}) VALUES ", table, itemArr[0].Columns());

            var first = true;

            foreach (var obj in itemArr)
            {
                if (!first)
                    sql.Append(",");
                else
                    first = false;

                sql.AppendFormat("({0})", obj.Values());
            }

            sql.Append(";");

            try
            {
                using (var conn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    conn.Open();

                    using (var del = new MySqlCommand(String.Format("DELETE FROM `{0}`;", table), conn))
                        del.ExecuteNonQuery();

                    using (var cmd = new MySqlCommand(sql.ToString(), conn))
                        cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to transfer from XML to SQL! Table: {0}", table);
                Console.WriteLine(e);
                return;
            }

            Console.WriteLine("Successfully transferred `{0}` from XML to SQL", table);
        }
    }
}
