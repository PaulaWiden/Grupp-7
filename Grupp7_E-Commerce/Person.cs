﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grupp7_E_Commerce
{
    abstract public class User
    {
        public int userId
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string username
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string password
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public bool loginStatus
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string email
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public bool verifyLogIn()
        {
            throw new System.NotImplementedException();
        }

        public bool isAdmin()
        {
            throw new System.NotImplementedException();
        }
    }
}