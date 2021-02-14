
using DA.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.IBL
{
    public interface ICustomerRepo
    {
        CustomerModel GetCustomerById(int id);

        IEnumerable<CustomerModel> GetallCustomer();
        public int InsertCustomer(CustomerModel c);
        
        public int UpdateCustomer(CustomerModel c);
    }
}
