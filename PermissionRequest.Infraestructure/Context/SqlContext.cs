using Microsoft.EntityFrameworkCore;
using PermissionRequest.App.PermissionRequest.Domain.Models;
using PermissionRequest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionRequest.Infraestructure.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext( DbContextOptions<SqlContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PermissionsMap(modelBuilder.Entity<PermissionsModel>());
            new PermissionsTypeMap(modelBuilder.Entity<PermissionsTypeModel>());
        }
    }
}
