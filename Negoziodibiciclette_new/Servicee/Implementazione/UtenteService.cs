using AutoMapper;
using Models.Classi;
using Repositoryy.RepositoryInterface;
using Servicee.Contract;
using Servicee.Request.Utente;
using Servicee.Response.Utente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicee.Implementazione
{
    public class UtenteService : IUtenteService
    {
        IMapper _mapper;
        IUtenteRepository _utenterepository;



        public UtenteService(IMapper mapper , IUtenteRepository utenterepository)
        {
            _mapper = mapper;
            _utenterepository = utenterepository;

        }



        public UtenteResponse AddUtente(AddUtente add)
        {
            var utente = _mapper.Map<Utente>(add);
            _utenterepository.Add(utente);
            return _mapper.Map<UtenteResponse>(utente);

        }

        public UtenteResponse DeleteUtente(DeleteUtente add)
        {
            var utente = _mapper.Map<Utente>(add);
            _utenterepository.Delete(utente);
            return _mapper.Map<UtenteResponse>(utente);

        }


        public UtenteResponse EditUtente(EditPassword add)
        {
            var utente = _mapper.Map<Utente>(add);
            _utenterepository.Update(utente);
            return _mapper.Map<UtenteResponse>(utente);

        }

        public UtenteResponse GetUtente(int add)
        {
            var utente = _utenterepository.GetAll().Where(x => x.Id == add).FirstOrDefault();
            return _mapper.Map<UtenteResponse>(utente);
        }

        public List<UtenteResponse> GetUtenti()
        {
            var utente = _utenterepository.GetAll().ToList();
            return _mapper.Map<List<UtenteResponse>>(utente);
        }
    }
}
