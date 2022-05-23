using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Data
{
    class GiseHareketleri : ICRUD<GiseHareket>
    {
        SqlConnection Conn;
        public GiseHareketleri(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public GiseHareket Bul(int id)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from GiseHareket Where Id=@ID", Conn);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            GiseHareket giseHareket = new GiseHareket();
            giseHareket.Id = -1;
            if (dr.HasRows) //bulduysan
            {
                giseHareket.Id = Convert.ToInt32(dr[0]);
                giseHareket.AracID = Convert.ToInt32(dr[1]);
                giseHareket.TarifeID = Convert.ToInt32(dr[2]);
                giseHareket.GirisT = Convert.ToDateTime(dr[3]);
                giseHareket.CikisT = Convert.ToDateTime(dr[4]);
                giseHareket.AlinacakUcret = Convert.ToDecimal(dr[5]);
            }
            Conn.Close();
            return giseHareket;
        }

        public void Ekle(GiseHareket model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Insert Into GiseHareket Values(@arac,@tarife,@giris,@cikis,@alinacak)", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@arac", model.AracID);
            cmd.Parameters.AddWithValue("@tarife", model.TarifeID);
            cmd.Parameters.AddWithValue("@giris", model.GirisT);
            cmd.Parameters.AddWithValue("@cikis", model.CikisT);
            cmd.Parameters.AddWithValue("@alinacak", model.AlinacakUcret);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public void Guncelle(GiseHareket model)
        {

            Conn.Open();
            SqlCommand cmd = new SqlCommand("Update GiseHareket  set AracID=@arac,TarifeID=@tarife,GirisT=@giris,CikisT=@cikis,AlinacakUcret=@alinacak where Id=@ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", model.Id);
            cmd.Parameters.AddWithValue("@arac", model.AracID);
            cmd.Parameters.AddWithValue("@tarife", model.TarifeID);
            cmd.Parameters.AddWithValue("@giris", model.GirisT);
            cmd.Parameters.AddWithValue("@cikis", model.CikisT);
            cmd.Parameters.AddWithValue("@alinacak", model.AlinacakUcret);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public List<GiseHareket> Listesi()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kategoriler", Conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<GiseHareket> kategoriler = new List<GiseHareket>();
            while (dr.Read())
            {
                GiseHareket giseHareket = new GiseHareket();
                giseHareket.Id = Convert.ToInt32(dr[0]);
                giseHareket.AracID = dr.GetString(1);
                giseHareket.AracID = dr.GetString(1);
                giseHareket.AracID = dr.GetString(1);
                giseHareket.AracID = dr.GetString(1);
                giseHareket.Add(giseHareket);
            }
            Conn.Close();
            return kategoriler;
        }

        public void Sil(int id)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Kategoriler where KategoriID=@ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
