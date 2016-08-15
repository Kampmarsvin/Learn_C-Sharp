using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _12_Employee
{
    [TestClass]
    public class EmployeeRepostioryTests
    {
        private EmployeeRepository CreateRepository()
        {
            return new EmployeeRepository();
        }

        [TestMethod]
        public void Clear() 
        {
            EmployeeRepository repository = CreateRepository();
            repository.Clear();
            Assert.AreEqual(0, repository.CountEmployees());
            Employee alex = repository.CreateEmployee("Alex Chaffee", "Teacher");
            Assert.AreEqual(1, repository.CountEmployees());
            repository.Clear();
            Assert.AreEqual(0, repository.CountEmployees());
            
        }

        [TestMethod]
        public void Create() 
        {
            EmployeeRepository repository = CreateRepository();
            repository.Clear();
            Employee alex = repository.CreateEmployee("Alex Chaffee", "Teacher");
            Assert.AreEqual("Alex Chaffee", alex.Name);
            Assert.AreEqual("Teacher", alex.Type);
            Assert.IsTrue(alex.Id != 0);
            Employee nick = repository.CreateEmployee("Nick Chaffee", "Translator");
            Assert.IsTrue(nick.Id != 0);
            Assert.IsTrue(nick.Id != alex.Id);
        }

        [TestMethod]
        public void SaveAndCount() 
        {
            EmployeeRepository repository = CreateRepository();
            repository.Clear();
            Employee alex = repository.CreateEmployee("Alex Chaffee", "Teacher");
            repository.SaveEmployee(alex);
            Assert.AreEqual(1, repository.CountEmployees());
            
        }

        [TestMethod]
        public void SaveAndLoad() 
        {
            EmployeeRepository repository = CreateRepository();
            repository.Clear();
            Employee alex = repository.CreateEmployee("Alex Chaffee", "Teacher");
            repository.SaveEmployee(alex);
            Employee loadedAlex = repository.LoadEmployee(alex.Id);
            Assert.AreEqual(alex, loadedAlex);
            
        }

        [TestMethod]
        public void SaveAndLoadTwoEmployees() 
        {
            EmployeeRepository repository = CreateRepository();
            repository.Clear();
            Employee alex = repository.CreateEmployee("Alex Chaffee", "Teacher");
            repository.SaveEmployee(alex);
            Employee nick = repository.CreateEmployee("Nick Chaffee", "Translator");
            repository.SaveEmployee(nick);
            Assert.AreEqual(2, repository.CountEmployees());
            Employee loadedNick = repository.LoadEmployee(nick.Id);
            Assert.AreEqual(nick, loadedNick);
            
        }

        [TestMethod]
        public void FindAllEmployees() 
        {
            EmployeeRepository repository = CreateRepository();
            repository.Clear();
            Employee alex = repository.CreateEmployee("Alex Chaffee", "Teacher");
            repository.SaveEmployee(alex);
            Employee nick = repository.CreateEmployee("Nick Chaffee", "Translator");
            repository.SaveEmployee(nick);

            List<Employee> all = repository.FindAllEmployees();
            CollectionAssert.Contains(all, alex);
            CollectionAssert.Contains(all, nick);
            
        }

        [TestMethod]
        public void ChangeData() 
        {
            EmployeeRepository repository = CreateRepository();
            repository.Clear();
            Employee nick = repository.CreateEmployee("Nick Chaffee", "Translator");
            repository.SaveEmployee(nick);
            nick.Type = "Sous chef";
            repository.SaveEmployee(nick);
            nick = repository.LoadEmployee(nick.Id);
            Assert.AreEqual("Sous chef", nick.Type);
            
        }
    }
}
