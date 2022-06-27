using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Negocio
{
    public static class TransitoBs
    {
        public static List<Transito> GetTransitoEvento(int iEvento)
        {
            return TransitoDt.GetTransitoEvento(iEvento);
        }

        public static List<TransitoAgrupado> GetTransitosAgrupados(DateTime dtFDesde, DateTime dtFHasta, string sPlaca, int iVia)
        {
            return TransitoDt.GetTransitosAgrupados(dtFDesde, dtFHasta, sPlaca, iVia);
        }

        public static bool GuardarArchivos(string sCarpetaOrigen, string sCarpetaDestino, TransitoAgrupado oTransitoAgrupado)
        {
            bool bFlag = false;
            try
            {   
                List<Transito> transitoL = new List<Transito>();
                transitoL = GetTransitoEvento(oTransitoAgrupado.Evento);
                string[] pathArchivoL = GetArchivos($@"{sCarpetaOrigen}\{oTransitoAgrupado.Fecha:yyyyMMdd}");

                foreach (Transito oTransito in transitoL)
                {
                    foreach (string sPathArchivo in pathArchivoL)
                    {
                        if (Path.GetFileName(sPathArchivo) == oTransito.ArchivoNombre)
                        {
                            CopiarArchivo(sCarpetaOrigen, sCarpetaDestino, oTransito);
                            bFlag = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bFlag;
        }

        public static void CopiarArchivo(string sCarpetaOrigen, string sCarpetaDestino, Transito oTransito)
        {
            try
            {
                string sPathDestino = $@"{sCarpetaDestino}\{oTransito.Fecha:yyyyMMdd}";

                if (!Directory.Exists(sPathDestino))
                    Directory.CreateDirectory(sPathDestino);

                string sPathOrigen = $@"{sCarpetaOrigen}\{oTransito.Fecha:yyyyMMdd}\{oTransito.ArchivoNombre}";

                File.Copy(sPathOrigen, $@"{sPathDestino}\{oTransito.Placa}_{oTransito.ArchivoNombre}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static string[] GetArchivos(string sPathOrigen)
        {
            string[] pathArchivoL;

            try
            {
                pathArchivoL = Directory.GetFiles(sPathOrigen);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pathArchivoL;
        }
    }
}
