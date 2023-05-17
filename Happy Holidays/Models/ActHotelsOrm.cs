using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Holidays.Models
{
    public static class ActHotelsOrm
    {
        public static List<act_hotel> SelectByHotel(hoteles h)
        {
            return Orm.bd.act_hotel.Where(a => a.id_ciudad == h.id_ciudad && a.nombre==h.nombre).ToList();
        }

        public static String InsertActivitat(act_hotel actividad)
        {
            Orm.bd.act_hotel.Add(actividad);
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }

        public static String DeleteActivitat(act_hotel act)
        {
            Orm.bd.act_hotel.Remove(act);
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }
    }
}
