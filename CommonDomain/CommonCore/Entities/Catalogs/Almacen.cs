﻿using CommonCore.Entities.Types;
using CommonCore.Interfaces.Entities.Catalogs;
using CommonCore.Entities;

namespace CommonCore.Entities.Catalogs
{
    public class Almacen : BaseEntityLongId, IAlmacen
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public long IdTipoAlmacen { get; set; }
        public TipoAlmacen TipoAlmacen { get; set; }
        public long IdSucursal { get; set; }
        public Sucursal Sucursal { get; set; }
    }
}
