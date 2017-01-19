using System;
using Employee;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeDetailsTest
{
    [TestClass]
    public class UnitTest1
    {
        public static bool Employeetesting(string firstName, string lastName, string middleName, string email, string address) {
            VerifyDetails obj = new VerifyDetails();
            return obj.verify(firstName,lastName,middleName,email,address);
        }
        [TestMethod]
        public void ValidInputs_OnCreatingEmployee_ReturnsTrue()
        {
            Assert.AreEqual(true, Employeetesting("Chandan", "Veeresh", "Angadi", "mrchandana@gmail.in", "SJCE MYSORE"));
        }
        [TestMethod, ExpectedException(typeof(InvalidInputException))]
        public void InValidInputs_OnCreatingEmployee_ThrowsInvalidInputException() {
            Employeetesting("Chandan", "Veeresh", "Angadi", "mrchandanav", "SJCE MYSORE");
        }

        [TestMethod, ExpectedException(typeof(InvalidInputException))]
        public void EmptyFirstName_OnCreating_ThrowsInvalidInputException() {
            Employeetesting("", "Veeresh", "Angadi", "mrchandanav@gmail.com", "SJCE MYSORE");
        }
        [TestMethod, ExpectedException(typeof(InvalidInputException))]
        public void EmptyLastName_OnCreating_ThrowsInvalidInputException()
        {
            Employeetesting("Chandan", "", "Angadi", "mrchandanav@gmail.com", "SJCE MYSORE");
        }

        [TestMethod, ExpectedException(typeof(InvalidInputException))]
        public void EmptyMiddleName_OnCreating_ThrowsInvalidInputException()
        {
            Employeetesting("Chandan", "Veeresh", "", "mrchandanav@gmail.com", "SJCE MYSORE");
        }

        [TestMethod, ExpectedException(typeof(InvalidInputException))]
        public void EmptyEmailId_OnCreating_ThrowsInvalidInputException()
        {
            Employeetesting("Chandan", "Veeresh", "Angadi", "", "SJCE MYSORE");
        }

        [TestMethod, ExpectedException(typeof(InvalidInputException))]
        public void EmptyAddress_OnCreating_ThrowsInvalidInputException()
        {
            Employeetesting("Chandan", "Veeresh", "Angadi", "mrchandanav@gmail.com", "");
        }



    }
}
