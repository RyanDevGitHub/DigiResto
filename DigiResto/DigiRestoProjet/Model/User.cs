﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRestoProjet.Model
{

    public class User
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsManager { get; set; }
        public string? ManageBy { get; set; }

    }
}
