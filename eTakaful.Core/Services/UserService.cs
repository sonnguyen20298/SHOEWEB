using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Domain.Enums;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Dto;
using Ecommerce.Service.Interface;
using EcommerceCommon.Infrastructure.Helper;

namespace Ecommerce.Service.Services
{
    public class UserService : EcommerceServices<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IUserProfileRepository userProfileRepository, IMapper mapper) : base(userRepository)
        {
            _userRepository = userRepository;
            _userProfileRepository = userProfileRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> Register(UserDto userDto)
        {
            var acc = await _userRepository.GetFirstOrDefaultAsync(x => x.Username.ToLower() == userDto.Username.ToLower());
            if (acc == null)
            {
                byte[] passwordHash;
                byte[] passwordSalt;
                AuthenUserHelper.CreatePasswordHash(userDto.Password, out passwordHash, out passwordSalt);
                // Create user
                var user = new User
                {
                    Username = userDto.Username,
                    Roles = userDto.Role,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Status = Status.InActive
                };

                await _userRepository.AddAsync(user);

                // Create user profile
                var userProfile = new UserProfile
                {
                    Name = userDto.Username,
                    Gender = userDto.Gender,
                    Birthday = userDto.Birthday,
                    Email = userDto.Email,
                    Phone = userDto.Phone,
                    UserId = user.Id
                };

                await _userProfileRepository.AddAsync(userProfile);

                // Send mail


                // Thanh cong
                return userDto;
            }

            if (acc.Status == Status.InActive)
            {
                throw new Exception("Tài khoản chưa được kích hoạt, vui lòng kích hoạt tài khoản");
            }
            else if (acc.Status == Status.Active)
            {
                throw new Exception("Tài khoản đã được đăng ký");
            }


            return null;
        }

        public async Task<UserDto> Login(string username, string password)
        {
            var user = await _userRepository.Authenticate(username, password);
            // map useDto
            return _mapper.Map<UserDto>(user);
        }
    }
}
