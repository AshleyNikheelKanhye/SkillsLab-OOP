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
    public class RegistrationRepository : IRegistrationRepository
    {

        private readonly IRegistrationDataAccessLayer _registrationDAL;


        public RegistrationRepository()
        {
            _registrationDAL = new RegistrationDataAccessLayer();
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
