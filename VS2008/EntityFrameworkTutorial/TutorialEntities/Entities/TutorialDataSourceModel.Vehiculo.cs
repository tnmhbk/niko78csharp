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
    /// There are no comments for TutorialEntities.Vehiculo in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="TutorialEntities", Name="Vehiculo")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public abstract partial class Vehiculo : global::System.Data.Objects.DataClasses.EntityObject
    {

        #region Properties
    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public long Id
        {
            get
            {
                long value = this._Id;
                OnGetId(ref value);
                return value;
            }
            set
            {
                this.OnIdChanging(ref value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private long _Id;
        partial void OnGetId(ref long value);
        partial void OnIdChanging(ref long value);
        partial void OnIdChanged();
    
        /// <summary>
        /// There are no comments for Modelo in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo
        {
            get
            {
                string value = this._Modelo;
                OnGetModelo(ref value);
                return value;
            }
            set
            {
                this.OnModeloChanging(ref value);
                this.ReportPropertyChanging("Modelo");
                this._Modelo = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Modelo");
                this.OnModeloChanged();
            }
        }
        private string _Modelo;
        partial void OnGetModelo(ref string value);
        partial void OnModeloChanging(ref string value);
        partial void OnModeloChanged();
    
        /// <summary>
        /// There are no comments for Marca in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Marca
        {
            get
            {
                string value = this._Marca;
                OnGetMarca(ref value);
                return value;
            }
            set
            {
                this.OnMarcaChanging(ref value);
                this.ReportPropertyChanging("Marca");
                this._Marca = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Marca");
                this.OnMarcaChanged();
            }
        }
        private string _Marca;
        partial void OnGetMarca(ref string value);
        partial void OnMarcaChanging(ref string value);
        partial void OnMarcaChanged();
    
        /// <summary>
        /// There are no comments for Cilindrada in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Cilindrada
        {
            get
            {
                int value = this._Cilindrada;
                OnGetCilindrada(ref value);
                return value;
            }
            set
            {
                this.OnCilindradaChanging(ref value);
                this.ReportPropertyChanging("Cilindrada");
                this._Cilindrada = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Cilindrada");
                this.OnCilindradaChanged();
            }
        }
        private int _Cilindrada;
        partial void OnGetCilindrada(ref int value);
        partial void OnCilindradaChanging(ref int value);
        partial void OnCilindradaChanged();

        #endregion
    }

}
