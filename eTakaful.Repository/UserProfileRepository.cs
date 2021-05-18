using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class UserProfileRepository : BaseRepository<UserProfile>, IUserProfileRepository
    {

        public UserProfileRepository(ApplicationDbContext dbContext) : base(dbContext)
        { }

        public async Task UpdateUserProfile(UserProfile userprofile, string password = null)
        {
            // find user profile
            var user = DbContext.UserProfiles.Find(userprofile.Id);

            if (user != null)
            {
                // update
                userprofile.UpdatedDate = DateTime.Now;
                await UpdateAsync(user);

            }
        }


        //public async Task<ICollection<UserProfile>> ShowUserprofile()
        //{
        //    return await DbContext.Userprofiles.Where(c => c.NSXId == null).ToListAsync();
        //}
    }
}

