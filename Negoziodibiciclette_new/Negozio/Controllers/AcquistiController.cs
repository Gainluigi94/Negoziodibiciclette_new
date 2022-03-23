using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Servicee.Contract;
using Servicee.Request.Acquisti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negozio.Controllers
{


    [Route("api/[controller]")]


    public class AcquistiController : Controller
    {

        IAcquistiService _acquistiService;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public AcquistiController (IAcquistiService acquistiservice,IWebHostEnvironment hostingEnvironment)
        {
            _acquistiService = acquistiservice;
            _hostingEnvironment = hostingEnvironment;

        }

        [HttpPost("AddAcquisti")]

        public GetAllAcquisti AddAcquisti ([FromBody] AddAcquisti add)
        {

            GetAllAcquisti acquisto = null;
            try
            {
                acquisto = _acquistiService.AddAcquisti(add);

            }

            catch(Exception ex)
            {
                throw ex;
            }
            return acquisto;
        }

        [HttpDelete("DeleteAcquisti/{Id}")]

        public GetAllAcquisti DeleteAcquisti( DeleteAcquisti add)
        {

            GetAllAcquisti acquisto = null;
            try
            {
                acquisto = _acquistiService.DeleteAcquisti(add);

            }

            catch (Exception ex)
            {
                throw ex;
            }
            return acquisto;
        }






        [HttpGet("GetAcquisto/{Id}")]



        public GetAllAcquisti GetAcquisti(int add)
        {

            GetAllAcquisti acquisto = null;
            try
            {
                acquisto = _acquistiService.GetAcquisti(add);

            }

            catch (Exception ex)
            {
                throw ex;
            }
            return acquisto;
        }


        [HttpGet("GetAcquisti")]



        public List<GetAllAcquisti> GetAcquistii()
        {

            List<GetAllAcquisti> acquisto = null;
            try
            {
                acquisto = _acquistiService.GetAllAcquisti();

            }

            catch (Exception ex)
            {
                throw ex;
            }
            return acquisto;
        }







    }
}
