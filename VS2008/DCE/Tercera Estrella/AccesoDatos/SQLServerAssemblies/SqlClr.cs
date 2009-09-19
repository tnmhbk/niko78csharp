// --------------------------------------------------------------------------------------------------------------------- 
// <copyright file="SqlClr.cs" company="Niko78">
//   2009
// </copyright>
// <summary>
//   Defines the SqlClr type.
// </summary>
// ---------------------------------------------------------------------------------------------------------------------
namespace SQLServerAssemblies
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using Microsoft.SqlServer.Server;

    /// <summary>
    /// Ejemplo de uso de SQL CLR.
    /// </summary>
    /// <remarks>
    /// Complilar el proyecto y realizar el deploy con VS, para ello, boton derecho sobre el proyecto -> Deploy.
    /// Verificar el string de conexón a DB en Properties del Proyecto.
    /// </remarks>
    public class SqlClr
    {
        #region "Atributor Privados"

        /// <summary>
        /// Id del operador.
        /// </summary>
        private static readonly SqlMetaData _operador_id = new SqlMetaData("Id", SqlDbType.Int);

        /// <summary>
        /// Nombre del operador.
        /// </summary>
        private static readonly SqlMetaData _operador_nombre = new SqlMetaData("Nombre", SqlDbType.VarChar, 25);

        /// <summary>
        /// Apellido del operador.
        /// </summary>
        private static readonly SqlMetaData _operador_apellido = new SqlMetaData("Apellido", SqlDbType.VarChar, 25);

        #endregion

        #region "Funciones"

        /// <summary>
        /// Devuelve el numero PI
        /// </summary>
        /// <returns>El numero PI</returns>
        [SqlFunction]
        public static double GetPi()
        {
            return Math.PI;
        }

        #endregion

        #region "Store Procedures"

        /// <summary>
        /// Ejemplo de Store Procedure que devuelve datos inventados.
        /// </summary>
        [SqlProcedure]
        public static void GetOperadores()
        {
            var record = new SqlDataRecord(new[] { _operador_id, _operador_nombre, _operador_apellido });

            // Comienzo de la respuesta
            SqlContext.Pipe.SendResultsStart(record);

            // Primer registro, setado en un solo paso
            record.SetValues(new object[] { 1, "Niko78", "SayNoMore" });
            SqlContext.Pipe.SendResultsRow(record);
            
            // Segundo registro, seteado por campo
            record.SetInt32(0, 2);
            record.SetString(1, "Cristian");
            record.SetString(2, "Gonzales");
            SqlContext.Pipe.SendResultsRow(record);

            // Fin de la respuesta
            SqlContext.Pipe.SendResultsEnd();
        }

        /// <summary>
        /// Ejemplo de Store Procedure que lee datos de las tablas.
        /// </summary>
        [SqlProcedure]
        public static void GetPersonasUpercase()
        {
            // Usamos la conexion actual
            using (var connection = new SqlConnection("context connection=true"))
            {
                connection.Open();

                var command = new SqlCommand("SELECT Id, Upper(Nombre) Nombre, Upper(Apellido) Apellido FROM Personas ", connection);

                // Ejecutamos el comando y lo mandamos hacia el cliente
                SqlContext.Pipe.ExecuteAndSend(command);
            }
        }

        #endregion
    }
}
