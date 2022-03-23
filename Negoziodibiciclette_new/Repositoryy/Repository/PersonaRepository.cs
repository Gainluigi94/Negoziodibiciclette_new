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
 public   class PersonaRepository : RepositoryBase<Persona>,IPersonaRepository
    {

        public PersonaRepository(NegoziodibicicletteContext context) : base(context)
        // public BX_FlussiRepository(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {

        }


        internal PersonaRepository(DbContextOptions<NegoziodibicicletteContext> options)
       : base(options)
        {
        }



    }
}
