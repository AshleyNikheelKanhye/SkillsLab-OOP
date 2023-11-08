using Assignment1._0.Services;
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
        int MobileNum { get; set; }

        string Department { get; set; }


        List<Notifications> NotificationsList { get; set; }

        List<Registration> ViewRegistrationList();

        void Login();
        void Logout();

        void DisplayUserInfo();

        void ApproveRegistration(Registration reg);
        void DisaproveRegistration(Registration reg);

        void SeeNotifications();










    }
}
