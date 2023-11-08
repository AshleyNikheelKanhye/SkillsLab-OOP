using Assignment1._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0
{
    public interface IEmployee
    {

        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        int NIC {  get; set; }
        int mobileNum {  get; set; }
        string department {  get; set; }
        List<Notifications> NotificationsList { get; set; }

        Manager manager { get; set; }

        List<object> Qualifications { get; set; }  //the prerequisite that is needed to be uploaded by the employee for registering for a training.


        void Login();
        void Logout();

        void DisplayUserInfo();

        void UploadProofs();

        Manager getManager();




    }
}
