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

        [HttpGet]
        public IActionResult AddPermission()
        {
            PermissionViewModel model = new PermissionViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddPermission(PermissionViewModel model)
        {
            PermissionsModel permissionsModel = new PermissionsModel
            {
                NombreEmpleado = model.NombreEmpleado,
                ApellidoEmpleado = model.ApellidoEmpleado,
                TipoPermiso = model.TipoPermiso,
                FechaPermiso = model.FechaPermiso,

                PermissionsType = new PermissionsTypeModel
                {
                    Id=model.TipoPermiso
                }
                
                

            };
            this.permissionsServices.InsertPermission(permissionsModel);
            if (permissionsModel.Id>0)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
