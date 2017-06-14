using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models.ViewModels
{
    public class ItemViewModel<T> : BaseViewModel
    {
        public T Item { get; set; }

        public static implicit operator ItemViewModel<T>(ItemViewModel<int?> v)
        {
            throw new NotImplementedException();
        }
    }
}