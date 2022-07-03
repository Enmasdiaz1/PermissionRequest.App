using PermissionRequest.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PermissionRequest.App.PermissionRequest.Domain.Models
{
    [Table("Permiso")]
    public class PermissionsModel:BaseClass
    {
        [Column("Id")]
        [Key]
        public int? Id { get; set; }
        [Column("NombreEmpleado")]
        [Required(ErrorMessage ="El Nombre del empleado es Obligatorio")]
        public string NombreEmpleado { get; set; }
        [Column("ApellidoEmpleado")]
        [Required(ErrorMessage ="El Apellido del empleado es Obligatorio")]
        public string ApellidoEmpleado { get; set; }
        [Column("TipoPermiso")]
        [Required(ErrorMessage ="El Tipo de Permiso es Obligatorio")]
        public int? TipoPermiso { get; set; }
        [Column("FechaPermiso")]
        [Required(ErrorMessage ="La Fecha es Obligatorio")]
        public DateTime FechaPermiso { get; set; }

        public virtual PermissionsTypeModel PermissionsType { get; set; }
    }
}
