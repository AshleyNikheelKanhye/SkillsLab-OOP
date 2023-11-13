using AssignmentClassLibrary.DataAccessLayers;
using AssignmentClassLibrary.DataAccessLayers.DataAccessLayersInterface;
using AssignmentClassLibrary.Entities.EntitiesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassLibrary.Repositories.RepositoriesInterface
{
    public class AdminRepository : IAdminRepository
    {

        private readonly IAdminAccessLayer _adminDAL;

        public AdminRepository()
        {
            _adminDAL = new AdminDataAccessLayer();
        }



        public void Add(IAdmin entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IAdmin> GetAll()
        {
            throw new NotImplementedException();
        }

        public IAdmin GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IAdmin entity)
        {
            throw new NotImplementedException();
        }
    }
}
