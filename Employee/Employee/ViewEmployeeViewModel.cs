using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin;

namespace Employee
{
    public class ViewEmployeeViewModel
    {
        private List<emp> _employeeList;

        public List<emp> EmplopyeeList
        {
            get { return _employeeList; }
            set { _employeeList = value; }
        }

        public ViewEmployeeViewModel() {
            EmployeeDataDataContext connection = new EmployeeDataDataContext();
            _employeeList = (from s in connection.emps select s).ToList();
        }
        

    }
}
