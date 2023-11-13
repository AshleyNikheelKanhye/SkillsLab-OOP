using AssignmentClassLibrary.DataAccessLayers;
using AssignmentClassLibrary.DataAccessLayers.DataAccessLayersInterface;
using AssignmentClassLibrary.Entities;
using AssignmentClassLibrary.Repositories.RepositoriesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassLibrary.Repositories
{
    public class ManagerRepository : IManagerRepository
    {


        private readonly IManagerDataAccessLayer _managerDAL;

        public ManagerRepository()
        {
            _managerDAL = new ManagerDataAccessLayer();
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
