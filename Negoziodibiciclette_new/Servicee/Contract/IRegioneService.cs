
using Servicee.Request.Regione;
using Servicee.Response.Regione;
using System.Collections.Generic;

namespace Servicee.Contract
{
   public interface IRegioneService
    {



        public RegioneResponse AddRegione(AddRegione add);

        public RegioneResponse DeleteRegione(DeleteRegione add);

        public RegioneResponse EditRegione(EditRegione add);
        public RegioneResponse GetRegione(int add);
        public List<RegioneResponse> GetRegione();

    }
}
