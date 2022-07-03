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
    public class PermissionsServices:IPermissionsServices
    {
        private readonly IPermissionsRepository<PermissionsModel> permissionsRepository;
        private readonly IPermissionsRepository<PermissionsTypeModel> permissionsTypeRepository;

        public PermissionsServices( IPermissionsRepository<PermissionsModel> permissionsRepository,
                                    IPermissionsRepository<PermissionsTypeModel>permissionsTypeRepository)
        {
            this.permissionsRepository = permissionsRepository;
            this.permissionsTypeRepository = permissionsTypeRepository;
        }


        public void DeletePermission(int id)
        {
            PermissionsModel permissionsModel = this.permissionsRepository.Get(id);
            permissionsRepository.Remove(permissionsModel);
            PermissionsTypeModel permissionsTypeModel = this.permissionsTypeRepository.Get(id);
            permissionsTypeRepository.Remove(permissionsTypeModel); 
        }

        public PermissionsModel GetPermission(int id)
        {
            return permissionsRepository.Get(id);
        }

        public IEnumerable<PermissionsModel> GetPermissions()
        {
            return permissionsRepository.GetAll();
        }

        public void InsertPermission(PermissionsModel permissionsModel)
        {
            permissionsRepository.Insert(permissionsModel);
        }

        public void UpdatePermission(PermissionsModel permissionsModel)
        {
            permissionsRepository.Update(permissionsModel);
        }
    }
}
