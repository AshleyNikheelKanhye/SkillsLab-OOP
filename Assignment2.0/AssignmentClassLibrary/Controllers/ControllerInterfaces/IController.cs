using AssignmentClassLibrary.Entities;
using AssignmentClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassLibrary.Controllers
{
    public interface IController<T> where T : IEntity
    {



        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);



    }
}
