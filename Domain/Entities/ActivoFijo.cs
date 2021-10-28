using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ActivoFijo
    {
        public int Id { get; set; }
        public string CodigoActivo { get; set; }
        public string NombreActivo { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public TipoActivo TipoActivo { get; set; }
        public TipoMetodo TipoMetodo { get; set; }

        public string ToString()
        {
            return string.Format("{0,5:d} {1,-20} {2,-15} {3,5:f} {4,-30:d} {5,4:d} \n", $"{Id}", $"{CodigoActivo}", $"{NombreActivo}", $"{ValorActivo}", $"{FechaAdquisicion}", $"{TipoActivo}");
        }
    }
}

        
    

