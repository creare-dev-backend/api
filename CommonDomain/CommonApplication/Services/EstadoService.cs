﻿using AutoMapper;
using CommonApplication.Dtos;
using CommonApplication.Interfaces;
using CommonCore.Entities;
using CommonCore.Interfaces.Criterias;
using CommonCore.Interfaces.Repositories;
using EssentialCore.Services;

namespace CommonApplication.Services
{
    public class EstadoService : BaseService<IEstadoRepository, Estado, long, EstadoDto>, IEstadoService
    {
        readonly IEstadoCriteria _estadoCriteria;
        public EstadoService(IEstadoRepository repository, IMapper mapper, IEstadoCriteria estadoCriteria) : base(repository, mapper)
        {
            _estadoCriteria = estadoCriteria;
        }

        public IList<EstadoDto> PorSeccion(string seccion)
        {
            var result = Repository.GetListByCriteria(_estadoCriteria.PorSeccion(seccion));
            return Mapper.Map<List<EstadoDto>>(result);
        }
    }
}
