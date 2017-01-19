using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;

namespace Employee
{
    public class EditEmployeeViewModel : INotifyPropertyChanged
    {
        private List<emp> _employeeList;
        public List<emp> EmployeeList
        {
            get { return _employeeList; }
            set {   _employeeList = value;
                }
            }



        private emp _selectedEmployee;
        public emp SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {

                if (value != _selectedEmployee)
                {
                    _selectedEmployee = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("SelectedEmployee"));
                    }
                }

            }
        }


        public ICommand UpdateEmployeeBtn
        {
            get; set;
        }

        public ICommand DeleteEmployeeBtn {
            get;set;
        }

        public EditEmployeeViewModel() {
            EmployeeDataDataContext connection = new EmployeeDataDataContext();
            EmployeeList = (from s in connection.emps select s).ToList();
            UpdateEmployeeBtn = new Command(UpdateEmployeeButtonClick);
            DeleteEmployeeBtn = new Command(DeleteEmployee);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void UpdateEmployeeButtonClick() {

            if (SelectedEmployee == null)
            {
                MessageBox.Show("You must select a employee");
            }
            else
            {
                UpdateEmployee updateEmployee = new UpdateEmployee(SelectedEmployee);
                updateEmployee.ShowDialog();
            }
        }

        public void DeleteEmployee() {

            if (SelectedEmployee == null)
                MessageBox.Show("You must select a employee");
            else {
                if (MessageBoxResult.Yes == MessageBox.Show("Are you sure", "delete Employee",
                   MessageBoxButton.YesNo, MessageBoxImage.Warning))
                {
                    EmployeeAdmin.DeleteEmployee(SelectedEmployee);
                    MessageBox.Show("Successfully Deleted");
                }
            }
        }
    }
}
