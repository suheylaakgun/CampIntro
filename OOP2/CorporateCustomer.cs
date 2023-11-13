using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Miras :  inheritance
    public class CorporateCustomer:Customer
    {
        public string CompanyName { get; set; } = string.Empty;
        public string TaxNo { get; set; } = string.Empty;

    }
}
