using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0
{
    internal interface IEmployee
    {

        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        int NIC {  get; set; }
        int mobileNum {  get; set; }
        string department {  get; set; }

        void Login();
        void Logout();

        void DisplayUserInfo();

        void UploadProofs();




    }
}
