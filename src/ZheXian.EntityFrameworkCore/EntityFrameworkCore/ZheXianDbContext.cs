using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ZheXian.Authorization.Roles;
using ZheXian.Authorization.Users;
using ZheXian.MultiTenancy;

namespace ZheXian.EntityFrameworkCore
{
    public class ZheXianDbContext : AbpZeroDbContext<Tenant, Role, User, ZheXianDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ZheXianDbContext(DbContextOptions<ZheXianDbContext> options)
            : base(options)
        {
        }
    }
}
