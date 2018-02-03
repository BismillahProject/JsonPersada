using Newtonsoft.Json.Linq;
using Persada.Fr.Facade.Interface;
using Persada.Fr.Model;
using Persada.Fr.Model.Context;
using Persada.Fr.Model.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persada.Fr.Facade.Repository
{
    public class MenuRepo : ApiResData, IMenu
    {
        private EnumStatus fn = new EnumStatus();
        private DbCtx _ctx;

        public MenuRepo()
        {
            _ctx = new DbCtx();
        }

        public List<TOURIS_TM_MENU> GridBindMenu()
        {
            try
            {
                return _ctx.TOURIS_TM_MENU.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public TOURIS_TM_MENU RetrivedMenu(int id)
        {
            try
            {
                return _ctx.TOURIS_TM_MENU.Where(x => x.ID == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Add(TOURIS_TM_MENU menu)
        {
            try
            {
                menu.ROW_STATUS = fn.fg.IsActive;
                _ctx.TOURIS_TM_MENU.Add(menu);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(int id, TOURIS_TM_MENU menu)
        {
            try
            {
                TOURIS_TM_MENU mn = _ctx.TOURIS_TM_MENU.Find(id);
                //mn.ID = menu.ID;
                mn.MENU_NAME = menu.MENU_NAME;
                mn.MENU_PARENT_ID = menu.MENU_PARENT_ID;
                mn.MENU_DESCRIPTION = menu.MENU_DESCRIPTION;
                mn.CREATED_TIME = menu.CREATED_TIME;
                mn.CREATED_BY = menu.CREATED_BY;
                mn.LAST_MODIFIED_TIME = menu.LAST_MODIFIED_TIME;
                mn.LAST_MODIFIED_BY = menu.LAST_MODIFIED_BY;
                mn.ROW_STATUS = fn.fg.IsActive;

                _ctx.Entry(mn).State = System.Data.Entity.EntityState.Modified;
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                TOURIS_TM_MENU menu = _ctx.TOURIS_TM_MENU.Find(id);
                menu.ROW_STATUS = fn.fg.NotActive;

                _ctx.Entry(menu).State = EntityState.Modified;
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
