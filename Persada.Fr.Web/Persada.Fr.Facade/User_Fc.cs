using Persada.Fr.Model;
using Persada.Fr.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Common;

namespace Persada.Fr.Facade
{
    public class User_Fc : ApiResData
    {
        public ApiGridResponse RetrivedData(DbCtx db)
        {
            ApiGridResponse res = new ApiGridResponse();
            try
            {
                res = ResGetDataTable(new object[] { db.muser.ToList() }, null);
            }
            catch (Exception ex)
            {
                res = ResGetDataTable(null, ex);
            }
            return res;
        }


    }
}
