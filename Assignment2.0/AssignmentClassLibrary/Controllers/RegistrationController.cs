using AssignmentClassLibrary.Controllers.ControllerInterfaces;
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
    public class RegistrationController : IRegistrationController
    {
        private readonly IRegistrationRepository _registrationRepository;


        public RegistrationController()
        {
            _registrationRepository = new RegistrationRepository();
        }



        public void Add(IRegistration entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRegistration> GetAll()
        {
            throw new NotImplementedException();
        }

        public IRegistration GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IRegistration entity)
        {
            throw new NotImplementedException();
        }
    }
}
