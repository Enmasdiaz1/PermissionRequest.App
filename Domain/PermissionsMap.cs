using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PermissionRequest.App.PermissionRequest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PermissionsMap
    {
        public PermissionsMap(EntityTypeBuilder<PermissionsModel>entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);    
            entityTypeBuilder.Property(x=> x.NombreEmpleado).IsRequired();
            entityTypeBuilder.Property(x=> x.ApellidoEmpleado).IsRequired();
            entityTypeBuilder.Property(x=> x.TipoPermiso).IsRequired();
            entityTypeBuilder.Property(x=> x.FechaPermiso).IsRequired();
            entityTypeBuilder.HasOne(x => x.PermissionsType).WithOne(x => x.Permissions)
                .HasForeignKey<PermissionsTypeModel>(x => x.Id);
        }
    }
}
