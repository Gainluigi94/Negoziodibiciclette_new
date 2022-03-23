using Servicee.Request.Cartadicredito;
using Servicee.Response.Cartadicredito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Contract
{
   public interface ICartadicreditoService
    {

        CartadicreditoResponse addcarta(CartadicreditoRequest add);
        CartadicreditoResponse deletecarta(DeleteCartadicredito add);

       List<CartadicreditoResponse> GetAllCarte();

        CartadicreditoResponse Getcarta (int add);



    }
}
