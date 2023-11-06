using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0.Interfaces
{
    internal interface IManager
    {
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        int NIC { get; set; }
        int mobileNum { get; set; }




        void Login();
        void Logout();

        void DisplayUserInfo();

        List<Registration> ViewRegistrationList();

        void ApproveRegistration(Registration reg);
        void DisaproveRegistration(Registration reg);









    }
}
