using AssignmentClassLibrary.Controllers;
using AssignmentClassLibrary.DataAccessLayers;
using AssignmentClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassLibrary.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly IEmployeeDataAccessLayer _employeeDataAccessLayer;




        public EmployeeRepository()
        {
            _employeeDataAccessLayer = new EmployeeDataAccessLayer();
        }




        public void Add(IEmployee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEmployee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEmployee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IEmployee entity)
        {
            throw new NotImplementedException();
        }


    }
}
