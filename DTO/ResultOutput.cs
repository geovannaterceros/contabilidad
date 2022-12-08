using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace prueba.Model
{
   public class ResultOutput
   {
        public bool EsError { get; set; }

        public string Mensaje { get; set; }

        public string CodigoError { get; set; }

        public List<Comprobante> Comprobantes { get; set; }

    }
}
