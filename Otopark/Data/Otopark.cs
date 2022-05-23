using Otopark.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    class Otopark
    {

        private static string _connStr;
        public Otopark()
        {
            string strConn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            Araclar = new Araclar(strConn);
            Tarifeler = new Tarifeler(strConn);
            GiseHareketleri = new GiseHareketleri(strConn);
        }
        public Araclar Araclar { get; set; }
        public Tarifeler Tarifeler { get; set; }
        public GiseHareketleri GiseHareketleri { get; set; }
    }
}
