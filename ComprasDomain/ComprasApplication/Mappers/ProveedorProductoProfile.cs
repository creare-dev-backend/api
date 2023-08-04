﻿using AutoMapper;
using CommonCore.Entities.Purchases;
using ComprasApplication.Dtos;

namespace ComprasApplication.Mappers
{
    public class ProveedorProductoProfile : Profile
    {
        public ProveedorProductoProfile()
        {
            CreateMap<ProveedorProducto, ProveedorProductoDto>();
            CreateMap<ProveedorProductoDto, ProveedorProducto>()
                .ForMember(dest => dest.FechaCreacion, opt => opt.Ignore())
                .ForMember(dest => dest.FechaUltimaActualizacion, opt => opt.Ignore())
                .ForMember(dest => dest.UsuarioActualizaId, opt => opt.Ignore())
                .ForMember(dest => dest.UsuarioCreaId, opt => opt.Ignore())
                .ForMember(dest => dest.Activo, opt => opt.Ignore());
        }
    }
}
