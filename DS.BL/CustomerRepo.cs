using AutoMapper;
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
    public class CustomerRepo : ICustomerRepo
    {
        
        private ServiceEntities2 _db;
        private readonly IMapper mapper;

        public CustomerRepo()
        {
            _db = new ServiceEntities2();
            
        }

        
        public int InsertCustomer(CustomerModel c)
        {
            

            DS.DATA.Customer cust = new DS.DATA.Customer()
            {
                Name = c.Name,
                Address1 = c.Address1,
                Address2 = c.Address2,
                City = c.City,
                State = c.State,
                ZipCode = c.ZipCode,
                EmailId = c.EmailId,
                MobileNo = c.MobileNo,

                Password = c.Password

            };
            _db.CustomerModel.Add(cust);
            return _db.SaveChanges();

        }

        
        public int UpdateCustomer(CustomerModel c)
        {
            _db.Entry(c).State = EntityState.Modified;
            return _db.SaveChanges();
        }

        public IEnumerable<CustomerModel> GetallCustomer()
        {
            return (IEnumerable<CustomerModel>)_db.CustomerModel.ToListAsync();
        }

        public CustomerModel GetCustomerById(int id)
        {
            return (CustomerModel)(IEnumerable<CustomerModel>)_db.CustomerModel.Find(id);
        }
    }
}