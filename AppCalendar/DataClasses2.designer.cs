﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppCalendar
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataBase")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTabela_RL(Tabela_RL instance);
    partial void UpdateTabela_RL(Tabela_RL instance);
    partial void DeleteTabela_RL(Tabela_RL instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseConnectionString2"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tabela_RL> Tabela_RL
		{
			get
			{
				return this.GetTable<Tabela_RL>();
			}
		}
		
		public System.Data.Linq.Table<Tabela_Wydarzenia> Tabela_Wydarzenia
		{
			get
			{
				return this.GetTable<Tabela_Wydarzenia>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tabela_RL")]
	public partial class Tabela_RL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Email;
		
		private string _Haslo;
		
		private System.Data.Linq.Binary _Sol;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnHasloChanging(string value);
    partial void OnHasloChanged();
    partial void OnSolChanging(System.Data.Linq.Binary value);
    partial void OnSolChanged();
    #endregion
		
		public Tabela_RL()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Haslo", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string Haslo
		{
			get
			{
				return this._Haslo;
			}
			set
			{
				if ((this._Haslo != value))
				{
					this.OnHasloChanging(value);
					this.SendPropertyChanging();
					this._Haslo = value;
					this.SendPropertyChanged("Haslo");
					this.OnHasloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sol", DbType="VarBinary(64)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Sol
		{
			get
			{
				return this._Sol;
			}
			set
			{
				if ((this._Sol != value))
				{
					this.OnSolChanging(value);
					this.SendPropertyChanging();
					this._Sol = value;
					this.SendPropertyChanged("Sol");
					this.OnSolChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tabela_Wydarzenia")]
	public partial class Tabela_Wydarzenia
	{
		
		private int _Id;
		
		private string _Nazwa;
		
		private System.DateTime _Data;
		
		private System.Nullable<System.TimeSpan> _Godzina;
		
		private string _Opis;
		
		private string _Miejsce;
		
		private string _Kategoria;
		
		private string _Goscie;
		
		private string _Notatka;
		
		private string _Kolor;
		
		private System.Nullable<int> _Priorytet;
		
		public Tabela_Wydarzenia()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nazwa", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Nazwa
		{
			get
			{
				return this._Nazwa;
			}
			set
			{
				if ((this._Nazwa != value))
				{
					this._Nazwa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="Date NOT NULL")]
		public System.DateTime Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this._Data = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Godzina", DbType="Time")]
		public System.Nullable<System.TimeSpan> Godzina
		{
			get
			{
				return this._Godzina;
			}
			set
			{
				if ((this._Godzina != value))
				{
					this._Godzina = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Opis", DbType="NVarChar(200)")]
		public string Opis
		{
			get
			{
				return this._Opis;
			}
			set
			{
				if ((this._Opis != value))
				{
					this._Opis = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Miejsce", DbType="NVarChar(200)")]
		public string Miejsce
		{
			get
			{
				return this._Miejsce;
			}
			set
			{
				if ((this._Miejsce != value))
				{
					this._Miejsce = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kategoria", DbType="NVarChar(50)")]
		public string Kategoria
		{
			get
			{
				return this._Kategoria;
			}
			set
			{
				if ((this._Kategoria != value))
				{
					this._Kategoria = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Goscie", DbType="NVarChar(200)")]
		public string Goscie
		{
			get
			{
				return this._Goscie;
			}
			set
			{
				if ((this._Goscie != value))
				{
					this._Goscie = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notatka", DbType="NVarChar(200)")]
		public string Notatka
		{
			get
			{
				return this._Notatka;
			}
			set
			{
				if ((this._Notatka != value))
				{
					this._Notatka = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kolor", DbType="NVarChar(20)")]
		public string Kolor
		{
			get
			{
				return this._Kolor;
			}
			set
			{
				if ((this._Kolor != value))
				{
					this._Kolor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Priorytet", DbType="Int")]
		public System.Nullable<int> Priorytet
		{
			get
			{
				return this._Priorytet;
			}
			set
			{
				if ((this._Priorytet != value))
				{
					this._Priorytet = value;
				}
			}
		}
	}
}
#pragma warning restore 1591