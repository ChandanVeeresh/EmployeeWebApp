using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class EmployeeAdmin
    {
        #region Employee
        public static void AddNewEmployee(emp employee)
        {
            using (EmployeeDataDataContext con = new EmployeeDataDataContext())
            {
                con.emps.InsertOnSubmit(employee);
                con.SubmitChanges();
            }
        }


        public static void UpdateEmployee(emp employee)
        {
            using (EmployeeDataDataContext con = new EmployeeDataDataContext())
            {
                emp s = (from t in con.emps
                             where t.EmployeeID==employee.EmployeeID
                             select t).FirstOrDefault();
                s.FirstName = employee.FirstName;
                s.LastName = employee.LastName;
                s.Status = employee.Status;
                s.MiddleName = employee.MiddleName;
                s.Emp_Adress = employee.Emp_Adress;

                con.SubmitChanges();
            }
        }

        public static void DeleteEmployee(emp employee)
        {
            using (EmployeeDataDataContext con = new EmployeeDataDataContext())
            {
                emp s = (from t in con.emps
                             where t.EmployeeID == employee.EmployeeID
                             select t).FirstOrDefault();
                con.emps.DeleteOnSubmit(s);
                con.SubmitChanges();
            }

        }
        #endregion
    }
}
