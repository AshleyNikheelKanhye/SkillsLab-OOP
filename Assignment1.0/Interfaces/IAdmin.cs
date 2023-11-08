using Assignment1._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0.Interfaces
{
    public interface IAdmin
    {
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        int NIC { get; set; }
        int mobileNum { get; set; }

        



        void Login();
        void Logout();

        void DisplayUserInfo();

        void AddTraining(Training training);
        void RemoveTraining(Training training);
        void UpdateTraining(Training training);




    }
}
