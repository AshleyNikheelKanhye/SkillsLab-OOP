using Assignment1._0.Enums;
using Assignment1._0.Interfaces;
using Assignment1._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0
{
    public class Registration : IRegistration
    {
        public int RegID { get; set; }
        public string RegName { get; set; }
        public RegistrationStatus RegStatus { get; set;}
        public DateTime RegDate { get; set; }
        



        public Employee RegisteredEmployee { get; set; }
        public Training TrainingSession { get; set; }

        public Registration(Employee employee, Training training)
        {
            RegisteredEmployee = employee;
            TrainingSession = training;
            this.RegDate = DateTime.Now;
            this.RegStatus = RegistrationStatus.Pending;
            Notifications notifications = new Notifications();
            notifications.NotificationAfterRegistration(employee, employee.getManager());



        }

        
        



    }
}
