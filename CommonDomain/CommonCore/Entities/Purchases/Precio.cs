﻿using CommonCore.Entities.Catalogs;
using CommonCore.Entities.Types;
using CommonCore.Interfaces.Entities.Purchases;
using CommonCore.Entities;

namespace CommonCore.Entities.Purchases
{
    public class Precio : BaseEntityLongId, IPrecio
    {
        public long IdProducto { get; set; }
        public Producto Producto { get; set; }
        public long IdTipoPrecio { get; set; }
        public TipoPrecio TipoPrecio { get; set; }
        public decimal Monto { get; set; }
    }
}
