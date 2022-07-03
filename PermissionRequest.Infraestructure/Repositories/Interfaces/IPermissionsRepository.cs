using PermissionRequest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionRequest.Infraestructure.Repositories.Interfaces
{
    public interface IPermissionsRepository<T> where T : BaseClass
    {
        IEnumerable<T> GetAll(); 
        T Get(int id);
        void Delete(T permission);
        void Update(T permission);
        void Insert(T permission);
        void Remove(T permission);
        void SaveChanges();
    }
}
