﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myservice
{
    public class admin
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}