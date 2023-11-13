using AssignmentClassLibrary.DataAccessLayers.DataAccessLayersInterface;
using AssignmentClassLibrary.Entities.EntitiesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassLibrary.DataAccessLayers
{
    public class AdminDataAccessLayer : IAdminAccessLayer
    {
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
