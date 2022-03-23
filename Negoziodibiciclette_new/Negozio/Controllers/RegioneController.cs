using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Repositoryy.RepositoryInterface;
using Servicee.Contract;
using Servicee.Request.Regione;
using Servicee.Response.Regione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negozio.Controllers
{



    [Route("api/[controller]")]
    public class RegioneController : Controller
    {

        IRegioneService _regionerepository;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public RegioneController(IWebHostEnvironment webhost , IRegioneService regionerepository)
        {
            _regionerepository = regionerepository;
            _hostingEnvironment = webhost;
        }


        [HttpPost("AddRegione")]
        public RegioneResponse AddRegione ([FromBody] AddRegione add)
        {
            RegioneResponse reg = null;
            try
            {

                reg = _regionerepository.AddRegione(add);
            }catch(Exception ex)
            {
                throw ex;
            }
            return reg;
        }





        [HttpGet("GetRegione/{Id}")]
        public RegioneResponse GetRegione(int add)
        {
            RegioneResponse reg = null;
            try
            {

                reg = _regionerepository.GetRegione(add);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reg;
        }




        [HttpGet("GetRegione")]
        public List<RegioneResponse> GetRegione()
        {
            List<RegioneResponse> reg = null;
            try
            {

                reg = _regionerepository.GetRegione();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reg;
        }





        [HttpDelete("DeleteRegione/{Id}")]
        public RegioneResponse DeleteRegione([FromBody] DeleteRegione add)
        {
            RegioneResponse reg = null;
            try
            {

                reg = _regionerepository.DeleteRegione(add);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reg;
        }



        [HttpPut("EditRegione/{Id}")]
        public RegioneResponse EditRegione(EditRegione add)
        {
            RegioneResponse reg = null;
            try
            {

                reg = _regionerepository.EditRegione(add);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reg;
        }



    }
}
