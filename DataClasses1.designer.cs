﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINKDEMO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LINKDEMO.Properties.Settings.Default.MyDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee
	{
		
		private int _employee_id;
		
		private string _employee_name;
		
		private string _designation;
		
		private System.Nullable<int> _manager_id;
		
		public Employee()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee_id", DbType="Int NOT NULL")]
		public int employee_id
		{
			get
			{
				return this._employee_id;
			}
			set
			{
				if ((this._employee_id != value))
				{
					this._employee_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee_name", DbType="VarChar(20)")]
		public string employee_name
		{
			get
			{
				return this._employee_name;
			}
			set
			{
				if ((this._employee_name != value))
				{
					this._employee_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_designation", DbType="VarChar(20)")]
		public string designation
		{
			get
			{
				return this._designation;
			}
			set
			{
				if ((this._designation != value))
				{
					this._designation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manager_id", DbType="Int")]
		public System.Nullable<int> manager_id
		{
			get
			{
				return this._manager_id;
			}
			set
			{
				if ((this._manager_id != value))
				{
					this._manager_id = value;
				}
			}
		}
	}
}
#pragma warning restore 1591