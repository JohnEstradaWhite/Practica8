﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Practica8
{
    public interface Azure
    {
        Task<MobileServiceUser> Authenticate();
    }
}
