using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rapnetApi.BLL
{
    public class GeneralFunctions
    {

        /// <summary>
        /// Super secret unique Id algorithm for the table
        /// </summary>
        /// <returns></returns>
        internal int genarateUniqueID()
        {
            Random rnd = new Random();
            return rnd.Next(6, 99999999);
        }
    }
}
