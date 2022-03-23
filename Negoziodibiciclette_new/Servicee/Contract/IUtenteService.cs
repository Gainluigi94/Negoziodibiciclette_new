using Servicee.Request.Utente;
using Servicee.Response.Utente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicee.Contract
{
    public interface IUtenteService
    {

        public UtenteResponse AddUtente(AddUtente add);

        public UtenteResponse DeleteUtente(DeleteUtente add);

        public UtenteResponse GetUtente(int add);

        public UtenteResponse EditUtente(EditPassword add);
        public List<UtenteResponse> GetUtenti();






    }
}
