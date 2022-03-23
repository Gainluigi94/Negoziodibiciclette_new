using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models.Classi;
using Repositoryy.Repository;
using Repositoryy.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoryy
{
   public static class Dependeces
    {


        public static IServiceCollection AddRepositories(this IServiceCollection
     services)
        {

            services
                .AddTransient<IUtenteRepository, UtenteRepository>()
                    .AddTransient<IPersonaRepository, PersonaRepository>()
                     .AddTransient<IRegioneRepository, RegioneRepository>()
                     .AddTransient<IIndirizzoRepository, IndirizzoRepository>()
                       .AddTransient<ICartadicreditoRepository, CartadiCreditoRepository>()
                        .AddTransient<IBiciRepository, BiciRepository>()
                         .AddTransient<IAcquistiRepository, AcquistiRepository>()
                           .AddTransient<IRegioneRepository, RegioneRepository>();
            return services;
        }
        public static IServiceCollection AddNegozioRepositories(this IServiceCollection
   services, IConfiguration configuration)
        {

            services
                    .AddTransient<IPersonaRepository, PersonaRepository>((r) =>
                    {
                        // var ctx = r.GetRequiredService<QuoteGeneratorDbContext>();

                        var optionsBuilder = new DbContextOptionsBuilder<NegoziodibicicletteContext>();
                        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                        return new PersonaRepository(new NegoziodibicicletteContext(optionsBuilder.Options));
                    })
                     .AddTransient<IRegioneRepository, RegioneRepository>((r) =>
                     {
                         // var ctx = r.GetRequiredService<QuoteGeneratorDbContext>();

                         var optionsBuilder = new DbContextOptionsBuilder<NegoziodibicicletteContext>();
                         optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                         return new RegioneRepository(new NegoziodibicicletteContext(optionsBuilder.Options));
                     })
                      .AddTransient<IIndirizzoRepository, IndirizzoRepository>((r) =>
                      {
                          // var ctx = r.GetRequiredService<QuoteGeneratorDbContext>();

                          var optionsBuilder = new DbContextOptionsBuilder<NegoziodibicicletteContext>();
                          optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                          return new IndirizzoRepository(new NegoziodibicicletteContext(optionsBuilder.Options));
                      })
                       .AddTransient<ICartadicreditoRepository, CartadiCreditoRepository>((r) =>
                       {
                           // var ctx = r.GetRequiredService<QuoteGeneratorDbContext>();

                           var optionsBuilder = new DbContextOptionsBuilder<NegoziodibicicletteContext>();
                           optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                           return new CartadiCreditoRepository(new NegoziodibicicletteContext(optionsBuilder.Options));
                       })
                        .AddTransient<IBiciRepository, BiciRepository>((r) =>
                        {
                            // var ctx = r.GetRequiredService<QuoteGeneratorDbContext>();

                            var optionsBuilder = new DbContextOptionsBuilder<NegoziodibicicletteContext>();
                            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                            return new BiciRepository(new NegoziodibicicletteContext(optionsBuilder.Options));
                        })
                         .AddTransient<IAcquistiRepository, AcquistiRepository>((r) =>
                         {
                             // var ctx = r.GetRequiredService<QuoteGeneratorDbContext>();

                             var optionsBuilder = new DbContextOptionsBuilder<NegoziodibicicletteContext>();
                             optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                             return new AcquistiRepository(new NegoziodibicicletteContext(optionsBuilder.Options));
                         })
                          .AddTransient<IUtenteRepository, UtenteRepository>((r) =>
                          {
                              // var ctx = r.GetRequiredService<QuoteGeneratorDbContext>();

                              var optionsBuilder = new DbContextOptionsBuilder<NegoziodibicicletteContext>();
                              optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                              return new UtenteRepository(new NegoziodibicicletteContext(optionsBuilder.Options));
                          })
                          .AddTransient<IRegioneRepository, RegioneRepository>((r) =>
                          {
                              // var ctx = r.GetRequiredService<QuoteGeneratorDbContext>();

                              var optionsBuilder = new DbContextOptionsBuilder<NegoziodibicicletteContext>();
                              optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                              return new RegioneRepository(new NegoziodibicicletteContext(optionsBuilder.Options));
                          })
                          ;
            return services;

        }


        }







    
}
