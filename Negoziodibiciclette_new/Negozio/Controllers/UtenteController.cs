using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Servicee.Contract;
using Servicee.Request.Utente;
using Servicee.Response.Utente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negozio.Controllers
{


    [Route("api/[controller]")]

    public class UtenteController : Controller
    {


        IUtenteService _utenteService;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public UtenteController (IUtenteService utenteService , IWebHostEnvironment hostingEnvironment)
        {
            _utenteService = utenteService;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("AddUser")]
        public UtenteResponse AddUser ([FromBody] AddUtente add)
        {

           UtenteResponse user = null;
            try
            {
                user = _utenteService.AddUtente(add);
           
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return user;
        }

        [HttpGet("GetUser/{Id}")]
        public UtenteResponse GetUser(int add)
        {

            UtenteResponse user = null;
            try
            {
                user = _utenteService.GetUtente(add);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }



        [HttpGet("GetUsers")]
        public List<UtenteResponse> GetUsers()
        {

            List<UtenteResponse> user = null;
            try
            {
                user = _utenteService.GetUtenti();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }






        [HttpPut("PutUser/{Id}")]
        public UtenteResponse PutUser([FromBody] EditPassword add)
        {

            UtenteResponse user = null;
            try
            {
                user = _utenteService.EditUtente(add);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }



        [HttpDelete("DeleteUser/{Id}")]
        public UtenteResponse DeleteUser([FromBody] DeleteUtente add)
        {

            UtenteResponse user = null;
            try
            {
                user = _utenteService.DeleteUtente(add);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }




    }
}
