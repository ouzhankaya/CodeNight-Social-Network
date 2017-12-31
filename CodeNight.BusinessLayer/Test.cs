using CodeNight.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNight.BusinessLayer
{
   public class Test
    {
        public Test()
        {
            DatabaseContext db = new DatabaseContext();
            db.Shares.ToList();
        }
    }
}
