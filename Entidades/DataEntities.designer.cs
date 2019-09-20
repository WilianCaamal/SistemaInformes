﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SistemaInformes")]
	public partial class DataEntitiesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertAsesores(Asesores instance);
    partial void UpdateAsesores(Asesores instance);
    partial void DeleteAsesores(Asesores instance);
    partial void InsertPredios(Predios instance);
    partial void UpdatePredios(Predios instance);
    partial void DeletePredios(Predios instance);
    partial void InsertPuestos(Puestos instance);
    partial void UpdatePuestos(Puestos instance);
    partial void DeletePuestos(Puestos instance);
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    partial void InsertBeneficiarios(Beneficiarios instance);
    partial void UpdateBeneficiarios(Beneficiarios instance);
    partial void DeleteBeneficiarios(Beneficiarios instance);
    #endregion
		
		public DataEntitiesDataContext() : 
				base(global::Entidades.Properties.Settings.Default.SistemaInformesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataEntitiesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEntitiesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEntitiesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEntitiesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Asesores> Asesores
		{
			get
			{
				return this.GetTable<Asesores>();
			}
		}
		
		public System.Data.Linq.Table<Informes> Informes
		{
			get
			{
				return this.GetTable<Informes>();
			}
		}
		
		public System.Data.Linq.Table<Predios> Predios
		{
			get
			{
				return this.GetTable<Predios>();
			}
		}
		
		public System.Data.Linq.Table<Puestos> Puestos
		{
			get
			{
				return this.GetTable<Puestos>();
			}
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
		
		public System.Data.Linq.Table<Beneficiarios> Beneficiarios
		{
			get
			{
				return this.GetTable<Beneficiarios>();
			}
		}
		
		public System.Data.Linq.Table<All_Beneficiarios> All_Beneficiarios
		{
			get
			{
				return this.GetTable<All_Beneficiarios>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Asesores")]
	public partial class Asesores : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdAsesor;
		
		private string _Nombre;
		
		private string _ApellidoPaterno;
		
		private string _ApellidoMaterno;
		
		private string _Correo;
		
		private string _Telefono;
		
		private bool _Estatus;
		
		private string _Usuario;
		
		private string _Contrasena;
		
		private EntitySet<Predios> _Predios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdAsesorChanging(int value);
    partial void OnIdAsesorChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoPaternoChanging(string value);
    partial void OnApellidoPaternoChanged();
    partial void OnApellidoMaternoChanging(string value);
    partial void OnApellidoMaternoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnEstatusChanging(bool value);
    partial void OnEstatusChanged();
    partial void OnUsuarioChanging(string value);
    partial void OnUsuarioChanged();
    partial void OnContrasenaChanging(string value);
    partial void OnContrasenaChanged();
    #endregion
		
		public Asesores()
		{
			this._Predios = new EntitySet<Predios>(new Action<Predios>(this.attach_Predios), new Action<Predios>(this.detach_Predios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAsesor", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdAsesor
		{
			get
			{
				return this._IdAsesor;
			}
			set
			{
				if ((this._IdAsesor != value))
				{
					this.OnIdAsesorChanging(value);
					this.SendPropertyChanging();
					this._IdAsesor = value;
					this.SendPropertyChanged("IdAsesor");
					this.OnIdAsesorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoPaterno", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ApellidoPaterno
		{
			get
			{
				return this._ApellidoPaterno;
			}
			set
			{
				if ((this._ApellidoPaterno != value))
				{
					this.OnApellidoPaternoChanging(value);
					this.SendPropertyChanging();
					this._ApellidoPaterno = value;
					this.SendPropertyChanged("ApellidoPaterno");
					this.OnApellidoPaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoMaterno", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ApellidoMaterno
		{
			get
			{
				return this._ApellidoMaterno;
			}
			set
			{
				if ((this._ApellidoMaterno != value))
				{
					this.OnApellidoMaternoChanging(value);
					this.SendPropertyChanging();
					this._ApellidoMaterno = value;
					this.SendPropertyChanged("ApellidoMaterno");
					this.OnApellidoMaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(100)")]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="NChar(10)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Bit NOT NULL")]
		public bool Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this.OnEstatusChanging(value);
					this.SendPropertyChanging();
					this._Estatus = value;
					this.SendPropertyChanged("Estatus");
					this.OnEstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				if ((this._Usuario != value))
				{
					this.OnUsuarioChanging(value);
					this.SendPropertyChanging();
					this._Usuario = value;
					this.SendPropertyChanged("Usuario");
					this.OnUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrasena", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Contrasena
		{
			get
			{
				return this._Contrasena;
			}
			set
			{
				if ((this._Contrasena != value))
				{
					this.OnContrasenaChanging(value);
					this.SendPropertyChanging();
					this._Contrasena = value;
					this.SendPropertyChanged("Contrasena");
					this.OnContrasenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Asesores_Predios", Storage="_Predios", ThisKey="IdAsesor", OtherKey="IdAsesor")]
		public EntitySet<Predios> Predios
		{
			get
			{
				return this._Predios;
			}
			set
			{
				this._Predios.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Predios(Predios entity)
		{
			this.SendPropertyChanging();
			entity.Asesores = this;
		}
		
		private void detach_Predios(Predios entity)
		{
			this.SendPropertyChanging();
			entity.Asesores = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Informes")]
	public partial class Informes
	{
		
		private int _IdInforme;
		
		private System.DateTime _FechaCreacion;
		
		public Informes()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdInforme", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int IdInforme
		{
			get
			{
				return this._IdInforme;
			}
			set
			{
				if ((this._IdInforme != value))
				{
					this._IdInforme = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaCreacion", DbType="Date NOT NULL")]
		public System.DateTime FechaCreacion
		{
			get
			{
				return this._FechaCreacion;
			}
			set
			{
				if ((this._FechaCreacion != value))
				{
					this._FechaCreacion = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Predios")]
	public partial class Predios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdPredio;
		
		private string _Nombre;
		
		private double _Superficie;
		
		private bool _Estatus;
		
		private string _Municipio;
		
		private int _IdAsesor;
		
		private System.DateTime _FechaRegistro;
		
		private System.Nullable<System.DateTime> _FechaEliminado;
		
		private System.Nullable<System.DateTime> _FechaEdicion;
		
		private EntityRef<Asesores> _Asesores;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPredioChanging(int value);
    partial void OnIdPredioChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnSuperficieChanging(double value);
    partial void OnSuperficieChanged();
    partial void OnEstatusChanging(bool value);
    partial void OnEstatusChanged();
    partial void OnMunicipioChanging(string value);
    partial void OnMunicipioChanged();
    partial void OnIdAsesorChanging(int value);
    partial void OnIdAsesorChanged();
    partial void OnFechaRegistroChanging(System.DateTime value);
    partial void OnFechaRegistroChanged();
    partial void OnFechaEliminadoChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaEliminadoChanged();
    partial void OnFechaEdicionChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaEdicionChanged();
    #endregion
		
		public Predios()
		{
			this._Asesores = default(EntityRef<Asesores>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPredio", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdPredio
		{
			get
			{
				return this._IdPredio;
			}
			set
			{
				if ((this._IdPredio != value))
				{
					this.OnIdPredioChanging(value);
					this.SendPropertyChanging();
					this._IdPredio = value;
					this.SendPropertyChanged("IdPredio");
					this.OnIdPredioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Superficie", DbType="Float NOT NULL")]
		public double Superficie
		{
			get
			{
				return this._Superficie;
			}
			set
			{
				if ((this._Superficie != value))
				{
					this.OnSuperficieChanging(value);
					this.SendPropertyChanging();
					this._Superficie = value;
					this.SendPropertyChanged("Superficie");
					this.OnSuperficieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Bit NOT NULL")]
		public bool Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this.OnEstatusChanging(value);
					this.SendPropertyChanging();
					this._Estatus = value;
					this.SendPropertyChanged("Estatus");
					this.OnEstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Municipio", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Municipio
		{
			get
			{
				return this._Municipio;
			}
			set
			{
				if ((this._Municipio != value))
				{
					this.OnMunicipioChanging(value);
					this.SendPropertyChanging();
					this._Municipio = value;
					this.SendPropertyChanged("Municipio");
					this.OnMunicipioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAsesor", DbType="Int NOT NULL")]
		public int IdAsesor
		{
			get
			{
				return this._IdAsesor;
			}
			set
			{
				if ((this._IdAsesor != value))
				{
					if (this._Asesores.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdAsesorChanging(value);
					this.SendPropertyChanging();
					this._IdAsesor = value;
					this.SendPropertyChanged("IdAsesor");
					this.OnIdAsesorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaRegistro", DbType="Date NOT NULL")]
		public System.DateTime FechaRegistro
		{
			get
			{
				return this._FechaRegistro;
			}
			set
			{
				if ((this._FechaRegistro != value))
				{
					this.OnFechaRegistroChanging(value);
					this.SendPropertyChanging();
					this._FechaRegistro = value;
					this.SendPropertyChanged("FechaRegistro");
					this.OnFechaRegistroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaEliminado", DbType="Date")]
		public System.Nullable<System.DateTime> FechaEliminado
		{
			get
			{
				return this._FechaEliminado;
			}
			set
			{
				if ((this._FechaEliminado != value))
				{
					this.OnFechaEliminadoChanging(value);
					this.SendPropertyChanging();
					this._FechaEliminado = value;
					this.SendPropertyChanged("FechaEliminado");
					this.OnFechaEliminadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaEdicion", DbType="Date")]
		public System.Nullable<System.DateTime> FechaEdicion
		{
			get
			{
				return this._FechaEdicion;
			}
			set
			{
				if ((this._FechaEdicion != value))
				{
					this.OnFechaEdicionChanging(value);
					this.SendPropertyChanging();
					this._FechaEdicion = value;
					this.SendPropertyChanged("FechaEdicion");
					this.OnFechaEdicionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Asesores_Predios", Storage="_Asesores", ThisKey="IdAsesor", OtherKey="IdAsesor", IsForeignKey=true)]
		public Asesores Asesores
		{
			get
			{
				return this._Asesores.Entity;
			}
			set
			{
				Asesores previousValue = this._Asesores.Entity;
				if (((previousValue != value) 
							|| (this._Asesores.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Asesores.Entity = null;
						previousValue.Predios.Remove(this);
					}
					this._Asesores.Entity = value;
					if ((value != null))
					{
						value.Predios.Add(this);
						this._IdAsesor = value.IdAsesor;
					}
					else
					{
						this._IdAsesor = default(int);
					}
					this.SendPropertyChanged("Asesores");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Puestos")]
	public partial class Puestos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdPuesto;
		
		private string _Nombre;
		
		private string _Descripcion;
		
		private System.DateTime _FechaRegistro;
		
		private System.Nullable<System.DateTime> _FechaEdicion;
		
		private System.Nullable<System.DateTime> _FechaElimado;
		
		private bool _Estatus;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPuestoChanging(int value);
    partial void OnIdPuestoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    partial void OnFechaRegistroChanging(System.DateTime value);
    partial void OnFechaRegistroChanged();
    partial void OnFechaEdicionChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaEdicionChanged();
    partial void OnFechaElimadoChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaElimadoChanged();
    partial void OnEstatusChanging(bool value);
    partial void OnEstatusChanged();
    #endregion
		
		public Puestos()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPuesto", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdPuesto
		{
			get
			{
				return this._IdPuesto;
			}
			set
			{
				if ((this._IdPuesto != value))
				{
					this.OnIdPuestoChanging(value);
					this.SendPropertyChanging();
					this._IdPuesto = value;
					this.SendPropertyChanged("IdPuesto");
					this.OnIdPuestoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(250)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaRegistro", DbType="Date NOT NULL")]
		public System.DateTime FechaRegistro
		{
			get
			{
				return this._FechaRegistro;
			}
			set
			{
				if ((this._FechaRegistro != value))
				{
					this.OnFechaRegistroChanging(value);
					this.SendPropertyChanging();
					this._FechaRegistro = value;
					this.SendPropertyChanged("FechaRegistro");
					this.OnFechaRegistroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaEdicion", DbType="Date")]
		public System.Nullable<System.DateTime> FechaEdicion
		{
			get
			{
				return this._FechaEdicion;
			}
			set
			{
				if ((this._FechaEdicion != value))
				{
					this.OnFechaEdicionChanging(value);
					this.SendPropertyChanging();
					this._FechaEdicion = value;
					this.SendPropertyChanged("FechaEdicion");
					this.OnFechaEdicionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaElimado", DbType="Date")]
		public System.Nullable<System.DateTime> FechaElimado
		{
			get
			{
				return this._FechaElimado;
			}
			set
			{
				if ((this._FechaElimado != value))
				{
					this.OnFechaElimadoChanging(value);
					this.SendPropertyChanging();
					this._FechaElimado = value;
					this.SendPropertyChanged("FechaElimado");
					this.OnFechaElimadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Bit NOT NULL")]
		public bool Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this.OnEstatusChanging(value);
					this.SendPropertyChanging();
					this._Estatus = value;
					this.SendPropertyChanged("Estatus");
					this.OnEstatusChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdUsuario;
		
		private string _Nombre;
		
		private string _Contrasena;
		
		private System.Nullable<System.DateTime> _FechaRegistro;
		
		private System.Nullable<System.DateTime> _FechaEdicion;
		
		private System.Nullable<System.DateTime> _FechaEliminado;
		
		private System.Nullable<bool> _Estatus;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdUsuarioChanging(int value);
    partial void OnIdUsuarioChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnContrasenaChanging(string value);
    partial void OnContrasenaChanged();
    partial void OnFechaRegistroChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaRegistroChanged();
    partial void OnFechaEdicionChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaEdicionChanged();
    partial void OnFechaEliminadoChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaEliminadoChanged();
    partial void OnEstatusChanging(System.Nullable<bool> value);
    partial void OnEstatusChanged();
    #endregion
		
		public Usuarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdUsuario
		{
			get
			{
				return this._IdUsuario;
			}
			set
			{
				if ((this._IdUsuario != value))
				{
					this.OnIdUsuarioChanging(value);
					this.SendPropertyChanging();
					this._IdUsuario = value;
					this.SendPropertyChanged("IdUsuario");
					this.OnIdUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrasena", DbType="VarChar(500)")]
		public string Contrasena
		{
			get
			{
				return this._Contrasena;
			}
			set
			{
				if ((this._Contrasena != value))
				{
					this.OnContrasenaChanging(value);
					this.SendPropertyChanging();
					this._Contrasena = value;
					this.SendPropertyChanged("Contrasena");
					this.OnContrasenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaRegistro", DbType="Date")]
		public System.Nullable<System.DateTime> FechaRegistro
		{
			get
			{
				return this._FechaRegistro;
			}
			set
			{
				if ((this._FechaRegistro != value))
				{
					this.OnFechaRegistroChanging(value);
					this.SendPropertyChanging();
					this._FechaRegistro = value;
					this.SendPropertyChanged("FechaRegistro");
					this.OnFechaRegistroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaEdicion", DbType="Date")]
		public System.Nullable<System.DateTime> FechaEdicion
		{
			get
			{
				return this._FechaEdicion;
			}
			set
			{
				if ((this._FechaEdicion != value))
				{
					this.OnFechaEdicionChanging(value);
					this.SendPropertyChanging();
					this._FechaEdicion = value;
					this.SendPropertyChanged("FechaEdicion");
					this.OnFechaEdicionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaEliminado", DbType="Date")]
		public System.Nullable<System.DateTime> FechaEliminado
		{
			get
			{
				return this._FechaEliminado;
			}
			set
			{
				if ((this._FechaEliminado != value))
				{
					this.OnFechaEliminadoChanging(value);
					this.SendPropertyChanging();
					this._FechaEliminado = value;
					this.SendPropertyChanged("FechaEliminado");
					this.OnFechaEliminadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Bit")]
		public System.Nullable<bool> Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this.OnEstatusChanging(value);
					this.SendPropertyChanging();
					this._Estatus = value;
					this.SendPropertyChanged("Estatus");
					this.OnEstatusChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Beneficiarios")]
	public partial class Beneficiarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdBeneficiario;
		
		private string _Nombre;
		
		private string _ApellidoPaterno;
		
		private string _ApellidoMaterno;
		
		private string _Direccion;
		
		private int _IdPuesto;
		
		private System.DateTime _FechaRegistro;
		
		private System.Nullable<System.DateTime> _FechaEdicion;
		
		private System.Nullable<System.DateTime> _FechaEliminado;
		
		private bool _Estatus;
		
		private int _IdPredio;
		
		private string _Telefono;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdBeneficiarioChanging(int value);
    partial void OnIdBeneficiarioChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoPaternoChanging(string value);
    partial void OnApellidoPaternoChanged();
    partial void OnApellidoMaternoChanging(string value);
    partial void OnApellidoMaternoChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnIdPuestoChanging(int value);
    partial void OnIdPuestoChanged();
    partial void OnFechaRegistroChanging(System.DateTime value);
    partial void OnFechaRegistroChanged();
    partial void OnFechaEdicionChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaEdicionChanged();
    partial void OnFechaEliminadoChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaEliminadoChanged();
    partial void OnEstatusChanging(bool value);
    partial void OnEstatusChanged();
    partial void OnIdPredioChanging(int value);
    partial void OnIdPredioChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    #endregion
		
		public Beneficiarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdBeneficiario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdBeneficiario
		{
			get
			{
				return this._IdBeneficiario;
			}
			set
			{
				if ((this._IdBeneficiario != value))
				{
					this.OnIdBeneficiarioChanging(value);
					this.SendPropertyChanging();
					this._IdBeneficiario = value;
					this.SendPropertyChanged("IdBeneficiario");
					this.OnIdBeneficiarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoPaterno", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ApellidoPaterno
		{
			get
			{
				return this._ApellidoPaterno;
			}
			set
			{
				if ((this._ApellidoPaterno != value))
				{
					this.OnApellidoPaternoChanging(value);
					this.SendPropertyChanging();
					this._ApellidoPaterno = value;
					this.SendPropertyChanged("ApellidoPaterno");
					this.OnApellidoPaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoMaterno", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ApellidoMaterno
		{
			get
			{
				return this._ApellidoMaterno;
			}
			set
			{
				if ((this._ApellidoMaterno != value))
				{
					this.OnApellidoMaternoChanging(value);
					this.SendPropertyChanging();
					this._ApellidoMaterno = value;
					this.SendPropertyChanged("ApellidoMaterno");
					this.OnApellidoMaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(150)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPuesto", DbType="Int NOT NULL")]
		public int IdPuesto
		{
			get
			{
				return this._IdPuesto;
			}
			set
			{
				if ((this._IdPuesto != value))
				{
					this.OnIdPuestoChanging(value);
					this.SendPropertyChanging();
					this._IdPuesto = value;
					this.SendPropertyChanged("IdPuesto");
					this.OnIdPuestoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaRegistro", DbType="Date NOT NULL")]
		public System.DateTime FechaRegistro
		{
			get
			{
				return this._FechaRegistro;
			}
			set
			{
				if ((this._FechaRegistro != value))
				{
					this.OnFechaRegistroChanging(value);
					this.SendPropertyChanging();
					this._FechaRegistro = value;
					this.SendPropertyChanged("FechaRegistro");
					this.OnFechaRegistroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaEdicion", DbType="Date")]
		public System.Nullable<System.DateTime> FechaEdicion
		{
			get
			{
				return this._FechaEdicion;
			}
			set
			{
				if ((this._FechaEdicion != value))
				{
					this.OnFechaEdicionChanging(value);
					this.SendPropertyChanging();
					this._FechaEdicion = value;
					this.SendPropertyChanged("FechaEdicion");
					this.OnFechaEdicionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaEliminado", DbType="Date")]
		public System.Nullable<System.DateTime> FechaEliminado
		{
			get
			{
				return this._FechaEliminado;
			}
			set
			{
				if ((this._FechaEliminado != value))
				{
					this.OnFechaEliminadoChanging(value);
					this.SendPropertyChanging();
					this._FechaEliminado = value;
					this.SendPropertyChanged("FechaEliminado");
					this.OnFechaEliminadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Bit NOT NULL")]
		public bool Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this.OnEstatusChanging(value);
					this.SendPropertyChanging();
					this._Estatus = value;
					this.SendPropertyChanged("Estatus");
					this.OnEstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPredio", DbType="Int NOT NULL")]
		public int IdPredio
		{
			get
			{
				return this._IdPredio;
			}
			set
			{
				if ((this._IdPredio != value))
				{
					this.OnIdPredioChanging(value);
					this.SendPropertyChanging();
					this._IdPredio = value;
					this.SendPropertyChanged("IdPredio");
					this.OnIdPredioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="NChar(10)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.All_Beneficiarios")]
	public partial class All_Beneficiarios
	{
		
		private int _IdBeneficiario;
		
		private string _Nombre;
		
		private string _ApellidoPaterno;
		
		private string _ApellidoMaterno;
		
		private string _Predio;
		
		public All_Beneficiarios()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdBeneficiario", DbType="Int NOT NULL")]
		public int IdBeneficiario
		{
			get
			{
				return this._IdBeneficiario;
			}
			set
			{
				if ((this._IdBeneficiario != value))
				{
					this._IdBeneficiario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoPaterno", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ApellidoPaterno
		{
			get
			{
				return this._ApellidoPaterno;
			}
			set
			{
				if ((this._ApellidoPaterno != value))
				{
					this._ApellidoPaterno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoMaterno", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ApellidoMaterno
		{
			get
			{
				return this._ApellidoMaterno;
			}
			set
			{
				if ((this._ApellidoMaterno != value))
				{
					this._ApellidoMaterno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Predio", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Predio
		{
			get
			{
				return this._Predio;
			}
			set
			{
				if ((this._Predio != value))
				{
					this._Predio = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
