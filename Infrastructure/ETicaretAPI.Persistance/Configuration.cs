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
    static class Configuration
    {
        static public string ConnectionString 
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API")); // neredeki appsettings.json olduğunu belirtmemizi sağlar.
                configurationManager.AddJsonFile("appsettings.json");    // Microsoft.Extensions.Configuration ve Microsoft.Extensions.Configuration.Json kütüphanelerini yüklememiz gerekiyor. Bu iki satır ile appsettings.json dosyasını okuyabiliyoruz.

                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }

        

    }
}
