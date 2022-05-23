using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Data
{
    class Araclar : ICRUD<Arac>
    {
        SqlConnection Conn;
        public Araclar(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public Arac Bul(int id)
        {
            throw new NotImplementedException();
        }

        public void Ekle(Arac model)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Arac model)
        {
            throw new NotImplementedException();
        }

        public List<Arac> Listesi()
        {
            throw new NotImplementedException();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
