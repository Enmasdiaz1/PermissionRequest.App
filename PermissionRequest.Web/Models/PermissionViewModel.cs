using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace PermissionRequest.Web.Models
{
    public class PermissionViewModel
    {
        [HiddenInput]
        public int? Id { get; set; }
        [Display(Name="Nombre del Empleado")]
        public string NombreEmpleado { get; set; }
        [Display(Name="Apellido del Empleado")]
        public string ApellidoEmpleado { get; set; }
        [Display(Name="Tipo de Permiso del Empleado")]
        public int? TipoPermiso { get; set; }
        [Display(Name="Fecha de la Solictud")]
        public DateTime FechaPermiso { get; set; }

    }
}
