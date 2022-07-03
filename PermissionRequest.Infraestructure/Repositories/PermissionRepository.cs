using Microsoft.EntityFrameworkCore;
using PermissionRequest.Domain.Models;
using PermissionRequest.Infraestructure.Context;
using PermissionRequest.Infraestructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionRequest.Infraestructure.Repositories
{
    public class PermissionRepository<T> : IPermissionsRepository<T> where T : BaseClass
    {
        private readonly SqlContext _sqlContext;
        private DbSet<T> Permissions;
        public PermissionRepository(SqlContext sqlContext)
        {
            this._sqlContext = sqlContext;
            Permissions = _sqlContext.Set<T>();
        }



        public void Delete(T permission)
        {
            if (permission == null)
            {
                throw new ArgumentNullException("Permissions");

            }
            Permissions.Remove(permission);
            _sqlContext.SaveChanges();
        }

        public T Get(int id)
        {
            return Permissions.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return Permissions.AsEnumerable();
        }

        public void Insert(T permission)
        {
            if (permission ==null)
            {
                throw new ArgumentNullException("Permissions");

            }
            Permissions.Add(permission);
            _sqlContext.SaveChanges();
        } 

        public void Remove(T permission)
        {
            if (permission == null)
            {
                throw new ArgumentNullException("Permissions");

            }
            _sqlContext.Remove(permission);
        }

        public void SaveChanges()
        {
            _sqlContext.SaveChanges();
        }

        public void Update(T permission)
        {
            if (permission == null)
            {
                throw new ArgumentNullException("Permissions");

            }
            _sqlContext.SaveChanges();
        }
    }
}
