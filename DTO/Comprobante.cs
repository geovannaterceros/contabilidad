using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba
{
    public class Comprobante
    {
        public int IdComprobante { get; set; }

        public string TipoComprobante { get; set; }

        public string FechaComprobante { get; set; }

        public string ProcesoOrigen { get; set; }

        public string Glosa { get; set; }

        public string Estado { get; set; }

        public int IdRegistroExterno { get; set; }
    }
}
