﻿using System.Runtime.CompilerServices;
using AlarmHistory.Annotations;

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmHistory
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NTS")]
	public partial class ntsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 확장성 메서드 정의
    partial void OnCreated();
    partial void InsertAlarmTable(AlarmTable instance);
    partial void UpdateAlarmTable(AlarmTable instance);
    partial void DeleteAlarmTable(AlarmTable instance);
    partial void InsertTM1_SENSOR1(TM1_SENSOR1 instance);
    partial void UpdateTM1_SENSOR1(TM1_SENSOR1 instance);
    partial void DeleteTM1_SENSOR1(TM1_SENSOR1 instance);
    #endregion
		
		public ntsDataContext() : 
				base(global::AlarmHistory.Properties.Settings.Default.NTSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ntsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ntsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ntsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ntsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AlarmTable> AlarmTable
		{
			get
			{
				return this.GetTable<AlarmTable>();
			}
		}
		
		public System.Data.Linq.Table<TM1_SENSOR1> TM1_SENSOR1
		{
			get
			{
				return this.GetTable<TM1_SENSOR1>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AlarmTable")]
	public partial class AlarmTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.DateTime _ReceivedTime;
		
		private System.Nullable<int> _AlarmCode;
		
		private string _AlarmHexCode;
		
		private System.Nullable<int> _AlarmHappen;
		
		private string _Category;
		
		private System.Nullable<int> _Unit;
		
		private string _AlarmTextKorean;
		
		private string _AlarmTextChinese;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReceivedTimeChanging(System.DateTime value);
    partial void OnReceivedTimeChanged();
    partial void OnAlarmCodeChanging(System.Nullable<int> value);
    partial void OnAlarmCodeChanged();
    partial void OnAlarmHexCodeChanging(string value);
    partial void OnAlarmHexCodeChanged();
    partial void OnAlarmHappenChanging(System.Nullable<int> value);
    partial void OnAlarmHappenChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnUnitChanging(System.Nullable<int> value);
    partial void OnUnitChanged();
    partial void OnAlarmTextKoreanChanging(string value);
    partial void OnAlarmTextKoreanChanged();
    partial void OnAlarmTextChineseChanging(string value);
    partial void OnAlarmTextChineseChanged();
    #endregion
		
		public AlarmTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceivedTime", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime ReceivedTime
		{
			get
			{
				return this._ReceivedTime;
			}
			set
			{
				if ((this._ReceivedTime != value))
				{
					this.OnReceivedTimeChanging(value);
					this.SendPropertyChanging();
					this._ReceivedTime = value;
					this.SendPropertyChanged("ReceivedTime");
					this.OnReceivedTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlarmCode", DbType="Int")]
		public System.Nullable<int> AlarmCode
		{
			get
			{
				return this._AlarmCode;
			}
			set
			{
				if ((this._AlarmCode != value))
				{
					this.OnAlarmCodeChanging(value);
					this.SendPropertyChanging();
					this._AlarmCode = value;
					this.SendPropertyChanged("AlarmCode");
					this.OnAlarmCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlarmHexCode", DbType="VarChar(10)")]
		public string AlarmHexCode
		{
			get
			{
				return this._AlarmHexCode;
			}
			set
			{
				if ((this._AlarmHexCode != value))
				{
					this.OnAlarmHexCodeChanging(value);
					this.SendPropertyChanging();
					this._AlarmHexCode = value;
					this.SendPropertyChanged("AlarmHexCode");
					this.OnAlarmHexCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlarmHappen", DbType="Int")]
		public System.Nullable<int> AlarmHappen
		{
			get
			{
				return this._AlarmHappen;
			}
			set
			{
				if ((this._AlarmHappen != value))
				{
					this.OnAlarmHappenChanging(value);
					this.SendPropertyChanging();
					this._AlarmHappen = value;
					this.SendPropertyChanged("AlarmHappen");
					this.OnAlarmHappenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(10)")]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Unit", DbType="Int")]
		public System.Nullable<int> Unit
		{
			get
			{
				return this._Unit;
			}
			set
			{
				if ((this._Unit != value))
				{
					this.OnUnitChanging(value);
					this.SendPropertyChanging();
					this._Unit = value;
					this.SendPropertyChanged("Unit");
					this.OnUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlarmTextKorean", DbType="VarChar(100)")]
		public string AlarmTextKorean
		{
			get
			{
				return this._AlarmTextKorean;
			}
			set
			{
				if ((this._AlarmTextKorean != value))
				{
					this.OnAlarmTextKoreanChanging(value);
					this.SendPropertyChanging();
					this._AlarmTextKorean = value;
					this.SendPropertyChanged("AlarmTextKorean");
					this.OnAlarmTextKoreanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlarmTextChinese", DbType="VarChar(100)")]
		public string AlarmTextChinese
		{
			get
			{
				return this._AlarmTextChinese;
			}
			set
			{
				if ((this._AlarmTextChinese != value))
				{
					this.OnAlarmTextChineseChanging(value);
					this.SendPropertyChanging();
					this._AlarmTextChinese = value;
					this.SendPropertyChanged("AlarmTextChinese");
					this.OnAlarmTextChineseChanged();
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TM1_SENSOR1")]
	public partial class TM1_SENSOR1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.DateTime _ReceivedTime;
		
		private System.Nullable<float> _O2PPM;
		
		private System.Nullable<float> _O2Percent;
		
		private System.Nullable<float> _H2PPM;
		
		private System.Nullable<float> _Pressure;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReceivedTimeChanging(System.DateTime value);
    partial void OnReceivedTimeChanged();
    partial void OnO2PPMChanging(System.Nullable<float> value);
    partial void OnO2PPMChanged();
    partial void OnO2PercentChanging(System.Nullable<float> value);
    partial void OnO2PercentChanged();
    partial void OnH2PPMChanging(System.Nullable<float> value);
    partial void OnH2PPMChanged();
    partial void OnPressureChanging(System.Nullable<float> value);
    partial void OnPressureChanged();
    #endregion
		
		public TM1_SENSOR1()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceivedTime", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime ReceivedTime
		{
			get
			{
				return this._ReceivedTime;
			}
			set
			{
				if ((this._ReceivedTime != value))
				{
					this.OnReceivedTimeChanging(value);
					this.SendPropertyChanging();
					this._ReceivedTime = value;
					this.SendPropertyChanged("ReceivedTime");
					this.OnReceivedTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_O2PPM", DbType="Real")]
		public System.Nullable<float> O2PPM
		{
			get
			{
				return this._O2PPM;
			}
			set
			{
				if ((this._O2PPM != value))
				{
					this.OnO2PPMChanging(value);
					this.SendPropertyChanging();
					this._O2PPM = value;
					this.SendPropertyChanged("O2PPM");
					this.OnO2PPMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_O2Percent", DbType="Real")]
		public System.Nullable<float> O2Percent
		{
			get
			{
				return this._O2Percent;
			}
			set
			{
				if ((this._O2Percent != value))
				{
					this.OnO2PercentChanging(value);
					this.SendPropertyChanging();
					this._O2Percent = value;
					this.SendPropertyChanged("O2Percent");
					this.OnO2PercentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_H2PPM", DbType="Real")]
		public System.Nullable<float> H2PPM
		{
			get
			{
				return this._H2PPM;
			}
			set
			{
				if ((this._H2PPM != value))
				{
					this.OnH2PPMChanging(value);
					this.SendPropertyChanging();
					this._H2PPM = value;
					this.SendPropertyChanged("H2PPM");
					this.OnH2PPMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pressure", DbType="Real")]
		public System.Nullable<float> Pressure
		{
			get
			{
				return this._Pressure;
			}
			set
			{
				if ((this._Pressure != value))
				{
					this.OnPressureChanging(value);
					this.SendPropertyChanging();
					this._Pressure = value;
					this.SendPropertyChanged("Pressure");
					this.OnPressureChanged();
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
