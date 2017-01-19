using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Employee
{
    public class MainWindowViewModel
    {

        public MainWindowViewModel() {

            addEmployee = new Command(CreateEmployee);
            editEmployee = new Command(EditEmployee);
            viewEmployee = new Command(ViewEmployee);
        }
        public ICommand addEmployee
        {
            get; set;
        }
        public ICommand editEmployee
        {
            get; set;
        }
        public ICommand viewEmployee
        {
            get; set;
        }


        public void CreateEmployee() {
            AddEmployee addEmp = new AddEmployee();
            addEmp.ShowDialog();
        }

        public void EditEmployee() {
            EditEmployee editEmp = new EditEmployee();
            editEmp.ShowDialog();
        }

        public void ViewEmployee() {
            ViewEmployee viewEmp = new ViewEmployee();
            viewEmp.ShowDialog();
        }
    }
}
