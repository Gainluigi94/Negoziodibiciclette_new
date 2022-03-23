

using AutoMapper;
using Models.Classi;
using Repositoryy.RepositoryInterface;
using Servicee.Contract;
using Servicee.Request.Acquisti;
using Servicee.Response.Bici;
using System.Collections.Generic;
using System.Linq;

namespace Servicee.Implementazione
{
  public  class AcquistiService : IAcquistiService
    {
        private IMapper _mapper;
        private IAcquistiRepository _acquistirepository;


        public AcquistiService (IMapper mapper, IAcquistiRepository acquistirepository)
        {
            _mapper = mapper;
            _acquistirepository = acquistirepository;
        }


        
        public GetAllAcquisti AddAcquisti(AddAcquisti add)
        {

            var bici = _mapper.Map<Acquisti>(add);
            _acquistirepository.Add(bici);
            return _mapper.Map<GetAllAcquisti>(bici);




        }

        public GetAllAcquisti DeleteAcquisti(DeleteAcquisti add)
        {

            var bici = _mapper.Map<Acquisti>(add);
            _acquistirepository.Delete(bici);
            return _mapper.Map<GetAllAcquisti>(bici);

        }

    
        public GetAllAcquisti GetAcquisti(int add)
        {
            var acquisto = _acquistirepository.GetAll().Where(x => x.Id == add).FirstOrDefault();
            return _mapper.Map<GetAllAcquisti>(acquisto);
        }



       

        public List<GetAllAcquisti> GetAllAcquisti()
        {
             var acquisto = _acquistirepository.GetAll().ToList();
            return _mapper.Map<List<GetAllAcquisti>>(acquisto);
        }
    }
}
