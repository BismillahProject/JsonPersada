using Newtonsoft.Json.Linq;
using Persada.Fr.Facade.Interface;
using Persada.Fr.Facade.Repository;
using Persada.Fr.Model;
using Persada.Fr.Model.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Persada.Fr.We.Api.Controllers
{
    public class MenuController : ApiController
    {
        private EnumFuncStatus fn = new EnumFuncStatus();

        IMenu repo;
        public MenuController()
        {
            repo = new MenuRepo();
        }

        [HttpGet]
        public IHttpActionResult GridBind()
        {
            ApiResData res = new ApiResData();
            List<TOURIS_TM_MENU> isGet = repo.GridBindMenu();

            if (isGet.Count > 0)
                return Content(HttpStatusCode.Created, res.ResGetDataTable(isGet.Cast<object>().ToArray(), null));
            else
                return Content(HttpStatusCode.Created, res.ResGetDataTable(null, new Exception(fn.fg.DataNf)));
        }

        [HttpGet]
        public IHttpActionResult RetrivedData(int id)
        {
            ApiResData res = new ApiResData();
            TOURIS_TM_MENU isGet = repo.RetrivedMenu(id);

            if (isGet != null)
                return Content(HttpStatusCode.Created, res.ResGetDataTable(new object[] { isGet }, null));
            else
                return Content(HttpStatusCode.Created, res.ResGetDataTable(null, new Exception(fn.fg.DataNf)));
        }

        [HttpPost]
        public IHttpActionResult Add(TOURIS_TM_MENU menu)
        {
            ApiResData res = new ApiResData();
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.Created, res.ResCUD(fn.fg.Save, new Exception(fn.fg.DataIsntValid)));
            }

            var isSave = repo.Add(menu);
            if (isSave == true)
                return Content(HttpStatusCode.Created, res.ResCUD(fn.fg.Save, null));
            else
                return Content(HttpStatusCode.Created, res.ResCUD(fn.fg.Save, new Exception(fn.fg.SFailed)));
        }

        [HttpPut]
        public IHttpActionResult Edit(TOURIS_TM_MENU menu)
        {
            ApiResData res = new ApiResData();
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.Created, res.ResCUD(fn.fg.Edit, new Exception(fn.fg.DataIsntValid)));
            }

            var isUpdate = repo.Edit(menu.ID, menu);
            if (isUpdate == true)
                return Content(HttpStatusCode.Created, res.ResCUD(fn.fg.Edit, null));
            else
                return Content(HttpStatusCode.Created, res.ResCUD(fn.fg.Edit, new Exception(fn.fg.EFailed)));
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            ApiResData res = new ApiResData();
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.Created, res.ResCUD(fn.fg.Delete, new Exception(fn.fg.DataNf)));
            }

            var isDelete = repo.Delete(id);
            if (isDelete == true)
                return Content(HttpStatusCode.Created, res.ResCUD(fn.fg.Delete, null));
            else
                return Content(HttpStatusCode.Created, res.ResCUD(fn.fg.Delete, new Exception(fn.fg.DFailed)));
        }

        /*begin sample kiriman data
        1.Edit
            {
                "ID":"2",
                "MENU_NAME":"Menu2",
                "MENU_PARENT_ID":"2",
                "MENU_DESCRIPTION":"Parent 2 Description",
                "CREATED_TIME":"2018-02-01 23:33:54.370",
                "CREATED_BY":"Bowo"
            }
         2.Add
            {
                "MENU_NAME":"Menu 14",
                "MENU_PARENT_ID":"14",
                "MENU_DESCRIPTION":"Parent 14 Description",
                "CREATED_TIME":"2018-02-01 23:33:54.370",
                "CREATED_BY":"Bowo",
            }
         end sample kiriman data*/
    }
}
