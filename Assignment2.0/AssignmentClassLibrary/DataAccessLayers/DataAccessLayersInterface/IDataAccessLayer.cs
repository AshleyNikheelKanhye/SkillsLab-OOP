using AssignmentClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassLibrary.DataAccessLayers
{
    public interface IDataAccessLayer<T> where T : IEntity
    {

        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);





    }
}
