using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Persada.Fr.Facade;
using Persada.Fr.Facade.Interface;
using Persada.Fr.Facade.Repository;
using Persada.Fr.Model;
using Persada.Fr.Model.Context;
using Persada.Fr.Model.Master;
using Persada.Fr.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Persada.Fr.We.Api.Controllers
{
    public class UserController : ApiController
    {
        IMenu repo;
        public UserController()
        {
            repo = new MenuRepo();
        }

        [HttpGet]
        public JObject GetDt_Muser()
        {
            using (var db = new DbCtx())
            {
                User_Fc x = new User_Fc();
                return JObject.FromObject(x.RetrivedData(db));
            }
        }
        //[HttpGet]
        //public IHttpActionResult BindData()
        //{
        //    ApiResData res = new ApiResData();
        //    List<TOURIS_TM_MENU> isGet = repo.GetDtMenu();
        //    res.ResGetDataTable(new object[] { isGet.Cast<object>().ToArray() }, null);
        //    return Content(HttpStatusCode.Created, res);
        //}
    }
}
