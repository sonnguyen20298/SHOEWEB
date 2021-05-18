using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Repository;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels.Homepage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Services
{
    public class ManufacturerService : EcommerceServices<Manufacturer>, IManufacturerService
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly IMapper _mapper;

        public ManufacturerService(IManufacturerRepository manufacturerRepository, IMapper mapper) 
            : base(manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
            _mapper = mapper;
        }

        public async Task<IList<ManufacturerHomepageViewModel>> GetManufacturerHomepage()
        {
            // buoc 1: lay ra duoc tap hop cac entity
            var manufacturers = await _manufacturerRepository.FindAllAsync(x => x.IsDeleted == false);
            // Buoc 2  : map entity  => view model
            return _mapper.Map<List<ManufacturerHomepageViewModel>>(manufacturers);
        }
    }
}
