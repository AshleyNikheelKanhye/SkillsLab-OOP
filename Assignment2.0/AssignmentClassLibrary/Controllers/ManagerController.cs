using AssignmentClassLibrary.Entities;
using AssignmentClassLibrary.Repositories;
using AssignmentClassLibrary.Repositories.RepositoriesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassLibrary.Controllers
{
    public class ManagerController : IManagerController
    {

        private readonly IManagerRepository _managerRepository;

        public ManagerController()
        {
            _managerRepository = new ManagerRepository();
        }




        public void Add(IManager entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IManager> GetAll()
        {
            throw new NotImplementedException();
        }

        public IManager GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IManager entity)
        {
            throw new NotImplementedException();
        }
    }
}
