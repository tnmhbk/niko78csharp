// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConnectionManager.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Defines the ConnectionManager type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TutorialEntities
{
    /// <summary>
    /// Connection Manager.
    /// </summary>
    public class ConnectionManager
    {
        /// <summary>
        /// Gets ConnectionString.
        /// </summary>
        public static string ConnectionString
        {
            get { return @"metadata=res://*/TutorialEntities.Entities.TutorialDataSourceModel.csdl|res://*/TutorialEntities.Entities.TutorialDataSourceModel.ssdl|res://*/TutorialEntities.Entities.TutorialDataSourceModel.msl;provider=Devart.Data.Oracle;provider connection string=""User Id=ENTITY_TUTORIAL;Password=ENTITY_TUTORIAL;Server=ALMACENVM25;Home=oraclient10g_home1;Persist Security Info=True"""; }
        }
    }
}
