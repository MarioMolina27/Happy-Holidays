using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Holidays.Models
{
    public static class HotelsOrm
    {
        public static List<hoteles> SelectAll()
        {
            return Orm.bd.hoteles.ToList();
        }

        public static List<hoteles> SelectByNom(String nom)
        {
            return Orm.bd.hoteles.Where(p => p.nombre.Contains(nom)).ToList();
        }

        public static hoteles SelectById(int id_ciutat,String nom)
        {
            return Orm.bd.hoteles.Find(id_ciutat,nom);
        }

        public static List<hoteles> SelectByCadena(String cadena)
        {
            return Orm.bd.hoteles.Where(a=> a.cif.Equals(cadena)).ToList();
        }

        public static String DeleteHotel(hoteles hotel)
        {
            Orm.bd.hoteles.Remove(hotel);
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }

        public static String InsertHotel(hoteles hotel)
        {
            Orm.bd.hoteles.Add(hotel);
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }

        public static String UpdateHotel(hoteles h,int categoria,String direccio,int telefon,String tipus,String cif)
        {
            hoteles hotel = SelectById(h.id_ciudad,h.nombre);
            hotel.categoria = categoria;
            hotel.cif = cif;
            hotel.direccion= direccio;
            hotel.telefono= telefon;
            hotel.tipo= tipus;
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }
    }
}
