using Model;
using System;
using System.Collections.Generic;

namespace Service
{
    public class EmployeeService
    {
        private Repository.EmployeeRepository employeeRepository = new Repository.EmployeeRepository();
        public List<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

        public Employee GetByJmbg(String jmbg)
        {
            return employeeRepository.GetByJmbg(jmbg);
        }

        public void Save(Employee employee)
        {
            employeeRepository.Save(employee);
        }

        public void Delete(String jmbg)
        {
            employeeRepository.Delete(jmbg);
        }

        public void Update(Employee employee)
        {
            employeeRepository.Update(employee);
        }


    }
}