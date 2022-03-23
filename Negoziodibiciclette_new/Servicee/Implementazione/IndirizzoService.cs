

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Models.Classi;

using Repositoryy.RepositoryInterface;
using Servicee.Contract;
using Servicee.Request.Indirizzo;
using Servicee.Response.Indirizzo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Servicee.Implementazione
{ 
   public class IndirizzoService : IIndirizzoService
    {

        private IIndirizzoRepository _indirizzoRepository;
        private IMapper _map;

        public IndirizzoService(IIndirizzoRepository ar, IMapper map)
        {
            _indirizzoRepository = ar;
            _map = map;
        }


        public IndirizzoResponse AddIndirizzo (AddIndirizzo add)
        {
            var ind = _map.Map<Indirizzo>(add);
            _indirizzoRepository.Add(ind);
            return _map.Map<IndirizzoResponse>(ind);
        }

        public IndirizzoResponse DeleteIndirizzo(DeleteIndirizzo delete)
        {
            var ind = _map.Map<Indirizzo>(delete);
            _indirizzoRepository.Delete(ind);
            return _map.Map<IndirizzoResponse>(ind);
        }

        public IndirizzoResponse EditIndirizzo(EditIndirizzo edit)
        {
            var ind = _map.Map<Indirizzo>(edit);
            _indirizzoRepository.Update(ind);
            return _map.Map<IndirizzoResponse>(ind);
        }


        public IndirizzoResponse GetIndirizzo(int edit)
        {
            var ind = _indirizzoRepository.GetAll().Where(x => x.Id == edit).FirstOrDefault();
            
            return _map.Map<IndirizzoResponse>(ind);
        }


        public List<IndirizzoResponse> GetAllIndirizzi()
        {
            var ind = _indirizzoRepository.GetAll().ToList();
            return _map.Map<List<IndirizzoResponse>>(ind);

        }
    }
}
