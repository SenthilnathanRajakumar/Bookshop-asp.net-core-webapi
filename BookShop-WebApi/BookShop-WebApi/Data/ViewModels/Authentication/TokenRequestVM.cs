﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop_WebApi.Data.ViewModels.Authentication
{
    public class TokenRequestVM
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
