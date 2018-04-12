using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ZheXian.EntityFrameworkCore
{
    public static class ZheXianDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ZheXianDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ZheXianDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
