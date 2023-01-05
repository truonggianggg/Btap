﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment_2
{
    internal abstract class AbstractPhone
    {
        public abstract void InsertPhone(String name, String phone);

        public abstract void RemovePhone(String name);

        public abstract void UpdatePhone(String name, String oldPhone, String newPhone);

        public abstract PhoneNumber SearchPhone(String name);

        public abstract void Sort();
    }
}
