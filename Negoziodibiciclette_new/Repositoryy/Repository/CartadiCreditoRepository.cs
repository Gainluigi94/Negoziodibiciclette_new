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
   public class CartadiCreditoRepository : RepositoryBase<Cartadicredito> , ICartadicreditoRepository
    {

        public CartadiCreditoRepository(NegoziodibicicletteContext context) : base(context)
        // public BX_FlussiRepository(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {

        }


        internal CartadiCreditoRepository(DbContextOptions<NegoziodibicicletteContext> options)
       : base(options)
        {
        }



    }
}
