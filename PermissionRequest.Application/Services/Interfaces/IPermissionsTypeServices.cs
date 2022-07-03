using PermissionRequest.App.PermissionRequest.Domain.Models;
using PermissionRequest.Application.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionRequest.Application.Services.Interfaces
{
    public interface IPermissionsTypeServices
    {
        PermissionsTypeModel GetPermissions(int? id);
    }
}
