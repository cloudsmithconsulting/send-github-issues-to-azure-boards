﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssuesToWorkItems.ViewModels
{
    public class BaseViewModel
    {
        public string organization { get; set; }
        public string pat { get; set; }
        public string project { get; set; }
    }
}
