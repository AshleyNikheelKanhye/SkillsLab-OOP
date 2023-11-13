using AssignmentClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassLibrary.DataAccessLayers
{
    public class EmployeeDataAccessLayer : IEmployeeDataAccessLayer
    {

        //access the database
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
