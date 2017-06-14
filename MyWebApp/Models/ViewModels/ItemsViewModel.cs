using System.Collections.Generic;

namespace MyWebApp.Models.ViewModels
{
    public class ItemsViewModel<T> : BaseViewModel
    {
        public List<T> Items { get; set; }
    }
}