﻿using CommonCore.Entities.Purchases;
using CommonCore.Interfaces.Repositories.Purchases;
using CommonCore.DbContexts;
using CommonCore.Interfaces.Criterias;
using CommonCore.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ComprasInfraestructure.Repositories
{
    public class ProveedorProductoRepository : BaseRepository<ProveedorProducto, long>, IProveedorProductoRepository
    {
        public ProveedorProductoRepository(SqlServerDbContext context) : base(context)
        {
        }

        public override ProveedorProducto GetById(long id) => 
            Context.Set<ProveedorProducto>()
                .Include(pp => pp.Proveedor)
                .ThenInclude(p => p.TipoPersona)
                .Include(pp => pp.Proveedor)
                .ThenInclude(p => p.DatosFiscales)
                .Include(pp => pp.Costo)
                .Include(pp => pp.Producto)
                .ThenInclude(p => p.Categoria)
                .Include(pp => pp.Producto)
                .ThenInclude(p => p.Precios)
                .ThenInclude(pr => pr.TipoPrecio)
                .FirstOrDefault(pp => pp.Id == id);

        public override IList<ProveedorProducto> GetListByCriteria(IBaseCriteria<ProveedorProducto, long> criteria) => 
            Context.Set<ProveedorProducto>()
                .Include(pp => pp.Proveedor)
                .ThenInclude(p => p.TipoPersona)
                .Include(pp => pp.Proveedor)
                .ThenInclude(p => p.DatosFiscales)
                .Include(pp => pp.Costo)
                .Include(pp => pp.Producto)
                .ThenInclude(p => p.Categoria)
                .Include(pp => pp.Producto)
                .ThenInclude(p => p.Precios)
                .ThenInclude(pr => pr.TipoPrecio)
                .Where(criteria.GetExpression())
                .ToList();

        public override ProveedorProducto GetByCriteria(IBaseCriteria<ProveedorProducto, long> criteria) =>
            Context.Set<ProveedorProducto>()
               .Include(pp => pp.Proveedor)
                .ThenInclude(p => p.TipoPersona)
                .Include(pp => pp.Proveedor)
                .ThenInclude(p => p.DatosFiscales)
                .Include(pp => pp.Costo)
                .Include(pp => pp.Producto)
                .ThenInclude(p => p.Categoria)
                .Include(pp => pp.Producto)
                .ThenInclude(p => p.Precios)
                .ThenInclude(pr => pr.TipoPrecio)
                .FirstOrDefault(criteria.GetExpression());

        public override IList<ProveedorProducto> GetAll() =>
            Context.Set<ProveedorProducto>()
                .Include(pp => pp.Proveedor)
                .ThenInclude(p => p.TipoPersona)
                .Include(pp => pp.Proveedor)
                .ThenInclude(p => p.DatosFiscales)
                .Include(pp => pp.Costo)
                .Include(pp => pp.Producto)
                .ThenInclude(p => p.Categoria)
                .Include(pp => pp.Producto)
                .ThenInclude(p => p.Precios)
                .ThenInclude(pr => pr.TipoPrecio)
                .ToList();
    }
}
