using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace prueba.DAL
{
    public interface IComprobanteDAL 
    {
        public List<Comprobante> BuscarComprobante();

        public void CreateComprobante(Comprobante comprobante);

        public int BuscarID();
    }

    public class ComprobanteDAL: IComprobanteDAL
    {
        public List<Comprobante> BuscarComprobante()
        {
            List<Comprobante> comprobantes = new List<Comprobante>();
            //try
            //{
            //    using (var connection = DBConnection.ConexionSql())
            //    {
            //        connection.Open();
            //        string query = "select id_comprobante, tipo_comprobante, fecha_comprobante, proceso_origen, glosa, estado, id_registro_externo from comprobante";

            //        var cmd = new MySqlCommand(query, connection);
                    
            //        DataTable dt = new DataTable();
            //        data.Fill(dt);

            //        foreach (DataRow item in dt.Rows)
            //        {
            //            Comprobante comprobante = new Comprobante
            //            {
            //                    IdComprobante = Convert.ToInt32(item["id_comprobante"]),
            //                    TipoComprobante = item["tipo_comprobante"].ToString().Trim(),
            //                    FechaComprobante = item["fecha_comprobante"].ToString().Trim(),
            //                    ProcesoOrigen = item["proceso_origen"].ToString().Trim(),
            //                    Glosa = item["glosa"].ToString().Trim(),
            //                    Estado= item["estado"].ToString().Trim(),
            //                    IdRegistroExterno = Convert.ToInt32(item["id_registro_externo"]),

            //            };
            //                comprobantes.Add(comprobante);
            //        }
            //        connection.Close();
            //    }
            //}
            //catch (Exception excepcion)
            //{
            //    throw excepcion;
            //}
            return comprobantes;
        }

        public void CreateComprobante(Comprobante comprobante)
        {
            try
            {
                using (var connection = DBConnection.ConexionSql())
                {
                    connection.Open();
                    var query = "INSERT INTO comprobante VALUES (@id_comprobante, @tipo_comprobante, @fecha_comprobante, @proceso_origen, @glosa, @estado, @id_registro_externo)";

                    var cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id_comprobante", BuscarID()+1);
                    cmd.Parameters.AddWithValue("@tipo_comprobante", comprobante.TipoComprobante);
                    cmd.Parameters.AddWithValue("@fecha_comprobante", Convert.ToDateTime(comprobante.FechaComprobante));
                    cmd.Parameters.AddWithValue("@proceso_origen", comprobante.ProcesoOrigen);
                    cmd.Parameters.AddWithValue("@glosa", comprobante.Glosa);
                    cmd.Parameters.AddWithValue("@estado", comprobante.Estado);
                    cmd.Parameters.AddWithValue("@id_registro_externo", comprobante.IdRegistroExterno);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }

        public int BuscarID()
        {
            int id = 0;

            try
            {
                using (var connection = DBConnection.ConexionSql())
                {
                    connection.Open();
                    string query = "SELECT MAX(id_comprobante) from comprobante ";

                    var cmd = new MySqlCommand(query, connection);

                    id  = Convert.ToInt32(cmd.ExecuteScalar());

                    connection.Close();
                }
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
            return id;
        }
    }
}
