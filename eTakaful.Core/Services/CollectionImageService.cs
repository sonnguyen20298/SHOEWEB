using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using EcommerceCommon.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Services
{
    public class CollectionImageService : EcommerceServices<CollectionImage>, ICollectionImageService
    {
        private readonly ICollectionImageRepository _collectionImageRepository;
        private readonly IMapper _mapper;

        public CollectionImageService(ICollectionImageRepository collectionImageRepository, IMapper mapper) : base(collectionImageRepository)
        {
            _collectionImageRepository = collectionImageRepository;
            _mapper = mapper;
        }

        public async Task<IList<CollectionImageViewModel>> GetCollectionImageList()
        {
            var collection = await _collectionImageRepository.GetCollectionImageViewModel();
            return collection;
        }
    }
}
