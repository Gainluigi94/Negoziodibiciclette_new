

using AutoMapper;
using Models.Classi;
using Repositoryy.RepositoryInterface;
using Servicee.Contract;
using Servicee.Request.Bici;
using Servicee.Response.Bici;
using System.Collections.Generic;
using System.Linq;

namespace Servicee.Implementazione { 
   public class BiciService : IBiciService
    {

        private IBiciRepository _bicirepository;
        private IMapper _mapper;


        public BiciService (IBiciRepository bicirepository, IMapper mapper)
        {
            _bicirepository = bicirepository;
            _mapper = mapper;


        }

        public GetAllBici AddBici(AddBici add)
        {
            var bici = _mapper.Map<Bici>(add);
            _bicirepository.Add(bici);
            return _mapper.Map<GetAllBici>(bici);
        }

        public List<GetAllBici> AllBici()
        {
            var ind = _bicirepository.GetAll().ToList();
            return _mapper.Map<List<GetAllBici>>(ind);
        }

        public GetAllBici DeleteBici(DeleteBici add)
        {
            var bici = _mapper.Map<Bici>(add);
            _bicirepository.Delete(bici);
            return _mapper.Map<GetAllBici>(bici);
        }

        public GetAllBici UpdateBici(EditBici add)
        {
            var bici = _mapper.Map<Bici>(add);
            _bicirepository.Update(bici);
            return _mapper.Map<GetAllBici>(bici);
        }


        public GetAllBici GetBici(int add)
        {
            var bici = _bicirepository.GetAll().Where(x => x.Id == add).FirstOrDefault();
           
            return _mapper.Map<GetAllBici>(bici);
        }


    }
}
