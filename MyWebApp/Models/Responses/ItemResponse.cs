﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models.Responses
{
    public class ItemResponse<T>
    {
        public T Item { get; set; }
    }
}