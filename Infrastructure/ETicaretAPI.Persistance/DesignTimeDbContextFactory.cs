using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
    {
        public ETicaretAPIDbContext CreateDbContext(string[] args)
        {

            //ConfigurationManager configurationManager = new ();
            //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../Presentation/ETicaretAPI.API")); // neredeki appsettings.json olduğunu belirtmemizi sağlar.
            //configurationManager.AddJsonFile("appsettings.json");
            // Microsoft.Extensions.Configuration ve Microsoft.Extensions.Configuration.Json kütüphanelerini yüklememiz gerekiyor. Bu iki satır ile appsettings.json dosyasını okuyabiliyoruz.

            //var optionsBuilder = new DbContextOptionsBuilder<ETicaretAPIDbContext>();
            //DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new ();
            // yukarıdaki iki satır aynı kullanımdır.


            //optionsBuilder.UseNpgsql("User ID=admin;Password=admin;Host=localhost;Port=5432;Database=ETicaretAPIDb;");
            //dbContextOptionsBuilder.UseNpgsql(configurationManager.GetConnectionString("PostgreSQL"));


            //return new ETicaretAPIDbContext(optionsBuilder.Options);
            //return new ETicaretAPIDbContext(dbContextOptionsBuilder.Options);

            DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);



        }
    }
}
