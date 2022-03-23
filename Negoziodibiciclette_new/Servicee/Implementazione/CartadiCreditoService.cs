


using AutoMapper;
using Models.Classi;

using Repositoryy.RepositoryInterface;
using Servicee.Contract;
using Servicee.Request.Cartadicredito;
using Servicee.Response.Cartadicredito;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Implementazione
{
  public  class CartadiCreditoService : ICartadicreditoService
    {

        private IMapper _mapper;
        private ICartadicreditoRepository _cartadicreditorepository;



        public CartadiCreditoService(IMapper mapper,ICartadicreditoRepository cartadicredito)
        {
            _mapper = mapper;
            _cartadicreditorepository = cartadicredito;
        }



        public CartadicreditoResponse addcarta(CartadicreditoRequest add)
        {
            var carta = _mapper.Map<Cartadicredito>(add);
            _cartadicreditorepository.Add(carta);
            return _mapper.Map<CartadicreditoResponse>(carta);
        }

        public CartadicreditoResponse deletecarta(DeleteCartadicredito add)
        {

            var carta = _mapper.Map<Cartadicredito>(add);
            _cartadicreditorepository.Delete(carta);
            return _mapper.Map<CartadicreditoResponse>(carta);
        }

        public List<CartadicreditoResponse> GetAllCarte()
        {
            var carta = _cartadicreditorepository.GetAll().ToList();
            return _mapper.Map<List<CartadicreditoResponse>>(carta);
        }
        
        public CartadicreditoResponse Getcarta(int add)
        {
            var carta = _cartadicreditorepository.GetAll().Where(x => x.Id == add).FirstOrDefault();
            return _mapper.Map<CartadicreditoResponse>(carta);
        }
    }
}
