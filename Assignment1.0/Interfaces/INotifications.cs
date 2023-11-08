using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0.Interfaces
{
    public interface INotifications
    {

        string NotifName{ get; set; }
        DateTime NotifDate { get; set; }
        string NotifDetails {  get; set; }



        void NotificationAfterRegistration(Employee Sender, Manager Receiver);

        void NotificationForApproval(Manager Sender,Employee Receiver);

        void NotificationForDecline(Manager Sender, Employee Receiver);


        

    }
}
