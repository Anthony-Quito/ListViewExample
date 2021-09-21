using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public ListViewSource()
        {
            InitializeComponent();
            //ObservableCollection allows items to be addeb after ItemsSource
            //is set and the UI will react to changes
            EmployeeView.ItemsSource = employees;
            Employees.Add(new Employee { DisplayName = "Rob Finnerty" });
            Employees.Add(new Employee { DisplayName = "Bill Wrestler" });
            Employees.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper" });
            Employees.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy" });
            Employees.Add(new Employee { DisplayName = "Sheri Spruce" });
            Employees.Add(new Employee { DisplayName = "Burt Indybrick" });
        }
    }
}