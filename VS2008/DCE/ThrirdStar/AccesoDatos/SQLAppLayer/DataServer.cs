// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataServer.cs" company="Niko78">
//   2009
// </copyright>
// <summary>
//   Capa de acceso a datos de MS SQLServer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DCE.TerceraEstrella.SQLAppLayer
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// Capa de acceso a datos de MS SQLServer.
    /// </summary>
    public class DataServer
    {
        /// <summary>
        /// Conexión a la Base de Datos.
        /// </summary>
        private SqlConnection _connection;

        /// <summary>
        /// Transacción actual con la base de datos.
        /// </summary>
        private SqlTransaction _transaction;

        /// <summary>
        /// Inicia la transacción y la coneión con la base de datos.
        /// </summary>
        public void IniciarTransaccion()
        {
            AbrirConexion();
            try
            {
                _transaction = _connection.BeginTransaction(IsolationLevel.Serializable);
            }
            catch (Exception)
            {
                CerrarConexion();
                throw;
            }
        }

        /// <summary>
        /// Termina la transaccion y cierra la conexión con la base de datos.
        /// </summary>
        /// <exception cref="ApplicationException">
        /// </exception>
        public void TerminarTrasaccion()
        {
            if (_transaction == null)
            {
                throw new ApplicationException("La transacción no ha sido iniciada.");
            }

            try
            {
                _transaction.Commit();
                _transaction = null;
            }
            finally 
            {
                CerrarConexion();
            }
        }

        /// <summary>
        /// Prueba la conexión con la DB.
        /// </summary>
        public void TestConeccionDB()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConfigHelper.StringConexion))
            {
                sqlConnection.Open();
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Ejecuta un simple query con la Base de Datos.
        /// </summary>
        /// <param name="query">El query ha ejecutar.</param>
        /// <returns>El datatable con los resulatdos.</returns>
        public DataTable EjecutarSimpleSelectQueryAsDataTable(string query)
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(query, _connection, _transaction);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(result);
            return result;
        }

        public SqlDataReader GetDataReader(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, _connection, _transaction);
            return sqlCommand.ExecuteReader();
        }

        /// <summary>
        /// Abre una conexión con la Base de Datos.
        /// </summary>
        private void AbrirConexion()
        {
            try
            {
                _connection = new SqlConnection(ConfigHelper.StringConexion);
                _connection.Open();
            }
            catch (Exception)
            {
                _connection = null;
                throw;
            }
        }

        /// <summary>
        /// Cierra la conexión con la base de datos.
        /// </summary>
        private void CerrarConexion()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
}
