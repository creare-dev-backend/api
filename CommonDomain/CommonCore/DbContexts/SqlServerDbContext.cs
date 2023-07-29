﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CommonCore.DbContexts
{
    public class SqlServerDbContext : DbContext
    {
        private List<Assembly> assemblies;
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
        {            
            assemblies = new List<Assembly>
            {
                this.GetType().Assembly
            };
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            foreach(var assembly in assemblies)
                modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        }

        public void AddConfigurations(Assembly assembly) => assemblies.Add(assembly);
        public void DisableLazyLoading()
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
