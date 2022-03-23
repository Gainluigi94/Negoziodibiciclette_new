

using AutoMapper;
using Models.Classi;

using Repositoryy.RepositoryInterface;
using Servicee.Contract;
using Servicee.Request.Regione;
using Servicee.Response.Regione;
using System.Collections.Generic;
using System.Linq;

namespace Servicee.Implementazione
{
  public class RegioneService : IRegioneService
    {




        private IRegioneRepository _regionerepository;
        private IMapper _mapper;



        public RegioneService (IMapper mapper,IRegioneRepository regione)
        {
            _mapper = mapper;
            _regionerepository = regione;

        }




        public RegioneResponse AddRegione(AddRegione add)
        {
            var reg = _mapper.Map<Regione>(add);
            _regionerepository.Add(reg);
            return _mapper.Map<RegioneResponse>(reg);
        }

        public RegioneResponse DeleteRegione(DeleteRegione add)
        {
            var reg = _mapper.Map<Regione>(add);
            _regionerepository.Delete(reg);
            return _mapper.Map<RegioneResponse>(reg);
        }

        public RegioneResponse EditRegione(EditRegione add)
        {
            var reg = _mapper.Map<Regione>(add);
            _regionerepository.Update(reg);
            return _mapper.Map<RegioneResponse>(reg);
        }

        public RegioneResponse GetRegione(int add)
        {
            var reg = _regionerepository.GetAll().Where(x => x.Id == add).FirstOrDefault();
         
            return _mapper.Map<RegioneResponse>(reg);
        }

        public List<RegioneResponse> GetRegione()
        {
           var reg = _regionerepository.GetAll().ToList();

            return _mapper.Map<List<RegioneResponse>>(reg);
        }

      


    }














}
