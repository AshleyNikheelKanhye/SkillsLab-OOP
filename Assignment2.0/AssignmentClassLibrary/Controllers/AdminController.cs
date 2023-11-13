using AssignmentClassLibrary.Controllers.ControllerInterfaces;
using AssignmentClassLibrary.Entities.EntitiesInterface;
using AssignmentClassLibrary.Repositories;
using AssignmentClassLibrary.Repositories.RepositoriesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassLibrary.Controllers
{
    public class AdminController : IAdminController
    {

        private readonly IAdminRepository _adminRepository;

        public AdminController()
        {
            _adminRepository = new AdminRepository();
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
