using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin;
using System.Windows.Input;
using System.Windows;

namespace Employee
{
   public  class UpdateEmployeeViewModel
    {
        private string _firstName;
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _middleName;

        public string middleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _emp_Address;

        public string emp_Address
        {
            get { return _emp_Address; }
            set { _emp_Address = value; }
        }

        private int employeeId;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }


        public UpdateEmployeeViewModel(emp employee) {

            firstName = employee.FirstName;
            lastName = employee.LastName;
            middleName = employee.MiddleName;
            email = employee.Email;
            employeeId = employee.EmployeeID;
            emp_Address = employee.Emp_Adress;
            UpdateBtn = new Command(OnUpdateBtnClick);            
        }

        public ICommand UpdateBtn
        {
            get; set;
        }

        public void OnUpdateBtnClick() {

            VerifyDetails obj = new VerifyDetails();
            try
            {
                obj.verify(firstName, lastName, middleName, email, emp_Address);
                emp employee = new emp();
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.MiddleName = middleName;
                employee.Status = "Activate";
                employee.Emp_Adress = emp_Address;
                employee.Email = email;
                employee.EmployeeID = EmployeeId;
                EmployeeAdmin.UpdateEmployee(employee);
                MessageBox.Show(firstName + " " + lastName + "Info updated");
            }
            catch (InvalidInputException e)
            {

                MessageBox.Show("Error : \n " + e.Message);
            }
        }
    }
}
