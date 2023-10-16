﻿using CommonCore.Interfaces.Entities.Sales;

namespace VentasApplication.Dtos
{
    public class ImpuestosConceptoVentaDto : IImpuestosConceptoVenta
    {
        public long? Id { get; set; }
        public long IdConceptoVenta { get; set; }
        public string TipoTasaCuota { get; set; }
        public string ImpuestoCode { get; set; }
        public string TipoFactor { get; set; }
        public string TipoImpuesto { get; set; }
        public double? Base { get; set; }
        public double? TasaCuota { get; set; }
        public double? Importe { get; set; }
    }
}
