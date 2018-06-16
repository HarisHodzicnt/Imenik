using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactClass.data;
namespace ContactClass
{
    public class AdresarDK
    {
        public static void Insert(Adresar a)
        {
           
            using (imenikEntities dm = new imenikEntities())
            {
                dm.Adresar_insert(a.Name, a.LastName, a.PhoneNumber);
            }
        }
        public static void Delete(Adresar a)
        {
            using (imenikEntities dm = new imenikEntities())
            {
                dm.Adresar_delete_row(a.ID);
            }
        }
        public static List<Adresar_selectAll_Result> selectAll()
        {
            using (imenikEntities dm = new imenikEntities())
            {
                return dm.Adresar_selectAll().ToList();
            }
        }


    }
}
