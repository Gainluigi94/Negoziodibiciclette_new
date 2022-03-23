using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Servicee.Contract;
using Servicee.Request.Persona;
using Servicee.Response.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negozio.Controllers
{



    [Route("api/[controller]")]


    public class PersonaController : Controller
    {
        IPersonaService _personaService;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public PersonaController(IWebHostEnvironment webhost, IPersonaService personaservice)
        {
            _personaService = personaservice;
            _hostingEnvironment = webhost;
        }



        [HttpPost("AddPersona")]

        public PersonaResponse addpersona([FromBody] AddPersona persona)
        {
            PersonaResponse pers = null;
            try
            {
                pers = _personaService.Addpersona(persona);
            }catch(Exception ex)
            {

                Console.WriteLine("Error");



            }
            return pers;
        }

        [HttpGet("GetPersona/{Id}")]

        public List<PersonaResponse> Getpersona(int persona)
        {
            List<PersonaResponse> pers = null;
            try
            {
                pers = _personaService.Getpersona(persona);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pers;
        }



        [HttpGet("GetPersone")]

        public List<PersonaResponse> Getpersone()
        {
            List<PersonaResponse> pers = null;
            try
            {
                pers = _personaService.GetPersone();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pers;
        }


        [HttpDelete("DeletePersone/{Id}")]

        public PersonaResponse Deletepersone([FromBody] DeletePersona delete)
        {
           PersonaResponse pers = null;
            try
            {
                pers = _personaService.Deletepersona(delete);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pers;
        }


        [HttpPut("EditPersone/{Id}")]

        public PersonaResponse Editpersone([FromBody]EditPersona id)
        {
            PersonaResponse pers = null;
            try
            {
                pers = _personaService.Editpersona(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pers;
        }







    }
}
