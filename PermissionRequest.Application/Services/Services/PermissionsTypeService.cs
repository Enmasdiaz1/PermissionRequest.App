using PermissionRequest.App.PermissionRequest.Domain.Models;
using PermissionRequest.Application.Services.Interfaces;
using PermissionRequest.Infraestructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionRequest.Application.Services.Services
{
    public class PermissionsTypeService : IPermissionsTypeServices
    {
        private readonly IPermissionsRepository<PermissionsTypeModel> permissionsTypeRepository;

        public PermissionsTypeService(IPermissionsRepository<PermissionsTypeModel> permissionsTypeRepository)
        {
            this.permissionsTypeRepository = permissionsTypeRepository;
        }

        public PermissionsTypeModel GetPermissions(int id)
        {
            return permissionsTypeRepository.Get(id);
        }
    }
}
