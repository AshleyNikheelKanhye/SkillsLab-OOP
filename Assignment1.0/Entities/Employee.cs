using Assignment1._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0
{
    public class Employee : IEmployee
    {
        public string Name { get ; set ; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int NIC { get; set; }
        public int mobileNum { get; set; }
        public string department { get; set; }
        public List<Notifications> NotificationsList { get; set; }
        public List<object> Qualifications { get ; set ; }
        public Manager manager { get ; set ; }

        public void DisplayUserInfo()
        {
            
        }

        public Manager getManager()
        {
            return this.manager;
        }

        public void Login()
        {
            
        }

        public void Logout()
        {
            
        }

        public void UploadProofs()
        {
            
        }
    }
}
