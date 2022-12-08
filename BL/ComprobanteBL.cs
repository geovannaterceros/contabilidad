using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.DAL;

namespace prueba.BL
{
    public interface IComprobanteBL
    {
        public List<Comprobante> BuscarComprobante();

        public void CreateComprobante(Comprobante comprobante);

        public int BuscarID();
    }
  
    public class ComprobanteBL : IComprobanteBL
    {
        public readonly IComprobanteDAL _comprobanteDAL;

        public ComprobanteBL(IComprobanteDAL comprobanteDAL)
        {
            _comprobanteDAL = comprobanteDAL;
        }
        public List<Comprobante> BuscarComprobante()
        {
            return _comprobanteDAL.BuscarComprobante();
        }

        public void CreateComprobante(Comprobante comprobante)
        {
            _comprobanteDAL.CreateComprobante(comprobante);
        }

        public int BuscarID()
        {
            return _comprobanteDAL.BuscarID();
        }
    }

}

