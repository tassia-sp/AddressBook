using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models.Responses
{
    public class ItemsResponse<T>
    {
        public List<T> Item { get; set; }
    }
}