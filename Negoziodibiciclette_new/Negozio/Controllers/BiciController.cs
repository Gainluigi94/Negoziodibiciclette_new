using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Servicee.Contract;
using Servicee.Request.Bici;
using Servicee.Response.Bici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negozio.Controllers
{


    [Route("api/[controller]")]

    public class BiciController : Controller
    {


        IBiciService _biciservice;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public BiciController(IWebHostEnvironment hostingEnvironment,IBiciService biciservice)
        {
            _biciservice = biciservice;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("AddBici")]
            
          public GetAllBici addindirizzo([FromBody] AddBici add)
        {
            GetAllBici indirizzo = null;
            try
            {
                indirizzo = _biciservice.AddBici(add);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return indirizzo;
        }



        [HttpGet("GetBici/{Id}")]

        public GetAllBici getbici( int add)
        {
            GetAllBici bici = null;
            try
            {
                bici = _biciservice.GetBici(add);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bici;
        }

        
        [HttpGet("GetBici")]

        public List<GetAllBici>getbicii()
        { 
            List<GetAllBici> bici = null;
            try
            {
                bici = _biciservice.AllBici();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bici;
        }

        [HttpPut("EditBici/{Id}")]

        public GetAllBici addbicii(EditBici edit)
        {
            GetAllBici bici = null;
            try
            {
                bici = _biciservice.UpdateBici(edit);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bici;
        }


        [HttpDelete("DeleteBici/{Id}")]

        public GetAllBici deletebici(DeleteBici edit)
        {
            GetAllBici bici = null;
            try
            {
                bici = _biciservice.DeleteBici(edit);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bici;
        }





    }
}
