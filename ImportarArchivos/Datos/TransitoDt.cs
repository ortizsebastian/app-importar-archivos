using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public static class TransitoDt
    {
        public static List<TransitoAgrupado> GetTransitosAgrupados(DateTime dtFDesde, DateTime dtFHasta, string sPlaca, int iVia)
        {
            List<TransitoAgrupado> transitoAgrupadoL = new List<TransitoAgrupado>();
            Conexion oConn = new Conexion();

            try
            {
                oConn.setConsulta($"MoverArchivos_getTransitosAgrupados @fDesde, @fHasta, @placa, @via");

                oConn.setParametro("@fDesde", dtFDesde);
                oConn.setParametro("@fHasta", dtFHasta);
                oConn.setParametro("@placa", sPlaca);
                oConn.setParametro("@via", iVia);

                oConn.Lectura();

                while (oConn.oDr.Read())
                {
                    TransitoAgrupado oTransitoAgrupado = new TransitoAgrupado
                    {
                        Estacion = Convert.ToInt32(oConn.oDr["Estacion"]),
                        Via = Convert.ToInt32(oConn.oDr["Via"]),
                        Fecha = (DateTime)oConn.oDr["Fecha"],
                        Hora = (TimeSpan)oConn.oDr["Hora"],
                        Placa = (string)oConn.oDr["Placa"],
                        Categoria = (byte)oConn.oDr["Categoria"],
                        FormaPago = (string)oConn.oDr["FormaPago"],
                        Evento = Convert.ToInt32(oConn.oDr["Evento"])
                    };

                    transitoAgrupadoL.Add(oTransitoAgrupado);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConn.Cerrar();
            }

            return transitoAgrupadoL;
        }

        public static List<Transito> GetTransitoEvento(int iEvento)
        {
            List<Transito> transitoL = new List<Transito>();
            Conexion oConn = new Conexion();

            try
            {
                oConn.setConsulta($"MoverArchivos_getTransito @evento");
                oConn.setParametro("@evento", iEvento);

                oConn.Lectura();

                while (oConn.oDr.Read())
                {
                    Transito oTransito = new Transito
                    {
                        Estacion = Convert.ToInt32(oConn.oDr["Estacion"]),
                        Via = Convert.ToInt32(oConn.oDr["Via"]),
                        Fecha = (DateTime)oConn.oDr["Fecha"],
                        Hora = (TimeSpan)oConn.oDr["Hora"],
                        Placa = (string)oConn.oDr["Placa"],
                        Categoria = (byte)oConn.oDr["Categoria"],
                        FormaPago = (string)oConn.oDr["FormaPago"],
                        ArchivoNombre = (string)oConn.oDr["ArchivoNombre"],
                        Evento = Convert.ToInt32(oConn.oDr["Evento"])
                    };

                    transitoL.Add(oTransito);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConn.Cerrar();
            }

            return transitoL;
        }
    }
}
