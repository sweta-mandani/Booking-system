using AutoMapper;
using DS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.MODEL.Automapper
{
    class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerModel>();

            CreateMap<CustomerModel, Customer>()
        }
    }
}
