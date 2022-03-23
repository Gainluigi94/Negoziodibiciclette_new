using Servicee.Request.Persona;
using Servicee.Response.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Contract
{
  public  interface IPersonaService
    {

        public List<PersonaResponse> GetPersone();

        public PersonaResponse Deletepersona(DeletePersona persona);

        public PersonaResponse Addpersona(AddPersona persona);

        public List<PersonaResponse> Getpersona(int persona);
        public PersonaResponse Editpersona(EditPersona persona);
    }
}
