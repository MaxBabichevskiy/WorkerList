using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorkerList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Employees = new ObservableCollection<Employee>();

            Employees.Add(new Employee { Name = "Иванов", Position = "менеджер", Salary = 1200 });
            Employees.Add(new Employee { Name = "Петров", Position = "разработчик", Salary = 900 });
            Employees.Add(new Employee { Name = "Сидоров", Position = "директор", Salary = 1500 });

            DataContext = this;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}
