using Assignment1._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0.Services
{
    public class Notifications : INotifications
    {
        public string NotifName { get; set; }
        public DateTime NotifDate { get; set ; }
        public string NotifDetails { get ; set ; }

        public void NotificationAfterRegistration(Employee Sender, Manager Receiver)
        {
            
        }

        public void NotificationForApproval(Manager Sender, Employee Receiver)
        {
            
        }

        public void NotificationForDecline(Manager Sender, Employee Receiver)
        {
            
        }


    }
}
