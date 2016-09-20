using System.Windows;
using CRUD_Inventory.ViewModel;
using System;

namespace CRUD_Inventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();

            // When window is closed, shutdown app
            Closing += (s, e) => Environment.Exit(0);
        }
    }
}