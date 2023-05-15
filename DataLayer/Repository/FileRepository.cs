using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    //internal class FileRepository<T> : IRepository<T>
    //{
    //    private const string path = @"";

    //    public FileRepository()
    //    {
    //        CreateFilesIfNonExistent();
    //    }

    //    private void CreateFilesIfNonExistent()
    //    {
    //        if (!File.Exists(path))
    //        {
    //            File.Create(path).Close();
    //        }
    //    }

    //    public IList<T> LoadAll()
    //    {
    //        IList<T> users = new List<T>();

    //        string[] lines = File.ReadAllLines(path);

    //        lines.ToList().ForEach(line => users.Add(T.ParseFromFileLine(line)));

    //        return users;
    //    }

    //    public T LoadSingle(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SaveAll(T entity)
    //    {
    //        IList<T> users = LoadAll();

    //        users.Add(entity);

    //        File.WriteAllLines(path, users.Select(u => u.FormatFromFileLine()));
    //    }

    //    public T SaveSingle(int id) => LoadAll().FirstOrDefault(u => u.Id == id);
    //}
}
