using Assignment1._0.Interfaces;
using Assignment1._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0
{
    public class Manager : IManager
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int NIC { get; set; }
        public int MobileNum { get; set; }
        public List<Notifications> NotificationsList { get; set; }
        public string Department { get ; set ; }

        public void ApproveRegistration(Registration reg)
        {
            
        }

        public void DisaproveRegistration(Registration reg)
        {
            
        }

        public void DisplayUserInfo()
        {
            
        }

        public void Login()
        {
            
        }

        public void Logout()
        {
            
        }

        public void SeeNotifications()
        {
            
        }

        public List<Registration> ViewRegistrationList()
        {
            throw new NotImplementedException();
        }
    }
}
