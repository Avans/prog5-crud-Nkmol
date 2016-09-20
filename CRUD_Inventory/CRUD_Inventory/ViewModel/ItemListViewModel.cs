using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CRUD_Inventory.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ItemListViewModel : ViewModelBase
    {
        public ObservableCollection<ItemViewModel> items { get; private set; }

        public ItemViewModel selectedItem { get; set; }

        public RelayCommand AddItemToInventoryCommand { get; private set; }

        public ItemListViewModel()
        {
            items = new ObservableCollection<ItemViewModel>();
            AddItemToInventoryCommand = new RelayCommand(AddItemToInventory, _canAddToInventory);
            createItemList();
        }

        public void addItem(ItemViewModel item)
        {
            items.Add(item);
        }

        public void removeItem(ItemViewModel item)
        {
            items.Remove(item);
        }

        public void AddItemToInventory()
        {
            System.Diagnostics.Debug.WriteLine("Selected item " + selectedItem.Name, "Debug");

            // Add item to inventory
            var inventory = (new ViewModelLocator()).InventoryViewModel;
            inventory.addItem(selectedItem);

            // Remove item from itemList
            removeItem(selectedItem);

        }

        private bool _canAddToInventory()
        {
            var inventory = (new ViewModelLocator()).InventoryViewModel;
            return InventoryViewModel.MAX_INVENTORY_SPACE > inventory.used;
        }

        // Hardcoded itemlist value
        private readonly string[] itemNames = new string[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5",
            "Item 6",
            "Item 7",
            "Item 8",
            "Item 9",
            "Item 10",
        };
        private void createItemList()
        {
            foreach (string name in itemNames)
                addItem(new ItemViewModel(name));
        }
    }
}