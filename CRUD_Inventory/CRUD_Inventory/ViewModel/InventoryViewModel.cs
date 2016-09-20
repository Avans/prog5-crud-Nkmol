using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace CRUD_Inventory.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class InventoryViewModel : ViewModelBase
    {
        public const int MAX_INVENTORY_SPACE = 6;

        public ObservableCollection<ItemViewModel> items { get; private set; }

        public int used
        {
            get { return items.Count; }
        }

        /// <summary>
        /// Initializes a new instance of the InventoryViewModel class.
        /// </summary>
        public InventoryViewModel()
        {
            items = new ObservableCollection<ItemViewModel>();
        }

        public void addItem(ItemViewModel item)
        {
            items.Add(item);
        }
    }
}