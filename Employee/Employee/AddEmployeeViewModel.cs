using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Admin;

namespace Employee
{
   public class AddEmployeeViewModel: INotifyPropertyChanged
    {

        public enum Status
        {
            Activate,
            Deactivate
        }

        private Status s;
        public Status status {


            get { return s; }
            set {

                if (s== value) {
                    PropertyChanged(this, new PropertyChangedEventArgs("Status"));
                    PropertyChanged(this, new PropertyChangedEventArgs("IsActivate"));
                    PropertyChanged(this, new PropertyChangedEventArgs("IsDeactivate"));
                }
                    
             }
        }

        public bool IsActive
        {
            get { return status == Status.Activate; }
            set { status = value ? Status.Activate : status; }
        }



        public bool IsDeactivate
        {

            get { return status == Status.Deactivate; }
            set { status = value ? Status.Deactivate : status; }
        }

        public AddEmployeeViewModel() {
            addEmployee = new Command(AddEmployeeFunction);
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _middleName;
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _address;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        
        public ICommand addEmployee
        {
            get; set;
        }
       
    
        public void AddEmployeeFunction() {
            VerifyDetails obj = new VerifyDetails();
            string status;
            try
            {
                obj.verify(FirstName, LastName, MiddleName, Email, Address);
                emp newEmployee = new emp();
                newEmployee.FirstName = FirstName;
                newEmployee.LastName = LastName;
                newEmployee.MiddleName = MiddleName;
                newEmployee.Email = Email;
                newEmployee.Emp_Adress = Address;

                if (IsActive)
                {
                    status = "Activate";
                }
                else {
                    status = "Deactivate";
                }
                newEmployee.Status = status;
                EmployeeAdmin.AddNewEmployee(newEmployee);
                MessageBox.Show(FirstName +"  "+ LastName + " info Added ");

            }
            catch (InvalidInputException e) {

                MessageBox.Show("Error : \n "+e.Message);
            }
        }
       


    }
}
