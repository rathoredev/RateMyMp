using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rateMyMp.App_Code.BO
{
    public class constituencyBO
    {
        public Int16 constituencyId
        {
            get;
            set;
        }

        public byte StateId
        {
            get;
            set;
        }

        public string constituency
        {
            get;
            set;
        }


        public Int16 partyId { get; set; }

        public int countryId { get; set; }
    }
}