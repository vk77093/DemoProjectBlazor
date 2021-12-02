using KalaShree.Controllers.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaShree.Controllers.CodeSequence
{
   public class GetNextGeneration
    {
        private readonly DataBaseContext dataBase;

        public GetNextGeneration(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }
       
    }
}
