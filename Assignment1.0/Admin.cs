﻿using Assignment1._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0
{
    internal class Admin : IAdmin
    {
        public string Name { get ; set ; }
        public string Password { get ; set ; }
        public string Email { get; set; }
        public int NIC { get; set; }
        public int mobileNum { get; set; }

        public void AddTraining(Training training)
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

        public void RemoveTraining(Training training)
        {
            
        }

        public void UpdateTraining(Training training)
        {
            
        }
    }
}
