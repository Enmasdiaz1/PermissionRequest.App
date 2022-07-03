using PermissionRequest.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PermissionRequest.App.PermissionRequest.Domain.Models
{
    [Table("TipoPermiso")]
    public class PermissionsTypeModel : BaseClass
    {
        [Column("Id")]
        [Key]
        public int? Id { get; set; }
        [Column("Descripcion")]
        public string Descripcion { get; set; }

        public virtual  PermissionsModel Permissions { get; set; }
    }
}
