using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using _301264350_shields_Lab3.Models;

namespace _301264350_shields_Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // ObservableCollection to hold menu items so changes automatically shown in UI
        private ObservableCollection<BillItem> _selectedBillItems = new ObservableCollection<BillItem>();

        // ObservableCollection to hold selected bill items
        public ObservableCollection<BillItem> SelectedBillItems
        {
            get { return _selectedBillItems; }
            set
            {
                _selectedBillItems = value;
                OnPropertyChanged(nameof(SelectedBillItems));  // raise event when collection changes
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            InitializeMenu();  
            
        }

        public void InitializeMenu()
        {
            SelectedBillItems = new ObservableCollection<BillItem>();
            // add all of the menu items to the ObservableCollection
            SelectedBillItems.Add(new BillItem() { Name = "Soda", Category = "Beverage", Price = 1.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Tea", Category = "Beverage", Price = 1.50m });
            SelectedBillItems.Add(new BillItem() { Name = "Coffee", Category = "Beverage", Price = 1.25m });
            SelectedBillItems.Add(new BillItem() { Name = "Mineral Water", Category = "Beverage", Price = 2.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Juice", Category = "Beverage", Price = 2.50m });
            SelectedBillItems.Add(new BillItem() { Name = "Buffalo Wings", Category = "Appetizer", Price = 5.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Buffalo Fingers", Category = "Appetizer", Price = 6.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Potato Skins", Category = "Appetizer", Price = 8.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Nachos", Category = "Appetizer", Price = 8.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Mushroom Caps", Category = "Appetizer", Price = 10.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Shrimp Cocktail", Category = "Appetizer", Price = 12.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Chips and Salsa", Category = "Appetizer", Price = 6.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Seafood Alfredo", Category = "Main Course", Price = 15.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Chicken Alfredo", Category = "Main Course", Price = 13.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Chicken Picatta", Category = "Main Course", Price = 13.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Turkey Club", Category = "Main Course", Price = 11.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Lobster Pie", Category = "Main Course", Price = 19.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Prime Rib", Category = "Main Course", Price = 20.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Shrimp Scampi", Category = "Main Course", Price = 18.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Turkey Dinner", Category = "Main Course", Price = 13.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Stuffed Chicken", Category = "Main Course", Price = 14.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Apple Pie", Category = "Dessert", Price = 5.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Sundae", Category = "Dessert", Price = 3.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Carrot Cake", Category = "Dessert", Price = 5.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Mud Pie", Category = "Dessert", Price = 4.95m });
            SelectedBillItems.Add(new BillItem() { Name = "Apple Crisp", Category = "Dessert", Price = 5.95m });

            // bind the ComboBoxes
            comboBoxBeverage.ItemsSource = SelectedBillItems.Where(item => item.Category == "Beverage");
            comboBoxBeverage.DisplayMemberPath = "Name";

            comboBoxAppetizer.ItemsSource = SelectedBillItems.Where(item => item.Category == "Appetizer");
            comboBoxAppetizer.DisplayMemberPath = "Name";

            comboBoxMainCourse.ItemsSource = SelectedBillItems.Where(item => item.Category == "Main Course");
            comboBoxMainCourse.DisplayMemberPath = "Name";

            comboBoxDessert.ItemsSource = SelectedBillItems.Where(item => item.Category == "Dessert");
            comboBoxDessert.DisplayMemberPath = "Name";
        }

        private void UpdateBillSummary()
        {
            decimal subtotal = 0;
            foreach (BillItem item in SelectedBillItems)
            {
                subtotal += item.Price * item.Quantity;
            }

            textBlockSubtotal.Text = subtotal.ToString("C2"); // currency formatter

            decimal taxRate = 0.13m;
            decimal tax = subtotal * taxRate;
            textBlockTax.Text = tax.ToString("C2");

            decimal total = subtotal + tax;
            textBlockTotal.Text = total.ToString("C2");

        }

        private void comboBoxBeverage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BillItem selectedItem = (BillItem)comboBoxBeverage.SelectedItem;
            if (selectedItem != null)
            {
                // Check if the item already exists in SelectedBillItems
                BillItem existingItem = SelectedBillItems.FirstOrDefault(item => item.Name == selectedItem.Name);
                if (existingItem != null)
                {
                    // If the item exists, increase its quantity
                    existingItem.Quantity++;
                }
                else
                {
                    // Otherwise, add the item to SelectedBillItems
                    selectedItem.Quantity = 1;
                    SelectedBillItems.Add(selectedItem);
                }

                OnPropertyChanged(nameof(SelectedBillItems));
                UpdateBillSummary();
            }
        }

        private void comboBoxMainCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BillItem selectedItem = (BillItem)comboBoxMainCourse.SelectedItem;
            if (selectedItem != null)
            {
                // Check if the item already exists in SelectedBillItems
                BillItem existingItem = SelectedBillItems.FirstOrDefault(item => item.Name == selectedItem.Name);
                if (existingItem != null)
                {
                    // If the item exists, increase its quantity
                    existingItem.Quantity++;
                }
                else
                {
                    // Otherwise, add the item to SelectedBillItems
                    selectedItem.Quantity = 1;
                    SelectedBillItems.Add(selectedItem);
                }

                OnPropertyChanged(nameof(SelectedBillItems));
                UpdateBillSummary();
            }
        }

        private void comboBoxDessert_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BillItem selectedItem = (BillItem)comboBoxDessert.SelectedItem;
            if (selectedItem != null)
            {
                // Check if the item already exists in SelectedBillItems
                BillItem existingItem = SelectedBillItems.FirstOrDefault(item => item.Name == selectedItem.Name);
                if (existingItem != null)
                {
                    // If the item exists, increase its quantity
                    existingItem.Quantity++;
                }
                else
                {
                    // Otherwise, add the item to SelectedBillItems
                    selectedItem.Quantity = 1;
                    SelectedBillItems.Add(selectedItem);
                }

                OnPropertyChanged(nameof(SelectedBillItems));
                UpdateBillSummary();
            }
        }

        private void comboBoxAppetizer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BillItem selectedItem = (BillItem)comboBoxAppetizer.SelectedItem;
            if (selectedItem != null)
            {
                // Check if the item already exists in SelectedBillItems
                BillItem existingItem = SelectedBillItems.FirstOrDefault(item => item.Name == selectedItem.Name);
                if (existingItem != null)
                {
                    // If the item exists, increase its quantity
                    existingItem.Quantity++;
                }
                else
                {
                    // Otherwise, add the item to SelectedBillItems
                    selectedItem.Quantity = 1;
                    SelectedBillItems.Add(selectedItem);
                }

                OnPropertyChanged(nameof(SelectedBillItems));
                UpdateBillSummary();
            }
        }

        private void ClearBill_Click(object sender, RoutedEventArgs e)
        {
            // clear selectedBillItems
            SelectedBillItems.Clear();

            // update UI elements
            textBlockSubtotal.Text = "$0.00";
            textBlockTax.Text = "$0.00";
            textBlockTotal.Text = "$0.00";
        }

        private void CompanyLogo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://www.centennialcollege.ca/");
            }
            catch (Exception ex)
            {
                // Handle the potential exception if launching the browser fails.
                MessageBox.Show("Error launching the website: " + ex.Message);
            }
        }
    }
}
