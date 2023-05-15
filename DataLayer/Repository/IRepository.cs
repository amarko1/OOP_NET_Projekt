using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IRepository<T>
    {
        void SaveAll(T entity);

        IList<T> LoadAll();

        T LoadSingle(int id);

        T SaveSingle(int id);
    }
}
