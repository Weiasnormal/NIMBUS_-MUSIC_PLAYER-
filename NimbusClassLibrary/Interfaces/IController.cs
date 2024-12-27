
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Interfaces
{
    internal interface IController<t> where t : IModel
    {
        T GetSingle<T>(int id) where T : t;
        IEnumerable<T> GetCollection<T>() where T : t;
        bool Create<T>(T t) where T : t;
        bool Update<T>(T t) where T : t;
        bool Delete<T>(T t) where T : t;
    }
}
