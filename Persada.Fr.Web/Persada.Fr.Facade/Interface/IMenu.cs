using Newtonsoft.Json.Linq;
using Persada.Fr.Model;
using Persada.Fr.Model.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persada.Fr.Facade.Interface
{
    public interface IMenu
    {
        List<TOURIS_TM_MENU> GridBindMenu();
        TOURIS_TM_MENU RetrivedMenu(int id);
        bool Add(TOURIS_TM_MENU menu);
        bool Edit(int id, TOURIS_TM_MENU menu);
        bool Delete(int id);
    }
}
