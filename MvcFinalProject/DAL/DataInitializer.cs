using Microsoft.AspNetCore.Identity;
using MvcFinalProject.Constants;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.DAL
{
    public class DataInitializer
    {
        private AppDbContext _dbContext;
        private RoleManager<IdentityRole> _roleManager;

        public DataInitializer(AppDbContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
        }

        public async Task SeedData()
        {
            if (!_dbContext.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole(RoleConstants.Admin));
                await _roleManager.CreateAsync(new IdentityRole(RoleConstants.Moderator));
                await _roleManager.CreateAsync(new IdentityRole(RoleConstants.User));
            }
        }
    }
}

