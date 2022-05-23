using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Data
{
    interface ICRUD<T> where T : class
    {
        List<T> Listesi();
        void Ekle(T model);
        void Guncelle(T model);

        void Sil(int id);
        T Bul(int id);
    }
}
