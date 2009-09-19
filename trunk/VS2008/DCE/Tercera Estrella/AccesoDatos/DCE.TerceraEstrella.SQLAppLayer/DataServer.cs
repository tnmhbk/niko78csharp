using System;
using System.Data;

namespace DCE.TerceraEstrella.SQLAppLayer
{
    using System.Data.Sql;
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

        private SqlTransaction _transaction;

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

        private void CerrarConexion()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection = null;
            }
        }

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
    }
}
