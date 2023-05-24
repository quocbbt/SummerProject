using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace NewCoreAPI.Data
{
    public class MasterDataDbContextFactory : IDesignTimeDbContextFactory<MasterDataDbContext>
    {
        public MasterDataDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("masterdata");
            var optionBuilder = new DbContextOptionsBuilder<MasterDataDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new MasterDataDbContext(optionBuilder.Options);
        }
    }
}
