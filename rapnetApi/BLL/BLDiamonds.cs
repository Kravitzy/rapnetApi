using rapnetApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rapnetApi.BLL
{
    public class BLDiamonds
    {
        /// <summary>
        /// Validate the data has no missing data
        /// </summary>
        /// <param name="diamond"></param>
        /// <returns></returns>
        internal bool validation(Diamond diamond)
        {
            if (diamond.ListPrice == 0)
            {
                return false;
            }

            if (diamond.Price == 0)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(diamond.Shape))
            {
                return false;
            }

            if (diamond.Size == 0)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(diamond.Clarity))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(diamond.Color))
            {
                return false;
            }

            return true;

        }
    }
}
