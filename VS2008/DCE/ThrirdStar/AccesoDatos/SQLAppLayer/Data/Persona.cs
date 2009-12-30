// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Persona.cs" company="Niko78">
//   2009
// </copyright>
// <summary>
//   Mapea una persona en la tabla personas.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DCE.TerceraEstrella.SQLAppLayer.Data
{
    /// <summary>
    /// Mapea una persona en la tabla personas.
    /// </summary>
    public class Persona
    {
        /// <summary>
        /// Gets or sets Id de la persona.
        /// </summary>
        public int Id 
        { 
            get;
            set; 
        }

        /// <summary>
        /// Gets or sets Nombre de la persona.
        /// </summary>
        public string Nombre
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Apellido de la persona.
        /// </summary>
        public string Apellido
        {
            get;
            set;
        }


    }
}
