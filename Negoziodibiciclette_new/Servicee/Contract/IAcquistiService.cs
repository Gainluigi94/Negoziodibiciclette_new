using Servicee.Request.Acquisti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Contract
{
  public  interface IAcquistiService
    {


        public GetAllAcquisti AddAcquisti(AddAcquisti add);

        public GetAllAcquisti DeleteAcquisti(DeleteAcquisti add);


        GetAllAcquisti GetAcquisti(int add);

        public List<GetAllAcquisti> GetAllAcquisti();




    }
}
