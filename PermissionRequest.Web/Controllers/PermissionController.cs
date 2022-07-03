using Microsoft.AspNetCore.Mvc;
using PermissionRequest.App.PermissionRequest.Domain.Models;
using PermissionRequest.Application.Services.Interfaces;
using PermissionRequest.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace PermissionRequest.Web.Controllers
{
    public class PermissionController : Controller
    {
        private readonly IPermissionsServices permissionsServices;
        private readonly IPermissionsTypeServices permissionsTypeServices;

        public PermissionController(IPermissionsServices permissionsServices,
            IPermissionsTypeServices permissionsTypeServices) 
        {
            this.permissionsServices = permissionsServices;
            this.permissionsTypeServices = permissionsTypeServices;
        }
        public IActionResult Index()
        {
            List<PermissionViewModel> model = new List<PermissionViewModel>();

            this.permissionsServices.GetPermissions().ToList().ForEach(x =>
            {
                PermissionsTypeModel permissionType = this.permissionsTypeServices.GetPermissions(x.Id);

                PermissionViewModel permissionView = new PermissionViewModel
                {
                    Id = x.Id,
                    NombreEmpleado = x.NombreEmpleado,
                    ApellidoEmpleado = x.ApellidoEmpleado,
                    TipoPermiso = x.TipoPermiso,
                    FechaPermiso = x.FechaPermiso
                };
                model.Add(permissionView);

            });
            
            return View(model);
        }
    }
}
