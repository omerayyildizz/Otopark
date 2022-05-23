using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Data
{
    class Tarifeler : ICRUD<Tarife>
    {
        SqlConnection Conn;
        public Tarifeler(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public Tarife Bul(int id)
        {
            throw new NotImplementedException();
        }

        public void Ekle(Tarife model)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Tarife model)
        {
            throw new NotImplementedException();
        }

        public List<Tarife> Listesi()
        {
            throw new NotImplementedException();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
