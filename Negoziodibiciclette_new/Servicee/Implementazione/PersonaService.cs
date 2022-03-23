

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Models.Classi;
using Repositoryy.RepositoryInterface;
using Servicee.Contract;
using Servicee.Request.Persona;
using Servicee.Response.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Implementazione
{
   public class PersonaService : IPersonaService
    {

        private IMapper _mapper;
        private IPersonaRepository _personarepository;


        public PersonaService( IMapper mapper,IPersonaRepository personaRepository)
        {
            _mapper = mapper;
            _personarepository = personaRepository;
        }


        public PersonaResponse Addpersona(AddPersona persona)
        {
            var person = _mapper.Map<Persona>(persona);
            _personarepository.Add(person);
            return _mapper.Map<PersonaResponse>(person);




        }

        public PersonaResponse Deletepersona(DeletePersona del)
        {

            var person = _mapper.Map<Persona>(del);
            _personarepository.Delete(person);
            return _mapper.Map<PersonaResponse>(person);


        }

        public PersonaResponse Editpersona(EditPersona persona)
        {
            var person = _mapper.Map<Persona>(persona);
            _personarepository.Update(person);
            return _mapper.Map<PersonaResponse>(person);




        }

        public List<PersonaResponse> Getpersona(int persona )
        {
            var person = _personarepository.GetAll().Where(z => z.Id == persona ).ToList();
            
            return _mapper.Map<List<PersonaResponse>>(person);




        }

     
        public List<PersonaResponse> GetPersone()
        {

            var person = _personarepository.GetAll().ToList();

            return _mapper.Map<List<PersonaResponse>>(person);
        }
    }
}
