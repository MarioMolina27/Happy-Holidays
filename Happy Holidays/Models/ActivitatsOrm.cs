using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Holidays.Models
{
    public static class ActivitatsOrm
    {
        public static List<actividades> SelectAll()
        {
            return Orm.bd.actividades.ToList();
        }

        public static List<actividades> SelectByNom(String nom)
        {
            return Orm.bd.actividades.Where(p => p.descripcion.Contains(nom)).ToList();
        }

        public static actividades SelectById(int id)
        {
            return Orm.bd.actividades.Find(id);
        }

        public static int SelectLastId()
        {
            return Orm.bd.actividades.Max(a => a.id_act);
        }


        public static String DeleteActivitat(actividades actividad)
        {
            Orm.bd.actividades.Remove(actividad);
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }

        public static String InsertActivitat(actividades actividad)
        {
            Orm.bd.actividades.Add(actividad);
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }

        public static String UpdateActivitat(actividades c, String nom)
        {
            actividades activitat = ActivitatsOrm.SelectById(c.id_act);
            activitat.descripcion = nom;
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }

    }
}
