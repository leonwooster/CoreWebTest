using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CoreWebTest.Resources;

namespace CoreWebTest.Attributes
{
    public class CountryBasedDisplayName : DisplayNameAttribute
    {
        public string Country { get; set; }
        public CountryBasedDisplayName(string country)
        {
            Country = country;
        }

        public override string DisplayName
        {
            get
            {
                if (Country == "VN")
                    return GeneralResource.DisplayVN;
                else return GeneralResource.DisplayMY;
            }
        }
    }
}
