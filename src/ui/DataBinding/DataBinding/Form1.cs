using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBinding.Annotations;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        public PLC_ADDRESS_INFORMATION testObj = new PLC_ADDRESS_INFORMATION();
        
        B _bClass = new B();

        private BindingSource _currentBindingSrc = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            _currentBindingSrc.Add(_bClass);
            //_currentBindingSrc.Add(_aClass);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = _currentBindingSrc;
        }
    }

    public enum E_DATA_TYPE
    {
        None,
        Decimal,
        HexaDecimal,
    }

    public enum E_MEMORY_AREA_TYPE
    {
        None,
        Bit,
        Word
    }

    public enum E_VALUE_TYPE
    {
        None,
        Int,
        ASCII
    }


    public class PLC_ADDRESS_INFORMATION : ICloneable, INotifyPropertyChanged
    {
        private readonly object _lock = new object();

        private string _name;
        private string _aliasName;
        private string _address;
        private E_MEMORY_AREA_TYPE _type;
        private int _size;
        private bool _diff;
        private string _bitIndex;
        private string _bitSize;
        private string _defaultValue;
        private E_VALUE_TYPE _valueType;
        private bool _isWrite;

        #region Property
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != this._name)
                {
                    this._name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string AliasName
        {
            get { return _aliasName; }
            set
            {
                if (value != this._aliasName)
                {
                    this._aliasName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (value != this._address)
                {
                    this._address = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public E_MEMORY_AREA_TYPE Type
        {
            get { return _type; }
            set
            {
                if (value != this._type)
                {
                    this._type = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Size
        {
            get { return _size; }
            set
            {
                if (value != this._size)
                {
                    this._size = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool Diff
        {
            get { return _diff; }
            set
            {
                if (value != this._diff)
                {
                    this._diff = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string BitIndex
        {
            get { return _bitIndex; }
            set
            {
                if (value != this._bitIndex)
                {
                    this._bitIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string BitSize
        {
            get { return _bitSize; }
            set
            {
                if (value != this._bitSize)
                {
                    this._bitSize = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string DefaultValue
        {
            get { return _defaultValue; }
            set
            {
                if (value != this._defaultValue)
                {
                    this._defaultValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public E_VALUE_TYPE ValueType
        {
            get { return _valueType; }
            set
            {
                if (value != this._valueType)
                {
                    this._valueType = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool IsWrite
        {
            get { return _isWrite; }
            set
            {
                if (value != this._isWrite)
                {
                    this._isWrite = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        public PLC_ADDRESS_INFORMATION()
        {
            this.Name = "";
            this.AliasName = "";
            this.Address = "";
            this.Type = E_MEMORY_AREA_TYPE.None;
            this.Size = 0;
            this.Diff = false;
            this.BitIndex = "";
            this.BitSize = "";
            this.DefaultValue = "";
            this.ValueType = E_VALUE_TYPE.None;
            this.IsWrite = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            lock (_lock)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public object Clone()
        {
            return new PLC_ADDRESS_INFORMATION()
            {
                Name = this.Name,
                AliasName = this.AliasName,
                Address = this.Address,
                Type = this.Type,
                Size = this.Size,
                Diff = this.Diff,
                BitIndex = this.BitIndex,
                BitSize = this.BitSize,
                DefaultValue = this.DefaultValue,
                ValueType = this.ValueType,
                IsWrite = this.IsWrite
            };
        }
    }

    public class B : PLC_ADDRESS_INFORMATION
    {
        private string _Value = "ABC";
        public string BTest
        {
            get { return _Value; }
            set
            {
                if (_Value != value)
                {
                    _Value = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
