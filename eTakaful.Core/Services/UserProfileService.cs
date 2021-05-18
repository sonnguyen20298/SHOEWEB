using AutoMapper;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.Services
{
    public class UserProfileService : EcommerceServices<UserProfile>, IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IMapper _mapper;


        public UserProfileService(IUserProfileRepository userProfileRepository, IMapper mapper) : base(userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
            _mapper = mapper;
        }

        // Thay đổi thông tin 
        //public void Update(UserDto userDto, string password = null)
        //{
        //    var user = _mapper.Map<UserProfile>(userDto);
        //    _userprofileRepository.Update(user, password);
        //}


    }
}
