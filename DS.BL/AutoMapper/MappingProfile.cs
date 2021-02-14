using AutoMapper;
using DA.MODEL;
using DS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.BL.AutoMapper
{
    public  class MappingProfile: Profile
    {
       

        public MappingProfile()
        {
            CreateMap<Customer, CustomerModel>();
           
            CreateMap<CustomerModel, Customer>()
            .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
          .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name))
          .ForMember(vm => vm.Address1, map => map.MapFrom(m => m.Address1))
          .ForMember(vm => vm.Address2, map => map.MapFrom(m => m.Address2))
          .ForMember(vm => vm.Password, map => map.MapFrom(m => m.Password))
           .ForMember(vm => vm.MobileNo, map => map.MapFrom(m => m.MobileNo))
            .ForMember(vm => vm.City, map => map.MapFrom(m => m.City))
            .ForMember(vm => vm.State, map => map.MapFrom(m => m.State))
            .ForMember(vm => vm.ZipCode, map => map.MapFrom(m => m.ZipCode))
            .ForMember(vm => vm.DealerId, map => map.MapFrom(m => m.DealerId))


          .ForMember(vm => vm.EmailId, map => map.MapFrom(m => m.EmailId));

        }
    }

}

    