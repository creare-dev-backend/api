﻿using CommonCore.Interfaces.Entities;

namespace CommonCore.Entities
{
    public class PermisosRol : BaseEntityLongId, IPermisosRol
    {
        public long PermisoId { get; set; }
        public Permiso Permiso { get; set; }
        public long RolId { get; set; }
        public Rol Rol { get; set; }
    }
}
