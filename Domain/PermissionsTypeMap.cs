using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PermissionRequest.App.PermissionRequest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionRequest.Domain
{
    public  class PermissionsTypeMap
    {
        public PermissionsTypeMap(EntityTypeBuilder<PermissionsTypeModel>entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Descripcion).IsRequired();
        }
    }
}
