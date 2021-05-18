using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Service.Dto;
using Ecommerce.Service.ViewModels;
using Ecommerce.Service.ViewModels.Homepage;
using Ecommerce.Service.ViewModels.ProductDetail;
using Ecommerce.Service.ViewModels.ProductList;
using EcommerceCommon.Infrastructure.ViewModel;

namespace Ecommerce.Core.ViewModels
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            MappingEntityToViewModel();
            MappingDtoToEntity();
        }

        private void MappingEntityToViewModel()
        {
            // case get data
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductSize, ProductSizeViewModel>();
            CreateMap<ProductImage, ProductImageViewModel>();
            CreateMap<User, UserDto>();

            CreateMap<Manufacturer, ManufacturerHomepageViewModel>()
                .ForMember(dest => dest.UrlImage, src => src.MapFrom(arc => arc.Logo));
            CreateMap<Category, CategoryMenuHomepageViewModel>();
            CreateMap<Category, CollectionHompageViewModel>();
            CreateMap<Category, CategoryProductListViewModel>();
        }

        private void MappingDtoToEntity()
        {
            // case insert or update
            CreateMap<CategoryDto, Category>();
            CreateMap<UserDto, User>();
        }
    }
}