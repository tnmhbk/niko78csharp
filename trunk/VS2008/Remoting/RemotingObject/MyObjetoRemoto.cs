// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyObjetoRemoto.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Defines the MyObjetoRemoto type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RemotingObject
{
    using System;

    /// <summary>
    /// Objeto remoto.
    /// </summary>
    public class MyObjetoRemoto : MarshalByRefObject
    {
        /// <summary>
        /// Nombre del objeto.
        /// </summary>
        private string _nombre = "Sin Nombre";

        /// <summary>
        /// Devuelve el nombre del objeto.
        /// </summary>
        /// <returns>
        /// El nombre del objeto.
        /// </returns>
        public string GetNombre()
        {
            return _nombre;
        }

        /// <summary>
        /// Set el nombre del objeto.
        /// </summary>
        /// <param name="nombre">El nombre del objeto.
        /// </param>
        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }
    }
}
