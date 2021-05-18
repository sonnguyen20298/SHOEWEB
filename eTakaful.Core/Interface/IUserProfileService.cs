using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Service.Interface
{
    public interface IUserProfileService : IServices<UserProfile>
    {

        // void Update (UserDto user, string password = null);
    }
}
