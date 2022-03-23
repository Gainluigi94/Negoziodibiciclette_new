using Microsoft.EntityFrameworkCore;
using Models.Classi;
using Repositoryy.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoryy.Repository
{
  public  class UtenteRepository : RepositoryBase<Utente>,IUtenteRepository
    {

        public UtenteRepository(NegoziodibicicletteContext context) : base(context)
        // public BX_FlussiRepository(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {

        }


        internal UtenteRepository(DbContextOptions<NegoziodibicicletteContext> options)
       : base(options)
        {
        }




    }
}
