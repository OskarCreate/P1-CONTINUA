using System;
using System.ComponentModel.DataAnnotations;

namespace P1_CONTINUA.Models
{
    public class Boleta
    {

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? DocumentoIdentidad { get; set; }

        public string? TipoCambio { get; set; }

        public DateTime? FechaTransaccion { get; set; } = DateTime.Now;
    }
}
