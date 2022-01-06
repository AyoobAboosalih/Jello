using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jello.Data;
using Microsoft.EntityFrameworkCore;

namespace Jello.Models
{
    public class UserModel
    {

        private readonly ApplicationDbContext _dbContext;
        public UserModel(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public async Task<bool> DeleteUser(Guid id)
        {
            var users = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            if (users != null)
            {
                _dbContext.Users.Remove(users);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User>  GetUserById(Guid id)
        {
            var users = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            return users;
        }

        public async Task<bool> SaveUser(User users)
        {
            if (users.Id.Equals(0)) {
                users.Id = new Guid();
                await _dbContext.Users.AddAsync(users);
            } 
            else _dbContext.Users.Update(users);
            await _dbContext.SaveChangesAsync();
            return true;

        }
    }
}
