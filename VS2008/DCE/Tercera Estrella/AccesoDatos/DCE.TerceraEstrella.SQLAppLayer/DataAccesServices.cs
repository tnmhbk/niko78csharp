// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataAccesServices.cs" company="Niko78">
//   2009
// </copyright>
// <summary>
//   Capa para el acceso a Datos.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DCE.TerceraEstrella.SQLAppLayer
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    
    using Data;

    /// <summary>
    /// Capa para el acceso a Datos.
    /// </summary>
    public class DataAccesServices
    {
        /// <summary>
        /// Data server para acceder a los datos.
        /// </summary>
        private static readonly DataServer _dataServer = new DataServer();

        /// <summary>
        /// Devuelve las personas.
        /// </summary>
        /// <returns>Las personas.</returns>
        public static DataTable GetPersonasAsDataTable()
        {
            _dataServer.IniciarTransaccion();

            try
            {
                const string Query = "SELECT Id, Nombre, Apellido FROM PERSONAS";
                return _dataServer.EjecutarSimpleSelectQueryAsDataTable(Query);
            }
            finally
            {
                _dataServer.TerminarTrasaccion();
            }
        }

        /// <summary>
        /// Devuelve las personas.
        /// </summary>
        /// <returns>Las personas.</returns>
        public static List<Persona> GetPersonasAsList()
        {
            _dataServer.IniciarTransaccion();

            try
            {
                List<Persona> result = new List<Persona>();
                const string Query = "SELECT Id, Nombre, Apellido FROM PERSONAS";
                SqlDataReader dataReader = _dataServer.GetDataReader(Query);

                while (dataReader.Read())
                {
                    Persona persona = new Persona
                                          {
                                              Id = (int) dataReader["Id"],
                                              Nombre = (string) dataReader["Nombre"],
                                              Apellido = (string) dataReader["Apellido"]
                                          };
                    result.Add(persona);
                }

                dataReader.Close();
                return result;
            }
            finally
            {
                _dataServer.TerminarTrasaccion();
            }
        }
    }
}
