using DA.IBL;
using DA.MODEL;
using DS.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DS.BL
{
    public class DealerRepo : IDealerRepo
    {
        private ServiceEntities2 _db;

        public DealerRepo(ServiceEntities2 db)
        {
            this._db = db;
        }

        IEnumerable<DealerModel> IDealerRepo.GetallDealer()
        {
            return (IEnumerable<DealerModel>)_db.DealerModel.ToList();
        }

        DealerModel IDealerRepo.GetDealerById(int id)
        {
            return (CustomerModel)(IEnumerable<DealerModel>)_db.DealerModel.Find(id);
        }

        int IDealerRepo.InsertDealer(DealerModel d)
        {
            Mapper.CreateMap<DealerModel, Dealer>();
            var user = Mapper.Map<Dealer, DealerModel>(d);
            _db.DealerModel.Add(d);
            return _db.SaveChanges();

        }

        int IDealerRepo.UpdateDealer(DealerModel d)
        {
            Mapper.CreateMap<DealerModel, Dealer>();
            var userDetails = _db.DealerModel.FirstOrDefault(Id => Id.DealerId == id);
            var user = Mapper.Map<Dealer, DealerModel>(d);

            return _db.SaveChanges();
        }
    }
}
