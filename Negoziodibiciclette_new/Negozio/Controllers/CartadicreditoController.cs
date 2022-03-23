using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Servicee.Contract;
using Servicee.Request.Cartadicredito;
using Servicee.Response.Cartadicredito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negozio.Controllers
{

    [Route("api/[controller]")]

    public class CartadicreditoController : Controller
    {
        ICartadicreditoService _cartadicreditoService;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public CartadicreditoController(ICartadicreditoService cartadicreditoService,
       IWebHostEnvironment hostingEnvironment) {

            _hostingEnvironment = hostingEnvironment;
            _cartadicreditoService = cartadicreditoService;
        }

        [HttpPost("AddCarta")]

        public CartadicreditoResponse AddCarta ([FromBody]CartadicreditoRequest carta)
        {

            CartadicreditoResponse carte = null;

            try
            {
                carte = _cartadicreditoService.addcarta(carta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return carte;

        }


        [HttpDelete("DeleteCarta/{Id}")]

        public CartadicreditoResponse DeleteCarta(DeleteCartadicredito carta)
        {

            CartadicreditoResponse carte = null;

            try
            {
                carte = _cartadicreditoService.deletecarta(carta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return carte;

        }

        [HttpGet("GetCarta/{Id}")]

        public CartadicreditoResponse GetCarta(int carta)
        {

            CartadicreditoResponse carte = null;

            try
            {
                carte = _cartadicreditoService.Getcarta(carta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return carte;

        }


        [HttpGet("EditCarta")]

        public List<CartadicreditoResponse> EditCarta()
        {

            List<CartadicreditoResponse> carte = null;

            try
            {
                carte = _cartadicreditoService.GetAllCarte();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return carte;

        }







    }
}
