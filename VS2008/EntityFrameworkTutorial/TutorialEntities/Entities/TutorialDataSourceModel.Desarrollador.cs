//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool.
// Code is generated on: 23/12/2009 3:08:03
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

namespace TutorialEntities
{

    /// <summary>
    /// There are no comments for TutorialEntities.Desarrollador in the schema.
    /// </summary>
    /// <KeyProperties>
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="TutorialEntities", Name="Desarrollador")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Desarrollador : Persona
    {
        #region Factory Method

        /// <summary>
        /// Create a new Desarrollador object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="nivel">Initial value of Nivel.</param>
        public static Desarrollador CreateDesarrollador(long id, string nivel)
        {
            Desarrollador desarrollador = new Desarrollador();
            desarrollador.Id = id;
            desarrollador.Nivel = nivel;
            return desarrollador;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for Nivel in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Nivel
        {
            get
            {
                string value = this._Nivel;
                OnGetNivel(ref value);
                return value;
            }
            set
            {
                this.OnNivelChanging(ref value);
                this.ReportPropertyChanging("Nivel");
                this._Nivel = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Nivel");
                this.OnNivelChanged();
            }
        }
        private string _Nivel;
        partial void OnGetNivel(ref string value);
        partial void OnNivelChanging(ref string value);
        partial void OnNivelChanged();

        #endregion
    }

}
