﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    public class Repo
    {
        internal StoreContext db;
        internal Repo() { 
            db = new StoreContext();
        }

    }
}
