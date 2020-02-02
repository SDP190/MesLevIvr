using AdvancedData.Data.Misc;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedData.Data.Helpers
{
    public class MatzosHelper
    {
        public static decimal GetIdForMatzahTypeInput(string matzahTypeInput)
        {
            switch (matzahTypeInput)
            {
                case MatzahTypeInputs.CHABIRA_REG:
                    return 451;
                case MatzahTypeInputs.CHABIRA_WW:
                    return 2173;
                case MatzahTypeInputs.SKVERE:
                    return 3658;
                case MatzahTypeInputs.SATMARKJ:
                    return 3657;
                case MatzahTypeInputs.BETSHEMESH:
                    return 2174;
                case MatzahTypeInputs.BOROPARK_REG:
                    return 449;
                case MatzahTypeInputs.BOROPARK_WW:
                    return 450;
                case MatzahTypeInputs.KERESTIER:
                    return 1362;
                case MatzahTypeInputs.SATMARRUTLEDGE:
                    return 448;
                case MatzahTypeInputs.KOMMIS:
                    return 3657;
                                    
                default:                    
                    break;

            }
            return 0;
        }
    }

}
