using Assignment1._0.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0.Interfaces
{
    public interface IRegistration
    {

        int RegID { get; set; }
        string RegName { get; set; }
        RegistrationStatus RegStatus { get; set; }
        DateTime RegDate { get; set; }
        
    }
}
