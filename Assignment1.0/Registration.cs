﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0
{
    public class Registration
    {
        private int RegID { get; set; }
        public string RegName { get; set; }
        public  string RegStatus { get; set;}
        public DateTime RegDate { get; set; }
        public string Message {  get; set; }



        public Employee RegisteredEmployee { get; set; }
        public Training TrainingSession { get; set; }

        public Registration(Employee employee, Training training)
        {
            RegisteredEmployee = employee;
            TrainingSession = training;
        }

        
        



    }
}
