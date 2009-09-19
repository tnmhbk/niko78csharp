// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigHelper.cs" company="Niko78">
//   2009
// </copyright>
// <summary>
//   Helper de configracion.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DCE.TerceraEstrella.SQLAppLayer
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Helper de configracion.
    /// </summary>
    internal static class ConfigHelper
    {
        /// <summary>
        /// Sstring de conexión con la DB.
        /// </summary>
        private static string _stringConexion;

        /// <summary>
        /// Gets El sttring de coneccion a la base de Daatos.
        /// </summary>
        /// <exception cref="ApplicationException">En caso de no ser enconotrado.
        /// </exception>
        public static string StringConexion
        {
            get
            {
                if (_stringConexion == null)
                {
                    ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["AccesoDatos"];
                    if (connectionStringSettings == null)
                    {
                        throw new ApplicationException("String de Conexión no encontrado.\nRevise la configuración de la aplicación.");
                    }

                    _stringConexion  = connectionStringSettings.ConnectionString;
                }

                return _stringConexion;
            }
        }
    }
}
