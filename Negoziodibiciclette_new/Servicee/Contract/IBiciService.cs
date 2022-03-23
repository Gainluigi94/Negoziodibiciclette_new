using Servicee.Request.Bici;
using Servicee.Response.Bici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Contract
{
    public interface IBiciService
    {

        public GetAllBici AddBici(AddBici add);

        public GetAllBici DeleteBici(DeleteBici add);

        public GetAllBici UpdateBici(EditBici add);
        
        public List<GetAllBici> AllBici();

        public GetAllBici GetBici(int add);


    }
}
