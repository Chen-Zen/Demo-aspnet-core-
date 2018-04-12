using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ZheXian.Configuration;
using ZheXian.Web;

namespace ZheXian.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ZheXianDbContextFactory : IDesignTimeDbContextFactory<ZheXianDbContext>
    {
        public ZheXianDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ZheXianDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ZheXianDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ZheXianConsts.ConnectionStringName));

            return new ZheXianDbContext(builder.Options);
        }
    }
}
