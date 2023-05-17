using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Holidays.Models
{
    public static class CiutatsOrm
    {
        public static List<ciudades> SelectAll()
        {
            return Orm.bd.ciudades.ToList();
        }
    }
}
