using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Holidays.Models
{
    public static class CadenesOrm
    {
        public static List<cadenas> SelectAll()
        { 
            return Orm.bd.cadenas.ToList();
        }

        public static List<cadenas> SelectByNom(String nom)
        {
            return Orm.bd.cadenas.Where(p => p.nombre.Contains(nom)).ToList();
        }
        public static cadenas SelectByCif(String cif)
        {
            return Orm.bd.cadenas.Find(cif);
        }

        public static String InsertCadena(cadenas cadena)
        {
            Orm.bd.cadenas.Add(cadena);
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }

        public static String UpdateCadena(cadenas c,String nom, String dif) 
        {
            cadenas _cadena = CadenesOrm.SelectByCif(c.cif);
            _cadena.nombre = nom;
            _cadena.dir_fis = dif;
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }

        public static String DeleteCadena(cadenas cadena)
        {
            Orm.bd.cadenas.Remove(cadena);
            String missatge = "";
            missatge = Orm.MySavesChanges();
            return missatge;
        }
    }
}
