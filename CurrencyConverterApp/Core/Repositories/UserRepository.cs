using CurrencyConverterApp.Core.IRepositories;
using CurrencyConverterApp.DAL;
using CurrencyConverterApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CurrencyConverterApp.Core.Repositories
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {

        }

        public override async Task<IEnumerable<ApplicationUser>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(UserRepository));
                return new List<ApplicationUser>();
            }
        }

        public override async Task<bool> Upsert(ApplicationUser entity)
        {
            try
            {
                var existingUser = await dbSet.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();

                if (existingUser == null)
                    return await Add(entity);

                existingUser.FirstName = entity.FirstName;
                existingUser.LastName = entity.LastName;
                existingUser.Email = entity.Email;

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert method error", typeof(UserRepository));
                return false;
            }
        }


        public override async Task<bool> Delete(Guid Id)
        {
            try
            {
                var exist = await dbSet.Where(u => u.Id == Id).FirstOrDefaultAsync();

                if (exist != null)
                {
                    dbSet.Remove(exist);
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete method error", typeof(UserRepository));
                return false;
            }
        }
    }
}
