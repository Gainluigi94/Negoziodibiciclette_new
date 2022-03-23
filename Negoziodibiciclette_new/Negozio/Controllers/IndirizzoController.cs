using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

using Servicee.Contract;
using Servicee.Request.Indirizzo;
using Servicee.Response.Indirizzo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negozio.Controllers
{

    [Route("api/[controller]")]
    public class IndirizzoController : Controller
    {

        IIndirizzoService _indirizzoService;

        private readonly IWebHostEnvironment _hostingEnvironment;


        public IndirizzoController(IWebHostEnvironment hostingEnvironment, IIndirizzoService indirizzoService)
        {
            _indirizzoService = indirizzoService;
           
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("AddIndirizzo")]

        public IndirizzoResponse addindirizzo ([FromBody]AddIndirizzo add)
        {
            IndirizzoResponse indirizzo = null;
            try
            {
               indirizzo =  _indirizzoService.AddIndirizzo(add);
            }catch(Exception ex)
            {
                throw ex;
            }
            return indirizzo;
        }

        [HttpDelete("DeleteIndirizzo/{Id}")]

        public IndirizzoResponse deleteindirizzo(DeleteIndirizzo add)
        {
            IndirizzoResponse indirizzo = null;
            try
            {
                indirizzo = _indirizzoService.DeleteIndirizzo(add);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return indirizzo;
        }


        [HttpPut("EditIndirizzo/{Id}")]

        public IndirizzoResponse Editindirizzo( EditIndirizzo add)
        {
            IndirizzoResponse indirizzo = null;
            try
            {
              
                   indirizzo = _indirizzoService.EditIndirizzo(add);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return indirizzo;
        }



        [HttpGet("GetIndirizzo/{Id}")]

        public IndirizzoResponse Getindirizzo( int add)
        {
            IndirizzoResponse indirizzo = null;
            try
            {
                indirizzo = _indirizzoService.GetIndirizzo(add);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return indirizzo;
        }

        [HttpGet]

        public List<IndirizzoResponse>  GetAllindirizzo()
        {
            List<IndirizzoResponse> indirizzo = null;
            try
            {
                indirizzo = _indirizzoService.GetAllIndirizzi();
                return indirizzo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return indirizzo;
        }



    }
}
