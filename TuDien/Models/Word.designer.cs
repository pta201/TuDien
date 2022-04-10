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

namespace TuDien.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CSDL_TuDien")]
	public partial class WordDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTiengAnh_TiengViet(TiengAnh_TiengViet instance);
    partial void UpdateTiengAnh_TiengViet(TiengAnh_TiengViet instance);
    partial void DeleteTiengAnh_TiengViet(TiengAnh_TiengViet instance);
    #endregion
		
		public WordDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CSDL_TuDienConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WordDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WordDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WordDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WordDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TiengAnh_TiengViet> TiengAnh_TiengViets
		{
			get
			{
				return this.GetTable<TiengAnh_TiengViet>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TiengAnh_TiengViet")]
	public partial class TiengAnh_TiengViet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<System.DateTime> _NgayThem;
		
		private string _TiengAnh;
		
		private string _TiengViet;
		
		private string _ThongTinThem;
		
		private string _LoaiTu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnNgayThemChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayThemChanged();
    partial void OnTiengAnhChanging(string value);
    partial void OnTiengAnhChanged();
    partial void OnTiengVietChanging(string value);
    partial void OnTiengVietChanged();
    partial void OnThongTinThemChanging(string value);
    partial void OnThongTinThemChanged();
    partial void OnLoaiTuChanging(string value);
    partial void OnLoaiTuChanged();
    #endregion
		
		public TiengAnh_TiengViet()
		{
			OnCreated();
		}

        public TiengAnh_TiengViet(DateTime? ngayThem, string tiengAnh, string tiengViet, string thongTinThem, string loaiTu)
        {
            NgayThem = ngayThem;
            TiengAnh = tiengAnh;
            TiengViet = tiengViet;
            ThongTinThem = thongTinThem;
            LoaiTu = loaiTu;
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayThem", DbType="Date")]
		public System.Nullable<System.DateTime> NgayThem
		{
			get
			{
				return this._NgayThem;
			}
			set
			{
				if ((this._NgayThem != value))
				{
					this.OnNgayThemChanging(value);
					this.SendPropertyChanging();
					this._NgayThem = value;
					this.SendPropertyChanged("NgayThem");
					this.OnNgayThemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TiengAnh", DbType="NVarChar(MAX)")]
		public string TiengAnh
		{
			get
			{
				return this._TiengAnh;
			}
			set
			{
				if ((this._TiengAnh != value))
				{
					this.OnTiengAnhChanging(value);
					this.SendPropertyChanging();
					this._TiengAnh = value;
					this.SendPropertyChanged("TiengAnh");
					this.OnTiengAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TiengViet", DbType="NVarChar(MAX)")]
		public string TiengViet
		{
			get
			{
				return this._TiengViet;
			}
			set
			{
				if ((this._TiengViet != value))
				{
					this.OnTiengVietChanging(value);
					this.SendPropertyChanging();
					this._TiengViet = value;
					this.SendPropertyChanged("TiengViet");
					this.OnTiengVietChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThongTinThem", DbType="NVarChar(MAX)")]
		public string ThongTinThem
		{
			get
			{
				return this._ThongTinThem;
			}
			set
			{
				if ((this._ThongTinThem != value))
				{
					this.OnThongTinThemChanging(value);
					this.SendPropertyChanging();
					this._ThongTinThem = value;
					this.SendPropertyChanged("ThongTinThem");
					this.OnThongTinThemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiTu", DbType="NVarChar(50)")]
		public string LoaiTu
		{
			get
			{
				return this._LoaiTu;
			}
			set
			{
				if ((this._LoaiTu != value))
				{
					this.OnLoaiTuChanging(value);
					this.SendPropertyChanging();
					this._LoaiTu = value;
					this.SendPropertyChanged("LoaiTu");
					this.OnLoaiTuChanged();
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
}
#pragma warning restore 1591
