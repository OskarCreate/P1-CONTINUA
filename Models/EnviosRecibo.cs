using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1_CONTINUA.Models
{
    public class EnviosRecibo
    {

        public int? envio {get; set;}
        public int? recibe {get; set;}
        public string? origen {get; set;}
        public string? destino {get; set;}
        public string? mensaje {get; set;}
    }
}