using PermissionRequest.App.PermissionRequest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionRequest.Application.Services.Interfaces
{
    public interface IPermissionsServices
    {
        IEnumerable<PermissionsModel> GetPermissions();
        PermissionsModel GetPermission(int id);
        void InsertPermission(PermissionsModel permissionsModel);
        void UpdatePermission(PermissionsModel permissionsModel);
        void DeletePermission(int id);  
        
    }
}
