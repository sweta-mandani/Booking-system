using DA.IBL;
using DS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.BL
{
   public class AppoinmentRepo:IAppoinment
    {
        
            private ServiceEntities2 _db;

            public AppoinmentRepo(ServiceEntities2 db)
            {
                this._db = db;
            }

            public IEnumerable<appoinment> Appoinments => _db.appoinments.ToList();
        }
    }


