using Microsoft.EntityFrameworkCore;
using Models;
using Models.Classi;
using Repositoryy.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoryy.Repository
{
   public class AcquistiRepository : RepositoryBase<Acquisti>, IAcquistiRepository
    {


        public AcquistiRepository(NegoziodibicicletteContext context) : base(context)
        // public BX_FlussiRepository(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {

        }


        internal AcquistiRepository(DbContextOptions<NegoziodibicicletteContext> options)
       : base(options)
        {
        }




    }
}
