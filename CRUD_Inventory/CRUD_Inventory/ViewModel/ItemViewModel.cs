using GalaSoft.MvvmLight;
using CRUD_Inventory.Model;

namespace CRUD_Inventory.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ItemViewModel : ViewModelBase
    {
        private Item _item;
        /// <summary>
        /// Initializes a new instance of the ItemViewModel class.
        /// </summary>
        public ItemViewModel(Item item)
        {
            _item = item;
        }

        public ItemViewModel(string itemName)
        {
            _item = new Item();
            _item.name = itemName;
        }

        public string Name { get { return _item.name; } }
    }
}