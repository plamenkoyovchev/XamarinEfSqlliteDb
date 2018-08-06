using System;

using TestEFSqLiteOnXamarin.Models;

namespace TestEFSqLiteOnXamarin.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
